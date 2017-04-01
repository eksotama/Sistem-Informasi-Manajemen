using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.skp.kelola;
using SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.realisasi;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmMenuKelola : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenuKelola(string procces, Action<Form> viewForm, string sendipaddress, string sendnama, string sendjabatan, 
                                FrmMenuClient frmMenuClient)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.sendjabatan = sendjabatan;
            this.frmMenuClient = frmMenuClient;
            this.procces = procces;

            setTitleForm();
        }

        #region Setting

        private void setTitleForm()
        {
            if (procces.Equals("Sasaran Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Sasaran Kerja - SIMKAP 1.0.0";
                mtDataKelola.TitleText = "Lihat Data Sasaran Kerja";
                mtKelola.TitleText = "Kelola Sasaran Kerja";
                lblKet.Text = "Menu Kelola Sasaran Kerja";
            }
            else if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Capaian Kinerja Harian - SIMKAP 1.0.0";
                mtDataKelola.TitleText = "Lihat Data Capaian Kinerja Harian";
                mtKelola.TitleText = "Kelola Capaian Kinerja Harian";
                lblKet.Text = "Menu Kelola Capaian Kinerja Harian";
            }
            else if (procces.Equals("Realisasi",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Realisasi - SIMKAP 1.0.0";
                mtDataKelola.TitleText = "Lihat Data Realisasi";
                mtKelola.TitleText = "Kelola Realisasi";
                lblKet.Text = "Menu Kelola Realisasi";
            }
            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Ukur Sasaran - SIMKAP 1.0.0";
                mtDataKelola.TitleText = "Lihat Data Ukur Sasaran";
                mtKelola.TitleText = "Kelola Ukur Sasaran";
                lblKet.Text = "Menu Kelola Ukur Sasaran";
            }
            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Perilaku Kerja - SIMKAP 1.0.0";
                mtDataKelola.TitleText = "Lihat Data Perilaku Kerja";
                mtKelola.TitleText = "Kelola Perilaku Kerja";
                lblKet.Text = "Menu Kelola Perilaku Kerja";
            }

            lblKet.Font = new System.Drawing.Font("Roboto Condensed", 20, System.Drawing.FontStyle.Bold);
        }

        #endregion

        #region Event Metro Panel

        private void mtDataKelola_Click(object sender, EventArgs e)
        {
            if (procces.Equals("Sasaran Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                FrmViewDataSKP frm = new FrmViewDataSKP(sendnama, sendjabatan, viewForm, sendipaddress, frmMenuClient, this);
                viewForm(frm);
            }
            else if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmViewDataCapaianKinerjaHarian frm = new FrmViewDataCapaianKinerjaHarian(viewForm, sendjabatan, sendipaddress, 
                                                                sendnama, frmMenuClient, this);
                viewForm(frm);
            }
            else if (procces.Equals("Realisasi",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmDataRealisasi frm = new FrmDataRealisasi(viewForm, sendipaddress, sendnama, sendjabatan);
                viewForm(frm);
            }
            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmDataUkurSasaran frm = new FrmDataUkurSasaran(viewForm, sendipaddress, sendnama, sendjabatan);
                viewForm(frm);
            }
            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmDataPrilakuKerja frm = new FrmDataPrilakuKerja(viewForm, sendipaddress, sendnama, sendjabatan,
                                                                 frmMenuClient, this);
                viewForm(frm);
            }
        }

        private void mtKelola_Click(object sender, EventArgs e)
        {
            if (procces.Equals("Sasaran Kerja",
                    StringComparison.InvariantCultureIgnoreCase) || procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmChoosePenilai frm = new FrmChoosePenilai(viewForm, sendipaddress, sendnama, sendjabatan, procces);
                viewForm(frm);
            }
            else if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase) || procces.Equals("Realisasi",
                        StringComparison.InvariantCultureIgnoreCase) || procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendjabatan, sendipaddress, sendnama, procces);
                viewForm(frm);
            }
        }

        #endregion

        private void FrmMenuKelola_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
