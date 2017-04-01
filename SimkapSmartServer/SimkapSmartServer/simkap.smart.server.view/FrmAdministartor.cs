using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartServer.simkap.smart.server.view.administrator.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class  FrmAdministartor : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmAdministartor(string receiveNama, string receiveIp, FrmMenu frmMenu)
        {
            InitializeComponent();
            InitializeFunction();

            this.frmMenu = frmMenu;
            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
        }

        #region All Function

        private void InitializeFunction()
        {
            setAdministratorMethod();
            setDataAdministrator();
            setHeaderDgv();
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(true);
        }

        #region Setting

        private void setVisibleNotifikasiEditDefault(bool condition)
        {
            lblTextNotifikasi.Visible = !condition;
            panelNotifikasi.Visible = !condition;
        }

        private void setVisibleNotifikasiEditSucces()
        {
            lblTextNotifikasi.Visible = true;
            panelNotifikasi.Visible = true;
        }

        private void setEnableForm(bool condition)
        {
            this.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnClose.Enabled = condition;
            btnEdit.Enabled = !condition;
            btnCancel.Enabled = !condition;
        }

        private void setAdministratorMethod()
        {
            ia = Controller.getAdmin();
        }

        private void setDataAdministrator()
        {
            dgvAdministrator.DataSource = ia.selectAdministrator();
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendId = dgvAdministrator[0, e.RowIndex].Value.ToString();
                sendNama = dgvAdministrator[1, e.RowIndex].Value.ToString();

                if (dgvAdministrator.Rows[e.RowIndex].Cells["jekel"].Value.Equals("P"))
                {
                    sendJekel = "Pria";
                }

                if (dgvAdministrator.Rows[e.RowIndex].Cells["jekel"].Value.Equals("W"))
                {
                    sendJekel = "Wanita";
                }

                sendUser = dgvAdministrator[3, e.RowIndex].Value.ToString();
                sendPassword = dgvAdministrator[5, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        #endregion

        #region Display DGV

        private void setHeaderDgv()
        {
            dgvAdministrator.Columns[0].Visible = false;
            dgvAdministrator.Columns[1].HeaderText = "Nama Admin";
            dgvAdministrator.Columns[2].HeaderText = "Jenis Kelamin";
            dgvAdministrator.Columns[3].HeaderText = "Nama Pengguna";
            dgvAdministrator.Columns[4].HeaderText = "Kata Sandi";
            dgvAdministrator.Columns[5].Visible = false;

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvAdministrator.Columns[1].Width = 170;
            dgvAdministrator.Columns[2].Width = 100;
            dgvAdministrator.Columns[3].Width = 150;
            dgvAdministrator.Columns[4].Width = 260;

            setFormatDgv();
        }

        private void setFormatDgv()
        {
            dgvAdministrator.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmKelolaAdmin frm = new FrmKelolaAdmin(receiveIp, receiveNama, sendId, sendNama, setVisibleNotifikasiEditSucces,
                                                         sendJekel, sendUser, sendPassword, setDataAdministrator, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Event DataGridView

        private void dgvAdministrator_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            #region "Auto Number DataGridView"

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));

            #endregion
        }

        private void dgvAdministrator_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setEnableButton(false);
            setVisibleNotifikasiEditDefault(true);
        }

        #endregion

        private void FrmAdministartor_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
