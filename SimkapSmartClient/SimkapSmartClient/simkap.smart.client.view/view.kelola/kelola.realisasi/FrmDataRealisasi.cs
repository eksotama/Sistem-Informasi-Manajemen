using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.realisasi
{
    public partial class FrmDataRealisasi : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmDataRealisasi(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm = viewForm;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendJabatan = sendJabatan;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setVisibaleWorksheetDgv(true);
            setEnableButton(true);
        }

        #region Setting

        private void setVisibaleWorksheetDgv(bool condition)
        {
            dgvDataRealisasi.Visible = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnSearchData.Enabled = !condition;
        }

        private void setDataRealisasi()
        {
            ers = new EntRealisasi();

            ers.Jabatan = sendJabatan;
            ers.Periodeawal = dateStart.Value.Date.ToString("yyyy-MM-dd");
            ers.Periodeakhir = dateEnd.Value.Date.ToString("yyyy-MM-dd");

            dgvDataRealisasi.DataSource = irr.selectDataRealisasi(ers);
        }

        private void setValidationButton()
        {
            if (dateEnd.Value == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        #endregion

        #region Set Display Dgv

        private void setDgvHeaderRealisasi()
        {
            dgvDataRealisasi.Columns[0].HeaderText = "Kegiatan";
            dgvDataRealisasi.Columns[1].HeaderText = "Kuantitas";
            dgvDataRealisasi.Columns[2].HeaderText = "Kualitas";
            dgvDataRealisasi.Columns[3].HeaderText = "Waktu";
            dgvDataRealisasi.Columns[4].HeaderText = "Satuan Waktu";
            dgvDataRealisasi.Columns[5].HeaderText = "Biaya";

            WidthDgvRealisasi();
        }

        private void WidthDgvRealisasi()
        {
            dgvDataRealisasi.Columns[0].Width = 658;
            dgvDataRealisasi.Columns[1].Width = 80;
            dgvDataRealisasi.Columns[2].Width = 80;
            dgvDataRealisasi.Columns[3].Width = 80;
            dgvDataRealisasi.Columns[4].Width = 120;
            dgvDataRealisasi.Columns[5].Width = 107;

            dgvDataRealisasi.Columns[0].ReadOnly = true;
            dgvDataRealisasi.Columns[1].ReadOnly = true;
            dgvDataRealisasi.Columns[2].ReadOnly = true;
            dgvDataRealisasi.Columns[3].ReadOnly = true;
            dgvDataRealisasi.Columns[4].ReadOnly = true;

            dgvDataRealisasi.Columns[5].DefaultCellStyle.Format = "N2";

            formatDgv();
        }

        private void formatDgv()
        {
            dgvDataRealisasi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataRealisasi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataRealisasi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataRealisasi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataRealisasi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
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

        #endregion

        #region Validation Button

        private void dateEnd_ValueChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion

        #region Event Button

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            try
            {
                setDataRealisasi();
                setDgvHeaderRealisasi();

                if (dgvDataRealisasi.RowCount > 0)
                {
                    setVisibaleWorksheetDgv(false);

                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    message = "Data tidak ditemukan";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Realisasi";

           FrmMenuKelola frm = new FrmMenuKelola(process, viewForm, sendIpAddress, sendNama, sendJabatan, frmmenuclient);
            viewForm(frm);
        }

        #endregion

    }
}
