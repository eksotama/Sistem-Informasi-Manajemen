using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmCapaianKinerjaHarian : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCapaianKinerjaHarian(Action<Form> viewForm, string sendipaddress, string sendnama, string sendjabatan, FrmMenuClient frmMenuClient)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.sendjabatan = sendjabatan;
            this.frmMenuClient = frmMenuClient;
        }

        #region Event Metro Panel

        private void mtDataCapaianKinerjaHarian_Click(object sender, EventArgs e)
        {
            FrmViewDataCapaianKinerjaHarian frm = new FrmViewDataCapaianKinerjaHarian(viewForm, sendjabatan, sendipaddress, sendnama, frmMenuClient, this);
            viewForm(frm);
        }

        private void mtChoosePeriode_Click(object sender, EventArgs e)
        {
            procces = "Capaian Harian";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendjabatan, sendipaddress, sendnama, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmCapaianKinerjaHarian_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
