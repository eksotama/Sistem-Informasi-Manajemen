using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all
{
    public partial class FrmChoosePenilai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmChoosePenilai(Action<Form> viewForm1, string sendipaddress, string sendnama, string sendjabatan, string procces)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm1 = viewForm1;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.sendjabatan = sendjabatan;
            this.procces = procces;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setEnableButton(true);
            setEnableCmbPenilai(true);
        }

        #region Setting

        private void setEnableButton(bool conditon)
        {
            btnNext.Enabled = !conditon;
        }

        private void setCmbPenilai()
        {
            if (sendjabatan.Equals("Kepala KUA Kec. Klaten Selatan                                   ",
                StringComparison.InvariantCultureIgnoreCase))
            {
                cmbPenilai.DataSource = ip.selectPenilaiKepala();
                cmbPenilai.DisplayMember = "nama";
                cmbPenilai.ValueMember = "idpejabatpenilai";
            }
            else
            {
                cmbPenilai.DataSource = ip.selectPenilaiStaff();
                cmbPenilai.DisplayMember = "nama";
                cmbPenilai.ValueMember = "idpejabatpenilai";
            }
        }

        private void setCmbAtasanPenilai()
        {
            if (sendjabatan.Equals("Kepala KUA Kec. Klaten Selatan                                   ",
                 StringComparison.InvariantCultureIgnoreCase))
            {
                cmbAtasanPenilai.DataSource = ip.selectAtasanPenilaiKepala();
                cmbAtasanPenilai.DisplayMember = "nama";
                cmbAtasanPenilai.ValueMember = "idatasanpejabatpenilai";
            }
            else
            {
                cmbAtasanPenilai.DataSource = ip.selectAtasanPenilaiStaff();
                cmbAtasanPenilai.DisplayMember = "nama";
                cmbAtasanPenilai.ValueMember = "idatasanpejabatpenilai";
            }
        }

        private void setValidasiButton()
        {
            if (cmbAtasanPenilai.SelectedValue == null || cmbPenilai.SelectedValue == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void setEnableCmbPenilai(bool condition)
        {
            cmbAtasanPenilai.Enabled = !condition;
            cmbPenilai.Enabled = !condition;
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(getMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void getMethod()
        {
            obj = "SimkapSmartServer.ImpPenilai";

            ip = (IntRemotePenilai)Activator.GetObject(typeof(IntRemotePenilai), setting.getUrl(obj));
        }

        #endregion

        #endregion

        #region Validation Button

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            if (dtPeriodeAkhir.Value != null)
            {
                setEnableCmbPenilai(false);
            }
            else
            {
                setEnableCmbPenilai(true);
            }
        }

        private void cmbPenilai_SelectedValueChanged(object sender, EventArgs e)
        {
                setValidasiButton();
                sendidpenilai = cmbPenilai.SelectedValue.ToString();
        }

        private void cmbAtasanPenilai_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiButton();
            sendidatasanpenilai = cmbAtasanPenilai.SelectedValue.ToString();
        }

        #endregion

        #region Event Button and ComboBox

        private void cmbPenilai_Click(object sender, EventArgs e)
        {
            try
            {
                setCmbPenilai();
            }
            catch
            {
                message = "Koneksi ke server terputus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbAtasanPenilai_Click(object sender, EventArgs e)
        {
            try
            {
                setCmbAtasanPenilai();
            }
            catch
            {
                message = "Koneksi ke server terputus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (procces.Equals("Sasaran Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm1, sendipaddress, sendnama, sendjabatan, frmmenuclient);
                viewForm1(frm);
            }
            else if (procces.Equals("Perilaku Kerja",
                     StringComparison.InvariantCultureIgnoreCase))
            {
                this.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (procces.Equals("Sasaran Kerja",
                     StringComparison.InvariantCultureIgnoreCase))
            {
                FrmCreateTarget frm = new FrmCreateTarget(sendipaddress, sendnama, sendidpenilai, sendidatasanpenilai,
                                        dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd"), dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd"), sendjabatan, viewForm1);
                viewForm1(frm);
            }
            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {

                try
                {
                    et = new EntValidationPeriode();

                    et.Jabatan = sendjabatan;
                    et.Periodeawal = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
                    et.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");

                    condition = ip.selectPeriode(et);

                    if (condition)
                    {
                        FrmWorksheetPrilakuKerja frm = new FrmWorksheetPrilakuKerja(sendipaddress, sendnama, sendidpenilai, sendidatasanpenilai,
                                    dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd"), dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd"), sendjabatan, viewForm1);
                        viewForm1(frm);
                    }
                    else
                    {
                        message = "Tidak ada data kegiatan pada periode " + dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd") + " s/d " +
                                    dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd") + " untuk dinilai perilaku kerjanya";

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    message = "Koneksi ke server terputus";

                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void FrmChoosePenilai_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
