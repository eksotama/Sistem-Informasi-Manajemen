using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;


namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja
{
    public partial class FrmUpdatePrilakuKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUpdatePrilakuKerja(int sendIdPrilaku, double sendOrientasi, double sendIntegritas, double sendKomitmen, 
                                        double sendDisiplin, double sendKerjasama, double sendKepemimpinan, double sendJumlah, 
                                        double sendNilaiRata, string sendJabatan, string sendIpAddress, string sendNama, 
                                        Action setDataPrilakuKerja, Action setVisibleNotifikasiEditSucces,
                                        FrmMenuKelola frmmenukelola, FrmMenuClient frmmenuclient, FrmDataPrilakuKerja frmDataPrilakuKerja)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendIdPrilaku = sendIdPrilaku;
            this.sendJabatan = sendJabatan;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.setDataPrilakuKerja = setDataPrilakuKerja;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.frmmenukelola = frmmenukelola;
            this.frmmenuclient = frmmenuclient;
            this.frmDataPrilakuKerja = frmDataPrilakuKerja;

            txtOrientasi.Text = Convert.ToString(sendOrientasi);
            txtIntegritas.Text = Convert.ToString(sendIntegritas);
            txtKomitmen.Text = Convert.ToString(sendKomitmen);
            txtDisiplin.Text = Convert.ToString(sendDisiplin);
            txtKerjasama.Text = Convert.ToString(sendKerjasama);
            txtKepemimpinan.Text = Convert.ToString(sendKepemimpinan);
            txtJumlah.Text = Convert.ToString(sendJumlah);
            txtNilaiRata.Text = Convert.ToString(sendNilaiRata);

            if (sendJabatan.Equals("Kepala KUA Kec. Klaten Selatan                                   ",
                StringComparison.InvariantCultureIgnoreCase))
            {
                //
            }
            else
            {
                txtKepemimpinan.ReadOnly = true;
                txtKepemimpinan.Cursor = Cursors.No;
            }
        }

        #region All Function

        public void InitializeFunction()
        {
            startRemote();
            setEnableButton(true);
        }

        #region Setting

        private void setValidationNumber(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false
                 && (int)e.KeyChar != (int)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void setFormatInput(TextBox textbox)
        {
            try
            {
                var = Convert.ToDouble(textbox.Text);
                textbox.Text = var.ToString("N2");
                textbox.SelectionStart = textbox.Text.Length;
            }
            catch
            {
                textbox.Text = "";
            }

        }

        private void setEnableForm(bool condition)
        {
            frmmenuclient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
            frmDataPrilakuKerja.Enabled = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setValidasiButtonSave()
        {
            if (txtOrientasi.Text == "" || txtKomitmen.Text == "" || txtKerjasama.Text == "" || txtKepemimpinan.Text == "" ||
                    txtIntegritas.Text == "" || txtDisiplin.Text == "")
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
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Prilaku Kerja" + "]" + "" +
                    "" + "   " + sendIpAddress + "   " + sendNama + "\n";

            return data;
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreatePrilakuKerjaMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreatePrilakuKerjaMethod()
        {
            obj = "SimkapSmartServer.ImpPrilakuKerja";

            ipl = (IntRemotePrilakuKerja)Activator.GetObject(typeof(IntRemotePrilakuKerja), setting.getUrl(obj));
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

        #region Count

        private void countNilai()
        {
            try
            {
                #region Jumlah

                jumlah = Convert.ToDouble(txtDisiplin.Text) + Convert.ToDouble(txtIntegritas.Text) + Convert.ToDouble(txtKepemimpinan.Text) +
                            Convert.ToDouble(txtKerjasama.Text) + Convert.ToDouble(txtKomitmen.Text) + Convert.ToDouble(txtOrientasi.Text);

                txtJumlah.Text = jumlah.ToString("N2");

                #endregion

                #region Rata-Rata

                if (Convert.ToDouble(txtKepemimpinan.Text) == 0)
                {
                    ratarata = jumlah / 5;
                }
                else
                {
                    ratarata = jumlah / 6;
                }

                txtNilaiRata.Text = ratarata.ToString("N2");

                #endregion
            }
            catch { }
        }

        #endregion

        #region Method Edit Prilaku Kerja

        private void edit()
        {
            epk = new EntPrilakukerja();
            etc = new EntRemoteTransactionClient();

            epk.Idprilaku = Convert.ToInt32(sendIdPrilaku);
            epk.Orientasi = Convert.ToDouble(txtOrientasi.Text);
            epk.Integritas = Convert.ToDouble(txtIntegritas.Text);
            epk.Disiplin = Convert.ToDouble(txtDisiplin.Text);
            epk.Kerjasama = Convert.ToDouble(txtKerjasama.Text);
            epk.Kepemimpinam = Convert.ToDouble(txtKepemimpinan.Text);
            epk.Komitmen = Convert.ToDouble(txtKomitmen.Text);
            epk.Jumlah = Convert.ToDouble(txtJumlah.Text);
            epk.Ratarata = Convert.ToDouble(txtNilaiRata.Text);

            etc.Text = setData();

            condition = ipl.edit(epk, etc);

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

        private void txtOrientasi_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtOrientasi);
            setValidasiButtonSave();
        }

        private void txtIntegritas_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtIntegritas);
            setValidasiButtonSave();
        }

        private void txtKomitmen_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKomitmen);
            setValidasiButtonSave();
        }

        private void txtDisiplin_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtDisiplin);
            setValidasiButtonSave();
        }

        private void txtKerjasama_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKerjasama);
            setValidasiButtonSave();
            countNilai();
        }

        private void txtKepemimpinan_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKepemimpinan);
            setValidasiButtonSave();
            countNilai();
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtJumlah);
        }

        private void txtNilaiRata_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtNilaiRata);
        }

        #endregion

        #region Validation Number

        private void txtOrientasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        private void txtIntegritas_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        private void txtKomitmen_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        private void txtDisiplin_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        private void txtKerjasama_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        private void txtKepemimpinan_KeyPress(object sender, KeyPressEventArgs e)
        {
            setValidationNumber(e);
        }

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            edit();
            btnClose_Click(sender, e);
        }

        #endregion

        private void FrmUpdatePrilakuKerja_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataPrilakuKerja();
        }
    }
}
