using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.capaian.kinerja.harian
{
    public partial class FrmUpdateLCKH : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUpdateLCKH(string sendstatuskegiatan, string sendvolume, string sendidcapaian, string sendiddetaikegiatan, 
                                string date, string sendjabatan, string sendipaddress, 
                                    string sendnama, Action setDataLCKH, Action setVisibleNotifikasiEditSucces, 
                                        FrmMenuKelola frmmenukelola, FrmMenuClient frmMenuClient, 
                                            FrmViewDataCapaianKinerjaHarian frmViewDataCapaianKinerjaHarian)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendidcapaian = sendidcapaian;
            this.sendiddetaikegiatan = sendiddetaikegiatan;
            this.date = date;
            this.sendjabatan = sendjabatan;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.setDataLCKH = setDataLCKH;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.frmmenukelola = frmmenukelola;
            this.frmMenuClient = frmMenuClient;
            this.frmViewDataCapaianKinerjaHarian = frmViewDataCapaianKinerjaHarian;
            this.sendstatuskegiatan = sendstatuskegiatan;
            txtVolume.Text = sendvolume;
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
            frmMenuClient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
            frmViewDataCapaianKinerjaHarian.Enabled = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setValidasiButtonSave()
        {
            if (txtVolume.Text == null)
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
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Capaian Kinerja Harian" + "]" + "" +
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
            obj = "SimkapSmartServer.ImpCapaianHarian";

            irl = (IntRemoteLCKH)Activator.GetObject(typeof(IntRemoteLCKH), setting.getUrl(obj));
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

        #region Method Edit Capaian Kinerja Harian

        private void edit()
        {
            elc = new EntLCKH();
            elcsync = new EntLCKH();
            etc = new EntRemoteTransactionClient();

            elc.Idcapaian = Convert.ToInt32(sendidcapaian);
            elc.Jumlah = Convert.ToInt32(txtVolume.Text);

            elcsync.Jumlah = Convert.ToInt32(txtVolume.Text);
            elcsync.Tanggal = date;
            elcsync.Idetailkegiatan = sendiddetaikegiatan;

            etc.Text = setData();

            if (sendstatuskegiatan.Equals("Tidak Sinkron", StringComparison.InvariantCultureIgnoreCase))
            {
                condition = irl.edit(elc, etc);

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
            else
            {
                condition = irl.editSync(elcsync, etc);

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
        }

        #endregion

        #endregion

        #region Validation Button

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            setValidasiButtonSave();
        }

        private void txtVolume_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Event Button

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                edit();
                btnClose_Click(sender, e);
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada  : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }


        #endregion

        private void FrmUpdateLCKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataLCKH();
        }
    }
}
