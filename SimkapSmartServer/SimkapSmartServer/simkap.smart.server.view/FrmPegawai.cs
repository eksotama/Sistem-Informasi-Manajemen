using System;
using System.Drawing;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.view.pegawai.crud;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPegawai(string receiveNama, string receiveIp, FrmMenu frmMenu)
        {
            InitializeComponent();
            InitializeFunction();

            this.receiveNama = receiveNama;
            this.receiveIp = receiveIp;
            this.frmMenu = frmMenu;;
        }

        #region All Function

        private void InitializeFunction()
        {
            setPegawaiMethod();
            setDataPegawai();
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
            btnDelete.Enabled = !condition;
            btnAdd.Enabled = condition;
            btnClose.Enabled = condition;
        }

        private void setPegawaiMethod()
        {
            ipg = Controller.getPegawai();
            iuk = Controller.getUnitKerja();
        }

        private void setDataPegawai()
        {
            dgvPegawai.DataSource = ipg.selectPegawai();
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendNip = dgvPegawai[0, e.RowIndex].Value.ToString();
                sendNama = dgvPegawai[1, e.RowIndex].Value.ToString();
                sendPagolru = dgvPegawai[2, e.RowIndex].Value.ToString();
                sendJabatan = dgvPegawai[3, e.RowIndex].Value.ToString();
                sendUnitKerja = dgvPegawai[6, e.RowIndex].Value.ToString();
                sendKeterangan = dgvPegawai[5, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        private string logTransactionDelete()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Delete Pegawai" + "]" +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            epg = new EntPegawai();

            epg.Nip = sendNip;

            condition = ipg.delete(epg, logTransactionDelete());

            if (condition)
            {
                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataPegawai();
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
            dgvPegawai.Columns[0].HeaderText = "NIP";
            dgvPegawai.Columns[1].HeaderText = "Nama";
            dgvPegawai.Columns[2].HeaderText = "Pangkat/Gol.Ruang";
            dgvPegawai.Columns[3].HeaderText = "Jabatan";
            dgvPegawai.Columns[4].HeaderText = "Unit Kerja";
            dgvPegawai.Columns[5].Visible = false;
            dgvPegawai.Columns[6].Visible = false;

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvPegawai.Columns[0].Width = 160;
            dgvPegawai.Columns[1].Width = 210;
            dgvPegawai.Columns[2].Width = 150;
            dgvPegawai.Columns[3].Width = 350;
            dgvPegawai.Columns[4].Width = 220;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sendProcess = "INSERT";

            FrmKelolaPegawai frm = new FrmKelolaPegawai(sendProcess, receiveIp, receiveNama, sendNip, sendNama, sendPagolru, sendUnitKerja,
                                                           sendJabatan, sendKeterangan,setVisibleNotifikasiEditSucces, setDataPegawai, frmMenu, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            sendProcess = "UPDATE";

            FrmKelolaPegawai frm = new FrmKelolaPegawai(sendProcess, receiveIp, receiveNama, sendNip, sendNama, sendPagolru, sendUnitKerja,
                                                           sendJabatan, sendKeterangan , setVisibleNotifikasiEditSucces, setDataPegawai, frmMenu, this);
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

        private void dgvPegawai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(false);
        }

        private void dgvPegawai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        #endregion

        private void FrmPegawai_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
