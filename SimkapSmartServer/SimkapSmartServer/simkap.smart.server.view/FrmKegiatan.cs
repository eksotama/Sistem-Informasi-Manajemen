using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.kegiatan.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmKegiatan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKegiatan(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setKegiatanMethod();
            setDataKegiatan();
            getHeaderDgv();

            setVisibleNotifikasiEditDefault(true);
            setEnableButton(true);
        }

        #region Setting

        private string logtransactiondelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Delete Kegiatan" + "]" + " " +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

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
            btnDelete.Enabled = !condition;
            btnEdit.Enabled = !condition;
            btnCancel.Enabled = !condition;
            btnAdd.Enabled = condition;
            btnClose.Enabled = condition;
        }

        private void searchKegiatan()
        {
            (dgvKegiatan.DataSource as DataTable).DefaultView.RowFilter = string.Format("jenis LIKE '{0}%'", txtSearch.Text);
        }

        private void setKegiatanMethod()
        {
            ik = Controller.getKegiatan();
        }

        private void setDataKegiatan()
        {
            dgvKegiatan.DataSource = ik.selectKegiatan();
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendIdKegiatan = dgvKegiatan[0, e.RowIndex].Value.ToString();
                sendKegiatan = dgvKegiatan[1, e.RowIndex].Value.ToString();
                sendOutput = dgvKegiatan[3, e.RowIndex].Value.ToString();
                sendSatuan = dgvKegiatan[4, e.RowIndex].Value.ToString();
                sendStatus = dgvKegiatan[5, e.RowIndex].Value.ToString();
                sendKeterangan = dgvKegiatan[6, e.RowIndex].Value.ToString();
                sendJenis = dgvKegiatan[7, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        #endregion

        #region Methode Delete

        private void delete()
        {
            ek = new EntKegiatan();

            ek.Idkegiatan = sendIdKegiatan;

            condition = ik.delete(ek, logtransactiondelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataKegiatan();
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

        private void getHeaderDgv()
        {
            dgvKegiatan.Columns[0].Visible = false;
            dgvKegiatan.Columns[1].HeaderText = "Kegiatan";
            dgvKegiatan.Columns[2].HeaderText = "Jenis Kegiatan";
            dgvKegiatan.Columns[3].HeaderText = "Output";
            dgvKegiatan.Columns[4].HeaderText = "Satuan";
            dgvKegiatan.Columns[5].Visible = false;
            dgvKegiatan.Columns[6].Visible = false;
            dgvKegiatan.Columns[7].Visible = false;

            getWidthDgv();
        }

        private void getWidthDgv()
        {
            dgvKegiatan.Columns[1].Width = 580;
            dgvKegiatan.Columns[2].Width = 200;
            dgvKegiatan.Columns[3].Width = 150;
            dgvKegiatan.Columns[4].Width = 115;

            setFormatDgv();
        }

        private void setFormatDgv()
        {
            dgvKegiatan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvKegiatan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvKegiatan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #endregion

        #region Event Button and TextBox

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchKegiatan();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sendProcess = "INSERT";

            FrmKelolaKegiatan frm = new FrmKelolaKegiatan(setVisibleNotifikasiEditSucces, receiveIp, receiveNama, sendIdKegiatan, 
                                                           sendKegiatan, sendOutput, sendSatuan, sendJenis, sendProcess,
                                                           sendStatus, sendKeterangan, setDataKegiatan, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sendProcess = "DELETE";

            FrmKelolaKegiatan frm = new FrmKelolaKegiatan(setVisibleNotifikasiEditSucces, receiveIp, receiveNama, sendIdKegiatan, 
                                                           sendKegiatan, sendOutput, sendSatuan, sendJenis, sendProcess,
                                                           sendStatus, sendKeterangan, setDataKegiatan, frmMenu, this);
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

        private void dgvKegiatan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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


        private void dgvKegiatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(false);
        }

        #endregion

        private void FrmKegiatan_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
