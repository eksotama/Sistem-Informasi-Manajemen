using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmUkurSasaranKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUkurSasaranKerja(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendJabatan = sendJabatan;
        }

        #region Event Metro Panel

        private void mtDataUkurSasaran_Click(object sender, EventArgs e)
        {
            FrmDataUkurSasaran frm = new FrmDataUkurSasaran(viewForm, sendIpAddress, sendNama, sendJabatan);
            viewForm(frm);
        }

        private void mtWorksheetUkurSasaran_Click(object sender, EventArgs e)
        {
            procces = "Ukur Sasaran";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendJabatan, sendIpAddress, sendNama, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmUkurSasaranKerja_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
