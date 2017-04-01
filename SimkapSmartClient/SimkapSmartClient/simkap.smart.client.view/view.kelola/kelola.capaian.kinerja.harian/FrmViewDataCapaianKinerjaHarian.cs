using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.capaian.kinerja.harian;

namespace SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola
{
    public partial class FrmViewDataCapaianKinerjaHarian : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmViewDataCapaianKinerjaHarian(Action<Form> viewForm, string sendjabatan, string sendipaddress, string sendnama, 
                                                FrmMenuClient frmMenuClient, FrmMenuKelola frmmenukelola)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm = viewForm;
            this.sendjabatan = sendjabatan;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.frmMenuClient = frmMenuClient;
            this.frmmenukelola = frmmenukelola;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(true);
            setVisibaleWorksheetDgv(true);
        }

        #region Setting

        private void setVisibaleWorksheetDgv(bool condition)
        {
            btnCancel.Visible = !condition;
            btnEdit.Visible = !condition;
            btnDelete.Visible = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnCancel.Enabled = !condition;
            btnClose.Enabled = condition;
            btnEdit.Enabled = !condition;
            btnDelete.Enabled = !condition;
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

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Delete Capaian Kinerja Harian" + "]" + "" +
                    "" + "   " + sendipaddress + "   " + sendnama + "\n";

            return data;
        }

        private void setDataLCKH()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = sendjabatan;
            elp.Tanggal = dtDate.Value.Date.ToString("yyyy-MM-dd");

            dgvLCKH.DataSource = irl.selectLCKH(elp);
        }

        private void setEnableForm(bool condition)
        {
            this.Enabled = !condition;
            frmMenuClient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
        }

        private void getDataEditDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendvolume = dgvLCKH[2, e.RowIndex].Value.ToString();
                sendiddetaikegiatan = dgvLCKH[5, e.RowIndex].Value.ToString();
                sendidcapaian =  dgvLCKH[6, e.RowIndex].Value.ToString();
                sendstatuskegiatan = dgvLCKH[7, e.RowIndex].Value.ToString();
            }
            catch { }
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateSKPMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateSKPMethod()
        {
            obj = "SimkapSmartServer.ImpCapaianHarian";

            irl = (IntRemoteLCKH)Activator.GetObject(typeof(IntRemoteLCKH), setting.getUrl(obj));
            rwc = (IntRemoteWriteTransactionClient)Activator.GetObject(typeof(IntRemoteWriteTransactionClient), setting.getUrl(obj));
        }

        #endregion

        #region Connected Method Monitoring to Server

        private void ConnectAsClient()
        {
            string s = setData();

            rwc.writeLogTransactionClient(s, setting.getServer(), setting.getPort2());
        }

        private void sendDataToServer()
        {
            mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        #endregion

        #region Display DGV

        private void setHeaderDgvLCKH()
        {
            dgvLCKH.Columns[0].HeaderText = "Kegiatan";
            dgvLCKH.Columns[1].HeaderText = "Output";
            dgvLCKH.Columns[2].HeaderText = "Volume";
            dgvLCKH.Columns[3].HeaderText = "Satuan";
            dgvLCKH.Columns[4].HeaderText = "Keterangan";
            dgvLCKH.Columns[5].Visible = false;
            dgvLCKH.Columns[6].Visible = false;
            dgvLCKH.Columns[7].Visible = false;

            setWidthDgvLCKH();
        }

        private void setWidthDgvLCKH()
        {
            dgvLCKH.Columns[0].Width = 655;
            dgvLCKH.Columns[1].Width = 110;
            dgvLCKH.Columns[2].Width = 80;
            dgvLCKH.Columns[3].Width = 110;
            dgvLCKH.Columns[4].Width = 170;

            formatDgv();
        }

        private void formatDgv()
        {
            dgvLCKH.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvLCKH.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvLCKH.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            elc = new EntLCKH();
            etc = new EntRemoteTransactionClient();

            elc.Idcapaian = Convert.ToInt32(sendidcapaian);
            etc.Text = setData();

            condition = irl.delete(elc, etc);

            if (condition)
            {
                sendDataToServer();

                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataLCKH();
            }
            else
            {
                message = "Data gagal di hapus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Capaian Harian";

            FrmMenuKelola frm = new FrmMenuKelola(process, viewForm, sendipaddress, sendnama, sendjabatan, frmMenuClient);
            viewForm(frm);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmUpdateLCKH frm = new FrmUpdateLCKH(sendstatuskegiatan, sendvolume, sendidcapaian, sendiddetaikegiatan, dtDate.Value.Date.ToString("yyyy-MM-dd"),
                                                    sendjabatan, sendipaddress, sendnama, setDataLCKH,
                                                    setVisibleNotifikasiEditSucces, frmmenukelola, frmMenuClient, this);
            frm.Show();

            setEnableForm(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
            setVisibleNotifikasiEditDefault(true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin mengahpus data ini ?";

            if (MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        #endregion

        #region Event DataGridView

        private void dgvLCKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvLCKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataEditDgv(e);
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(false);
        }

        private void dgvLCKH_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            try
            {
                setDataLCKH();
                setHeaderDgvLCKH();
                setVisibaleWorksheetDgv(false);
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                setVisibaleWorksheetDgv(true);
            }
        }

        #endregion
    }
}
