using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.login.pegawai.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmLoginPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLoginPegawai(string receiveNama, string receiveIp, FrmMenu frmMenu)
        {
            InitializeComponent();
            InitializeFunction();

            this.receiveNama = receiveNama;
            this.receiveIp = receiveIp;
            this.frmMenu = frmMenu;
        }

        #region All Function

        private void InitializeFunction()
        {
            setLoginPegawaiMethod();
            setDataLoginPegawai();
            setHeaderDgv();

            setEnableButton(true);
        }

        #region Setting

        private void setEnableForm(bool condition)
        {
            this.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnCancel.Enabled = !condition;
            btnDelete.Enabled = !condition;
            btnAdd.Enabled = condition;
            btnClose.Enabled = condition;
        }

        private void setLoginPegawaiMethod()
        {
            ilp = Controller.getLoginPegawai();
        }

        private void setDataLoginPegawai()
        {
            dgvLoginPegawai.DataSource = ilp.selectLoginPegawai();
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            id = dgvLoginPegawai[0, e.RowIndex].Value.ToString();
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " +
                        "[" + "Delete Login Pegawai" + "]" + "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            elp = new EntLoginPegawai();

            elp.Nip = id;

            condition = ilp.delete(elp, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataLoginPegawai();
            }
            else
            {
                message = "Data gagal di hapus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Dislpay DGV

        private void setHeaderDgv()
        {
            dgvLoginPegawai.Columns[0].HeaderText = "NIP";
            dgvLoginPegawai.Columns[1].HeaderText = "Nama Pengguna";
            dgvLoginPegawai.Columns[2].HeaderText = "Kata Sandi";

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvLoginPegawai.Columns[0].Width = 170;
            dgvLoginPegawai.Columns[1].Width = 170;
            dgvLoginPegawai.Columns[2].Width = 239;
        }

        #endregion

        #endregion

        #region Event DataGridView

        private void dgvLoginPegawai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvLoginPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setEnableButton(false);
        }

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmKelolaLoginPegawai frm = new FrmKelolaLoginPegawai(receiveIp, receiveNama, setDataLoginPegawai, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin menghapus data ini ?";

            if (MessageBox.Show(message, "Konfirmasi - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
        }

        #endregion

        private void FrmLoginPegawai_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
