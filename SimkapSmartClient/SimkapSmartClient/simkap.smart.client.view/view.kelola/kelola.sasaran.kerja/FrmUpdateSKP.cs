using System;
using System.Threading;
using System.Windows.Forms;
using DevComponents.Editors.DateTimeAdv;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.skp.kelola
{
    public partial class FrmUpdateSKP : DevComponents.DotNetBar.Metro.MetroForm
    {

        public FrmUpdateSKP(DateTimeInput sendperiodeawal, string sendjabatan, string sendipaddress, string sendnama, 
                                Action setDataSKP, Action setVisibleNotifikasiEditSucces, 
                                FrmMenuKelola frmmenukelola, FrmMenuClient frmmenuclient, FrmViewDataSKP frmViewDataSKP)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendjabatan = sendjabatan;
            this.sendnama = sendnama;
            this.sendipaddress = sendipaddress;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.frmmenukelola = frmmenukelola;
            this.frmmenuclient = frmmenuclient;
            this.frmViewDataSKP = frmViewDataSKP;
            this.setDataSKP = setDataSKP;
            this.sendperiodeawal = sendperiodeawal;
        }

        #region All Function

        public void InitializeFunction()
        {
            startRemote();
            setEnableButton(true);
        }

        #region Setting

        private void setEnableForm(bool condition)
        {
            frmmenuclient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
            frmViewDataSKP.Enabled = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setValidasiButtonSave()
        {
            if(dtPeriodeAkhir.Value.Date.ToString() == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Sasaran Kerja" + "]" + "" +
                    "" + "   " + sendipaddress + "   " + sendnama + "\n";

            return data;
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateSKPMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateSKPMethod()
        {
            obj = "SimkapSmartServer.ImpSasaranKerja";

            isk = (IntRemoteSasaranKerja)Activator.GetObject(typeof(IntRemoteSasaranKerja), setting.getUrl(obj));
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
            mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        #endregion

        #region Method Edit SKP

        private void edit()
        {
            esk = new EntSasaranKerja();
            etc = new EntRemoteTransactionClient();

            esk.Periodeawal = sendperiodeawal.Text;
            esk.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");
            esk.Jabatan = sendjabatan;

            etc.Text = setData();

            condition = isk.edit(esk, etc);

            if (condition)
            {
                sendDataToServer();
                setVisibleNotifikasiEditSucces();
            }
            else
            {
                message = "Data gagal diubah";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #endregion

        #region Validation Button

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            setValidasiButtonSave();
        }

        #endregion

        #region Event Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            edit();
            btnClose_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmUpdateSKP_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataSKP();
        }
    }
}
