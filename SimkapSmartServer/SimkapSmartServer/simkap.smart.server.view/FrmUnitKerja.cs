using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.unit.kerja.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmUnitKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmUnitKerja(string receiveNama, string receiveIp, FrmMenu frmMenu)
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
            setUnitKerjaMethod();
            setDataUnitKerja();
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
            btnDelete.Enabled = !condition;
            btnEdit.Enabled = !condition;
            btnCancel.Enabled = !condition;
            btnAdd.Enabled = condition;
            btnClose.Enabled = condition;
        }

        private void setUnitKerjaMethod()
        {
            iuk = Controller.getUnitKerja();
        }

        private void setDataUnitKerja()
        {
            dgvUnitKerja.DataSource = iuk.selectUnitKerja();
        }


        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendIdUnit = dgvUnitKerja[0, e.RowIndex].Value.ToString();
                sendUnitKerja = dgvUnitKerja[1, e.RowIndex].Value.ToString();
                sendAlamatUnit = dgvUnitKerja[2, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "" +
                  "[" + "Delete Unit Kerja" + "]" + "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Delete

        private void delete()
        {

            euk = new EntUnitKerja();

            euk.Idunit = sendIdUnit;

            condition = iuk.delete(euk, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataUnitKerja();
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
            dgvUnitKerja.Columns[0].Visible = false;
            dgvUnitKerja.Columns[1].HeaderText = "Unit Kerja";
            dgvUnitKerja.Columns[2].HeaderText = "Alamat Unit Kerja";

            setWidthDgv();
        }

        private void setWidthDgv()
        {;
            dgvUnitKerja.Columns[0].Width = 140;
            dgvUnitKerja.Columns[1].Width = 248;
            dgvUnitKerja.Columns[2].Width = 426;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sendProcess = "INSERT";

            FrmKelolaUnitKerja frm = new FrmKelolaUnitKerja(setVisibleNotifikasiEditSucces, receiveIp, receiveNama, sendProcess,
                                                                sendUnitKerja, sendIdUnit, sendAlamatUnit, setDataUnitKerja, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sendProcess = "UPDATE";

            FrmKelolaUnitKerja frm = new FrmKelolaUnitKerja(setVisibleNotifikasiEditSucces, receiveIp, receiveNama, sendProcess,
                                                                sendUnitKerja, sendIdUnit, sendAlamatUnit, setDataUnitKerja, frmMenu, this);
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

            if (MessageBox.Show(message, "Konfirmasi - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        #endregion

        #region Event DataGridView

        private void dgvUnitKerja_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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


        private void dgvUnitKerja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            getDataDgv(e);
            setEnableButton(false);
        }

        #endregion

        private void FrmUnitKerja_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
