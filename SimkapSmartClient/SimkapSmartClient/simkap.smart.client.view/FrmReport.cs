using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.input;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmReport : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmReport(Action<Form> viewForm, string sendJabatan)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendJabatan = sendJabatan;
        }

        #region Event Button

        private void mtCoverLaporan_Click(object sender, EventArgs e)
        {
            procces = "Cover";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtLaporanLCKH_Click(object sender, EventArgs e)
        {
            procces = "Capaian Harian";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtLaporanSKP_Click(object sender, EventArgs e)
        {
            procces = "Sasaran Kerja";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtLaporanUkurSasaran_Click(object sender, EventArgs e)
        {
            procces = "Ukur Sasaran";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtLaporanPrilakuKerja_Click(object sender, EventArgs e)
        {
            procces = "Perilaku Kerja";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtLaporanPerstasiKerja_Click(object sender, EventArgs e)
        {
            procces = "Prestasi Kerja";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm); ;
        }

        private void mtLampiranLaporan_Click(object sender, EventArgs e)
        {
            procces = "Lampiran";

            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmReport_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
