using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.atasan.penilai.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmAtasanPenilai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmAtasanPenilai(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setAtasanPejabatPenilaiMethod();
            setDataAtasanPejabatPenilai();
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

        private void setAtasanPejabatPenilaiMethod()
        {
            iap = Controller.getAtasanPejabatPenilai();
        }

        private void setDataAtasanPejabatPenilai()
        {
            dgvAtasanPenilai.DataSource = iap.selectAtasanPejabatPenilai();
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " +
            "[" + "Delete Atasan Penilai" + "]" + "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                Id = dgvAtasanPenilai[2, e.RowIndex].Value.ToString();
                setEnableButton(false);
            }
            catch { }
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            try
            {
                eap = new EntAtasanPejabatPenilai();

                eap.Idatasanpenilai = Id;

                condition = iap.delete(eap, logTransactionDelete());

                if (condition)
                {
                    message = "Data berhasil di hapus";

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    setDataAtasanPejabatPenilai();
                }
                else
                {
                    message = "Data gagal di hapus";

                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                setEnableButton(true);
            }
            catch
            {
                message = "tidak ada data yang dipilih";

                MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion

        #region Display DGV

        private void setHeaderDgv()
        {
            dgvAtasanPenilai.Columns[0].HeaderText = "NIP";
            dgvAtasanPenilai.Columns[1].HeaderText = "Nama";
            dgvAtasanPenilai.Columns[2].Visible = false;

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvAtasanPenilai.Columns[0].Width = 180;
            dgvAtasanPenilai.Columns[1].Width = 290;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmKelolaAtasanPenilai frm = new FrmKelolaAtasanPenilai(receiveIp, receiveNama, setDataAtasanPejabatPenilai,
                                                                        frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin menghapus data ini ?";

            if (MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Event DataGridView

        private void dgvAtasanPenilai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvAtasanPenilai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
        }

        #endregion

        private void FrmAtasanPenilai_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
