using System;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartServer.simkap.smart.server.remote.client;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmSettingServer : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmSettingServer()
        {
            InitializeComponent();
            InitializeFunction();
        }

        #region All Function

        private void InitializeFunction()
        {
            setViewDefaultRunningServer();
            setMethod();
            monitoringStart();
        }

        #region Setting

        private void setMethod()
        {
            ls = Controller.getLog();
            lc = Controller.getLogClient();
        }

        private void setViewDefaultRunningServer()
        {
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [main]          Initializing Modules\n");
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [main]          Starting Check-Timer\n");
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [main]          Control Panel Ready\n");
        }

        private void setViewStartServer()
        {
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Attempting to start Server...\n");
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Status change detected: running\n");
            backgroundWorker1.RunWorkerAsync();
        }

        private void setViewStopServer()
        {
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Attempting to stop Server (Port: 1001)\n");
            txtLogServer.AppendText(DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Status change detected: stopped\n");
            backgroundWorker1.RunWorkerAsync();
        }

        #endregion

        #region Connecting Method Remoting to Client

        #region Getter Method Remoting

        private void getRemoteValidationReport()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpValidationReport),
            "SimkapSmartServer.ImpValidationReport", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteReport()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpReport),
            "SimkapSmartServer.ImpReport", WellKnownObjectMode.SingleCall);
        }

        private void getRemotePeriode()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpValidationPeriode),
            "SimkapSmartServer.ImpValidationPeriode", WellKnownObjectMode.SingleCall);
        }

        private void getRemotePenilali()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpPenilai),
            "SimkapSmartServer.ImpPenilai", WellKnownObjectMode.SingleCall);
        }

        private void getRemotePrilakuKerja()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpPrilakuKerja),
            "SimkapSmartServer.ImpPrilakuKerja", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteUkurSasaran()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpUkurSasaran),
            "SimkapSmartServer.ImpUkurSasaran", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteRealisasi()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpRealisasi),
            "SimkapSmartServer.ImpRealisasi", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteLCKH()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpCapaianHarian),
            "SimkapSmartServer.ImpCapaianHarian", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteLoginClient()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpLoginClient),
            "SimkapSmartServer.ImpLoginClient", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteChangePasswordLogin()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpChangePassword),
            "SimkapSmartServer.ImpChangePassword", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteLogoutClient()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpLogoutClient),
            "SimkapSmartServer.ImpLogoutClient", WellKnownObjectMode.SingleCall);
        }

        private void getRemoteSasarnKerja()
        {
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(ImpSasaranKerja),
            "SimkapSmartServer.ImpSasaranKerja", WellKnownObjectMode.SingleCall);
        }

        #endregion

        private void clientSide()
        {
            try
            {
                serverChannel = new TcpChannel(port);
                ChannelServices.RegisterChannel(serverChannel, false);

                getRemoteLoginClient();
                getRemoteChangePasswordLogin();
                getRemoteLogoutClient();
                getRemoteSasarnKerja();
                getRemoteLCKH();
                getRemoteRealisasi();
                getRemoteUkurSasaran();
                getRemotePrilakuKerja();
                getRemotePenilali();
                getRemotePeriode();
                getRemoteReport();
                getRemoteValidationReport();
            }
            catch { }
        }

        private void stopServer()
        {
            try
            {
                serverChannel.StopListening(null);
                RemotingServices.Disconnect(this);
                ChannelServices.UnregisterChannel(serverChannel);
                serverChannel = null;
            }
            catch { }
        }

        private void startServer()
        {
            client1 = new ThreadStart(clientSide);
            client2 = new Thread(client1);
            client2.Start();
        }

        #endregion

        #region Connecting Method Monitoring to Client

        private void monitoringStart()
        {
            tcpServerRunThread = new Thread(new ThreadStart(monitoringMethod));
            tcpServerRunThread.Start();
        }

        private void monitoringMethod()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 1111);
                tcpListener.Start();

                while (true)
                {
                    client = tcpListener.AcceptTcpClient();
                    tcpHandlerThread = new Thread(new ParameterizedThreadStart(tcpHandler));
                    tcpHandlerThread.Start(client);
                }
            }
            catch { }

        }

        // monitoring method proses update
        private void tcpHandler(object client)
        {
            try
            {
                updateUI(Encoding.ASCII.GetString(lc.readTransactionClient(client)));
            }
            catch { }
        }

        // monitoring update textbox
        private void updateUI(string s)
        {
            try
            {
                Func<int> del = delegate ()
                {
                    txtLogKlien.AppendText(s + System.Environment.NewLine);
                    return 0;
                };
                Invoke(del);
            }
            catch { }
        }

        #endregion

        #endregion

        #region Event Button

        private void switchButton_ValueChanged(object sender, EventArgs e)
        {
            if (switchButton.Value == true)
            {
                startServer();

                ls.writeLogRunningServer(DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Attempting to start Server...\n");

                setViewStartServer();
            }
            else
            {
                stopServer();

                ls.writeLogRunningServer(DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Attempting to stop Server (Port: 1001)\n");

                setViewStopServer();
            }
        }

        #endregion

        private void FrmSettingServer_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            ls.writeLogRunningServer(DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("hh:mm:ss") + "  [Server]       Attempting to stop Server (Port: 1001)\n");
        }

        private void FrmSettingServer_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
