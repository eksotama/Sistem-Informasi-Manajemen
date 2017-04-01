using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.skp.kelola;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmSasaranKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmSasaranKerja(Action<Form> viewForm1, string sendipaddress, string sendnama, string sendjabatan, 
                                        FrmMenuClient frmmenuclient)
        {
            InitializeComponent();

            this.viewForm1 = viewForm1;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.sendjabatan = sendjabatan;
            this.frmmenuclient = frmmenuclient;
        }

        #region Event Button

        private void mtInformationSKP_Click(object sender, EventArgs e)
        {
            FrmInformationSKP frm = new FrmInformationSKP(viewForm1, sendjabatan, sendipaddress, sendnama);
            viewForm1(frm);
        }

        private void mtInputSKP_Click(object sender, EventArgs e)
        {
            procces = "Sasaran Kerja";

            FrmChoosePenilai frm = new FrmChoosePenilai(viewForm1, sendipaddress, sendnama, sendjabatan, procces);
            viewForm1(frm);
        }

        private void mtDataSKP_Click(object sender, EventArgs e)
        {
            FrmViewDataSKP frm = new FrmViewDataSKP(sendnama, sendjabatan, viewForm1, sendipaddress, frmmenuclient, this);
            viewForm1(frm);
        }

        #endregion

        private void FrmSasaranKerja_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
