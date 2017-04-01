using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmMenu : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenu(string sendNama, string sendIpServer, string sendHostServer)
        {
            InitializeComponent();
            InitializeFunction();

            lblNama.Text = sendNama;
            lblIpServer.Text = sendIpServer;
            lblHostServer.Text = sendHostServer;
        }

        #region All Function

        private void InitializeFunction()
        {
            setTimer();
            setLogoutMethod();
        }

        #region Method Logout

        private void logoutUser()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Logout" + "]" + "" +
                 "" + "   " + lblIpServer.Text + "   " + lblNama.Text;

            ls.writeLogTrasaction(log);
        }


        #endregion

        #region Setting

        private void setLogoutMethod()
        {
            ls = Controller.getLog();
        }

        private void setTimer()
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToLongDateString();
            lblJam.Text = DateTime.Now.ToLongTimeString();
        }

        private void viewForm(Form frm)
        {
            splitContainer1.Panel2.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            frm.Show();
            splitContainer1.Panel2.Controls.Add(frm);
        }

        #endregion

        #endregion

        #region Event Button Kelola 

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            FrmPegawai frm = new FrmPegawai(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnKegiatanPegawai_Click(object sender, EventArgs e)
        {
            FrmKegiatanPegawai frm = new FrmKegiatanPegawai(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnAtasanPenilai_Click(object sender, EventArgs e)
        {
            FrmAtasanPenilai frm = new FrmAtasanPenilai(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnPejabatPenilai_Click(object sender, EventArgs e)
        {
            FrmPejabatPenilai frm = new FrmPejabatPenilai(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnKegiatan_Click(object sender, EventArgs e)
        {
            FrmKegiatan frm = new FrmKegiatan(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnJenisKegiatan_Click(object sender, EventArgs e)
        {
            FrmJenisKegiatan frm = new FrmJenisKegiatan(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnUnitKerja_Click(object sender, EventArgs e)
        {
            FrmUnitKerja frm = new FrmUnitKerja(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdministartor frm = new FrmAdministartor(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        private void btnLoginPegawai_Click(object sender, EventArgs e)
        {
            FrmLoginPegawai frm = new FrmLoginPegawai(lblNama.Text, lblIpServer.Text, this);
            viewForm(frm);
        }

        #endregion

        #region "Event Button Panel Kontrol

        private void btnCPU_Click(object sender, EventArgs e)
        {
            FrmPerformanceCPU frm = new FrmPerformanceCPU();
            viewForm(frm);
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            FrmSettingServer frm = new FrmSettingServer();
            viewForm(frm);
        }

        #endregion

        private void btnTentangSimkap_Click(object sender, EventArgs e)
        {
            FrmTentangSimkap frm = new FrmTentangSimkap();
            frm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin keluar dari aplikasi ini ?";

            if (MessageBox.Show(message, "Konfirmasi - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmLogin frm = new FrmLogin();
                frm.Show();
                this.Close();
            }
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            logoutUser();
        }
    }
}
