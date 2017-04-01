using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja
{
    public partial class FrmWorksheetPrilakuKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmWorksheetPrilakuKerja(string sendIpAddress, string sendNama, string sendidpenilai, string sendidatasanpenilai,
                                           string sendPeriodeAwal, string sendPeriodeAkhir, string sendJabatan, Action<Form> viewForm)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendidpenilai = sendidpenilai;
            this.sendidatasanpenilai = sendidatasanpenilai;
            this.sendPeriodeAkhir = sendPeriodeAkhir;
            this.sendPeriodeAwal = sendPeriodeAwal;
            this.sendJabatan = sendJabatan;
            this.viewForm = viewForm;

            if (sendJabatan.Equals("Kepala KUA Kec. Klaten Selatan                                   ",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                //
            }
            else
            {
                defaultvalue = 0;
                txtKepemimpinan.Text = defaultvalue.ToString("N2");
                txtKepemimpinan.ReadOnly = true;
                txtKepemimpinan.Cursor = Cursors.No;
            }
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setEnableButton(true);
            setVisibleNotifikasiSave(true);
        }

        #region Setting

        private void setCmbNIP()
        {
            epk = new EntPrilakukerja();

            epk.Jabatan = sendJabatan;

            cmbNip.DataSource = ipk.setCmbNIP(epk);
            cmbNip.DisplayMember = "nip";
            cmbNip.ValueMember = "nip";
        }

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

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Prilaku Kerja" + "]" + "" +
                    "" + "   " + sendIpAddress + "   " + sendNama + "\n";

            return data;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setVisibleNotifikasiSave(bool condition)
        {
            lblTextNotifikasi.Visible = !condition;
            panelNotifikasi.Visible = !condition;
        }

        private void clearData()
        {
            txtDisiplin.ResetText();
            txtIntegritas.ResetText();
            txtJumlah.ResetText();
            txtKepemimpinan.ResetText();
            txtKerjasama.ResetText();
            txtKomitmen.ResetText();
            txtNilaiRata.ResetText();
            txtOrientasi.ResetText();
        }

        private void setValidasiTextBox()
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

            ipk = (IntRemotePrilakuKerja)Activator.GetObject(typeof(IntRemotePrilakuKerja), setting.getUrl(obj));
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

        #region Method Insert

        private void save()
        {
            epk = new EntPrilakukerja();
            etc = new EntRemoteTransactionClient();

            epk.Periodeawal = sendPeriodeAwal;
            epk.Periodeakhir = sendPeriodeAkhir;
            epk.Idatasanpenilai = sendidatasanpenilai;
            epk.Idpejabatpenilai = sendidpenilai;
            epk.Nip = cmbNip.SelectedValue.ToString();
            epk.Orientasi = Convert.ToDouble(txtOrientasi.Text);
            epk.Integritas = Convert.ToDouble(txtIntegritas.Text);
            epk.Disiplin = Convert.ToDouble(txtDisiplin.Text);
            epk.Kerjasama = Convert.ToDouble(txtKerjasama.Text);
            epk.Kepemimpinam = Convert.ToDouble(txtKepemimpinan.Text);
            epk.Komitmen = Convert.ToDouble(txtKomitmen.Text);
            epk.Jumlah = Convert.ToDouble(txtJumlah.Text);
            epk.Ratarata = Convert.ToDouble(txtNilaiRata.Text);
            epk.Jabatan = sendJabatan;

            etc.Text = setData();

            validation = ipk.validationInsert(epk);

            if (validation)
            {
                message = "Anda sudah menginputkan data nilai pada periode " + sendPeriodeAwal + " - " + sendPeriodeAkhir;

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = ipk.save(epk, etc);

                if (condition)
                {
                    sendDataToServer();

                    clearData();
                    setVisibleNotifikasiSave(false);
                }
                else
                {
                    message = "Data gagal disimpan";
                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            procces = "Perilaku Kerja";

            FrmChoosePenilai frm = new FrmChoosePenilai(viewForm, sendIpAddress, sendNama, sendJabatan, procces);
            viewForm(frm);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch { }
        }

        #endregion

        #region Validation Button

        private void txtKepemimpinan_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKepemimpinan);
            setValidasiTextBox();
            countNilai();
        }

        private void txtIntegritas_TextChanged(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
            setFormatInput(txtIntegritas);
            setValidasiTextBox();
        }

        private void txtKomitmen_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKomitmen);
            setValidasiTextBox();
        }

        private void txtDisiplin_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtDisiplin);
            setValidasiTextBox();
        }

        private void txtKerjasama_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtKerjasama);
            setValidasiTextBox();
            countNilai();
        }

        private void txtOrientasi_TextChanged(object sender, EventArgs e)
        {
            setFormatInput(txtOrientasi);
            setValidasiTextBox();
        }

        #endregion

        #region Validation Number

        private void txtOrientasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            setCmbNIP();
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

        private void FrmWorksheetPrilakuKerja_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
