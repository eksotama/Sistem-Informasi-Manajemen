using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.realisasi;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmRealisasi : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmRealisasi(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendJabatan = sendJabatan;
        }

        #region Event Metro Panel

        private void mtDataRealisasiKegiatan_Click(object sender, EventArgs e)
        {
            FrmDataRealisasi frm = new FrmDataRealisasi(viewForm, sendIpAddress, sendNama, sendJabatan);
            viewForm(frm);
        }

        private void mtChoosePeriode_Click(object sender, EventArgs e)
        {
            procces = "Realisasi";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendJabatan, sendIpAddress, sendNama, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmRealisasi_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
