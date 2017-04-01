using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.realisasi;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.penilaian.realisasi
{
    public partial class FrmViewRealisasi : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmViewRealisasi(string sendIpAddress, string sendNama, string sendPeriodeAwal, string sendPeriodeAkhir, 
                                string sendJabatan, Action<Form> viewForm)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendPeriodeAwal = sendPeriodeAwal;
            this.sendPeriodeAkhir = sendPeriodeAkhir;
            this.sendJabatan = sendJabatan;
            this.viewForm = viewForm;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setVisibaleWorksheetDgv(true);
        }

        #region Setting    

        private void setVisibaleWorksheetDgv(bool condition)
        {
            btnSave.Visible = !condition;
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Realisasi" + "]" + "" +
                    "" + "   " + sendIpAddress + "   " + sendNama + "\n";

            return data;
        }

        private void setDataCount()
        {
            ers = new EntRealisasi();

            ers.Jabatan = sendJabatan;
            ers.Periodeawal = sendPeriodeAwal;
            ers.Periodeakhir = sendPeriodeAkhir;

            dgvWorkSheetRealisasi.DataSource = irr.selectRealisasi(ers);
        }

        #endregion

        #region Set Display Dgv

        private void setDgvHeaderRealisasi()
        {
            dgvWorkSheetRealisasi.Columns[0].HeaderText = "Kegiatan";
            dgvWorkSheetRealisasi.Columns[1].HeaderText = "Kuantitas";
            dgvWorkSheetRealisasi.Columns[2].HeaderText = "Kualitas";
            dgvWorkSheetRealisasi.Columns[3].HeaderText = "Waktu";
            dgvWorkSheetRealisasi.Columns[4].HeaderText = "Satuan Waktu";
            dgvWorkSheetRealisasi.Columns[5].HeaderText = "Biaya";
            dgvWorkSheetRealisasi.Columns[6].Visible = false;

            WidthDgvRealisasi();
        }

        private void WidthDgvRealisasi()
        {
            dgvWorkSheetRealisasi.Columns[0].Width = 656;
            dgvWorkSheetRealisasi.Columns[1].Width = 80;
            dgvWorkSheetRealisasi.Columns[2].Width = 80;
            dgvWorkSheetRealisasi.Columns[3].Width = 80;
            dgvWorkSheetRealisasi.Columns[4].Width = 120;
            dgvWorkSheetRealisasi.Columns[5].Width = 107;

            dgvWorkSheetRealisasi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorkSheetRealisasi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorkSheetRealisasi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorkSheetRealisasi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorkSheetRealisasi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            dgvWorkSheetRealisasi.Columns[0].ReadOnly = true;
            dgvWorkSheetRealisasi.Columns[1].ReadOnly = true;
            dgvWorkSheetRealisasi.Columns[2].ReadOnly = true;
            dgvWorkSheetRealisasi.Columns[3].ReadOnly = true;
            dgvWorkSheetRealisasi.Columns[4].ReadOnly = true;

            dgvWorkSheetRealisasi.Columns[5].DefaultCellStyle.Format = "N2";
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateRealisasiMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateRealisasiMethod()
        {
            obj = "SimkapSmartServer.ImpRealisasi";

            irr = (IntRemoteRealisasi)Activator.GetObject(typeof(IntRemoteRealisasi), setting.getUrl(obj));
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

        #region Method Insert Realisasi

        private void save()
        {
            etc = new EntRemoteTransactionClient();
            ers = new EntRealisasi();

            foreach (DataGridViewRow row in dgvWorkSheetRealisasi.Rows)
            {
                ers.Iddetailkegiatan = row.Cells["iddetailkegiatan"].Value.ToString();
                ers.Kuantitas = Convert.ToInt32(row.Cells["kuantitas"].Value.ToString());
                ers.Kualitas = Convert.ToInt32(row.Cells["kualitas"].Value.ToString());
                ers.Jumlahwaktu = Convert.ToInt32(row.Cells["waktu"].Value.ToString());
                ers.Satuanwaktu = row.Cells["satuanwaktu"].Value.ToString();
                ers.Biaya = Convert.ToDouble(row.Cells["biaya"].Value.ToString());
                ers.Periodeawal = sendPeriodeAwal;
                ers.Periodeakhir = sendPeriodeAkhir;

                etc.Text = setData();

                condition = irr.save(ers, etc);
            }

            if (condition)
            {
                sendDataToServer();

                FrmDataRealisasi frm = new FrmDataRealisasi(viewForm, sendIpAddress, sendNama, sendJabatan);
                viewForm(frm);
            }
            else
            {
                message = "Data gagal disimpan";
                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Event DataGridView

        private void dgvWorkSheetRealisasi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvWorkSheetRealisasi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorkSheetRealisasi.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    message = "Inputan hanya bisa angka";
                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    message = "Inputkan data sesuai format yang sudah ditentukan";
                    MessageBox.Show(message, "Pesan Kesalahan  - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Realisasi";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendJabatan, sendIpAddress, sendNama, process);
            viewForm(frm);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;
                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                setDataCount();
                setDgvHeaderRealisasi();

                if (dgvWorkSheetRealisasi.RowCount > 0)
                {
                    setVisibaleWorksheetDgv(false);

                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    message = "Anda belum membuat laporan capaian kinerja harian atau kegiatan sudah dihitung realisasinya";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    setVisibaleWorksheetDgv(true);
                }
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada sistem : " + ex.Message;
                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
