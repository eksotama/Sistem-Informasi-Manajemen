using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.kegiatan.pegawai.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmKegiatanPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKegiatanPegawai(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setDetailKegiatanMethod();
            setDataDetailKegiatanPegawai();
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

        private void searchDetailKegiatan()
        {
            (dgvKegiatanPegawai.DataSource as DataTable).DefaultView.RowFilter = string.Format("nama LIKE '{0}%'", txtSearch.Text);
        }

        private void setDetailKegiatanMethod()
        {
            idk = Controller.getDetailKegiatan();
        }

        private void setDataDetailKegiatanPegawai()
        {
            dgvKegiatanPegawai.DataSource = idk.selectDetailKegiatan();
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Delete Detail Kegiatan" + "]" +
                    "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
           id = dgvKegiatanPegawai[0, e.RowIndex].Value.ToString();
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            edk = new EntDetailKegiatan();

            edk.Iddetailkegiatan = id;

            condition = idk.delete(edk, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataDetailKegiatanPegawai();
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
            dgvKegiatanPegawai.Columns[0].Visible = false;
            dgvKegiatanPegawai.Columns[1].Visible = false;
            dgvKegiatanPegawai.Columns[2].HeaderText = "Nama Pegawai";
            dgvKegiatanPegawai.Columns[3].HeaderText = "Kegiatan Pegawai";

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvKegiatanPegawai.Columns[2].Width = 190;
            dgvKegiatanPegawai.Columns[3].Width = 678;
        }

        #endregion

        #endregion

        #region Event Button and TextBox

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchDetailKegiatan();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmKelolaKegiatanPegawai frm = new FrmKelolaKegiatanPegawai(receiveIp, receiveNama, setDataDetailKegiatanPegawai, 
                                                                            frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin menghapus data ini ?";

            if (MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        #endregion

        #region Event DataGridView

        private void dgvKegiatanPegawai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvKegiatanPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setEnableButton(false);
        }

        #endregion

        private void FrmKegiatanPegawai_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
