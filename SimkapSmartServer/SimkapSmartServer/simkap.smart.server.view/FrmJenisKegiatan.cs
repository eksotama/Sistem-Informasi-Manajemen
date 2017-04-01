using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.jenis.kegiatan.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmJenisKegiatan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmJenisKegiatan(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setJenisKegiatanMethod();
            setDataJenisKegiatan();
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
            btnEdit.Enabled = !condition;
            btnCancel.Enabled = !condition;
            btnAdd.Enabled = condition;
            btnClose.Enabled = condition;
            btnDelete.Enabled = !condition;
        }

        private void setJenisKegiatanMethod()
        {
            ijk = Controller.getJenisKegiatan();
        }

        private void setDataJenisKegiatan()
        {
            dgvJenisKegiatan.DataSource = ijk.selectJenisKegiatan();
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendIdJnsKegiatan = dgvJenisKegiatan[0, e.RowIndex].Value.ToString();
                sendJenis = dgvJenisKegiatan[1, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " +
                     "[" + "Delete Jenis Kegiatan" + "]" + "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }
        
        #endregion

        #region Method Delete

        private void delete()
        {
            ejk = new EntJenisKegiatan();

            ejk.Idjenis = sendIdJnsKegiatan;

            condition = ijk.delete(ejk, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataJenisKegiatan();
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
            dgvJenisKegiatan.Columns[0].Visible = false;
            dgvJenisKegiatan.Columns[1].HeaderText = "Jenis Kegiatan";

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvJenisKegiatan.Columns[1].Width = 564;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sendProcess = "INSERT";

            FrmKelolaJenisKegiatan frm = new FrmKelolaJenisKegiatan(receiveIp, receiveNama, sendIdJnsKegiatan, setVisibleNotifikasiEditSucces,
                                                                      sendProcess, sendJenis, setDataJenisKegiatan, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sendProcess = "UPDATE";

            FrmKelolaJenisKegiatan frm = new FrmKelolaJenisKegiatan(receiveIp, receiveNama, sendIdJnsKegiatan, setVisibleNotifikasiEditSucces,
                                                                       sendProcess, sendJenis ,setDataJenisKegiatan, frmMenu, this);
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

        private void dgvJenisKegiatan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvJenisKegiatan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(false);
        }

        #endregion

        private void FrmJenisKegiatan_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
