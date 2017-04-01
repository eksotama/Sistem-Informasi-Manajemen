using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.penilai.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmPejabatPenilai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPejabatPenilai(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setPejabatPenilaiMethod();
            setDataPejabatPenilai();
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

        private void setPejabatPenilaiMethod()
        {
            ipp = Controller.getPejabatPenilai();
        }

        private void setDataPejabatPenilai()
        {
            dgvPejabatPenilai.DataSource = ipp.selectPejabatPenilai();
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " +
                       "[" + "Delete Penilai" + "]" + "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            id = dgvPejabatPenilai[0, e.RowIndex].Value.ToString();
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            epp = new EntPejabatPenilai();

            epp.Idpejabatpenilai = id;

            condition = ipp.delete(epp, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataPejabatPenilai();
            }
            else
            {
                message = "Data gagal di hapus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Display DGV

        private void setHeaderDgv()
        {
            dgvPejabatPenilai.Columns[0].Visible = false;
            dgvPejabatPenilai.Columns[1].HeaderText = "NIP";
            dgvPejabatPenilai.Columns[2].HeaderText = "Nama";

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvPejabatPenilai.Columns[1].Width = 190;
            dgvPejabatPenilai.Columns[2].Width = 280;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmKelolaPenilai frm = new FrmKelolaPenilai(receiveIp, receiveNama, setDataPejabatPenilai, frmMenu, this);
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

        #region Event DataGridView

        private void dgvPejabatPenilai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvPejabatPenilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setEnableButton(false);
        }

        #endregion

        private void FrmPejabatPenilai_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
