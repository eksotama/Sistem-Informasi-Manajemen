using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmPrilakuKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPrilakuKerja(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan, FrmMenuClient frmmenuclient)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendJabatan = sendJabatan;
            this.frmmenuclient = frmmenuclient;
        }

        #region Event Metro Panel

        private void mtDataPrilakuKerja_Click(object sender, EventArgs e)
        {
            FrmDataPrilakuKerja frm = new FrmDataPrilakuKerja(viewForm, sendIpAddress, sendNama, sendJabatan, frmmenuclient, this);
            viewForm(frm);
        }

        private void mtInputPrilakuKerja_Click(object sender, EventArgs e)
        {
            procces = "Perilaku Kerja";

            FrmChoosePenilai frm = new FrmChoosePenilai(viewForm, sendIpAddress, sendNama, sendJabatan, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmPrilakuKerja_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
