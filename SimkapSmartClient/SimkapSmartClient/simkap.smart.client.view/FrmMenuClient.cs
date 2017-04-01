using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmMenuClient : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenuClient(string sendNama, string sendIpServer, string sendHostServer, string sendJabatan)
        {
            InitializeComponent();
            InitializeFunction();

            lblNama.Text = sendNama;
            lblIpAddress.Text = sendIpServer;
            lblHostName.Text = sendHostServer;
            lblJabatan.Text = sendJabatan;
        }

        #region All Function

        private void InitializeFunction()
        {
            setTimer();
            startRemote();
        }

        #region Setting

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Logout" + "]" + "" +
                    "" + "   " + lblIpAddress.Text + "   " + lblNama.Text + "\n";

            return data;
        }

        private void viewForm(Form frm)
        {
            splitContainer1.Panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            splitContainer1.Panel2.Controls.Add(frm);
        }

        private void setTimer()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            ThreadStart client1 = new ThreadStart(setLogoutMethod);
            Thread client2 = new Thread(client1);
            client2.Start();
        }

        private void setLogoutMethod()
        {
            obj = "SimkapSmartServer.ImpLogoutClient";

            rswc = (IntRemoteSaveWriteTransactionClient)Activator.GetObject(typeof(IntRemoteSaveWriteTransactionClient), setting.getUrl(obj));
            rwc = (IntRemoteWriteTransactionClient)Activator.GetObject(typeof(IntRemoteWriteTransactionClient), setting.getUrl(obj));
        }

        #endregion

        #region Connected Method Monitoring to Server

        private void ConnectAsClient()
        {
            string s = setData();

            rwc.writeLogTransactionClient(s, setting.getServer(), setting.getPort2());
        }

        private void sendDataToServer()
        {
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        #endregion

        #endregion

        #region Event Metro Panel

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword(lblIpAddress.Text, lblNama.Text);
            viewForm(frm);
        }

        private void mtSKP_Click(object sender, EventArgs e)
        {
            procces = "Sasaran Kerja";

            FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, lblIpAddress.Text, lblNama.Text, lblJabatan.Text, this);
            viewForm(frm);
        }

        private void mtLCKH_Click(object sender, EventArgs e)
        {
            procces = "Capaian Harian";

            FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, lblIpAddress.Text, lblNama.Text, lblJabatan.Text, this);
            viewForm(frm);
        }

        private void mtRealisasi_Click(object sender, EventArgs e)
        {
            procces = "Realisasi";

            FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, lblIpAddress.Text, lblNama.Text, lblJabatan.Text, this);
            viewForm(frm);
        }

        private void mtUkurSasaran_Click(object sender, EventArgs e)
        {
            procces = "Ukur Sasaran";

            FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, lblIpAddress.Text, lblNama.Text, lblJabatan.Text, this);
            viewForm(frm);
        }

        private void mtLPrilakuKerja_Click(object sender, EventArgs e)
        {
            procces = "Perilaku Kerja";

            FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, lblIpAddress.Text, lblNama.Text, lblJabatan.Text, this);
            viewForm(frm);
        }

        private void mtLaporan_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport(viewForm, lblJabatan.Text);
            viewForm(frm);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin keluar dari aplikasi ini?";

            if (MessageBox.Show(message, "Konfirmasi - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                rswc.writeSaveLogTransactionClient(setData());
                sendDataToServer();

                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Hide();
            }
        }

        #endregion

        private void FrmMenuClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            rswc.writeSaveLogTransactionClient(setData());
            sendDataToServer();
        }
    }
}
