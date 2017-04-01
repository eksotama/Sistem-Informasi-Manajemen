using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client; 

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran
{
    public partial class FrmDataUkurSasaran : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmDataUkurSasaran(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan)
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
            setVisibleWorkSheet(true);
        }

        #region Setting

        private void setVisibleWorkSheet(bool condition)
        {
            dgvDataUkurSasaran.Visible = !condition;
        }

        private void setEnableSearchData(bool condition)
        {
            btnSearchData.Enabled = !condition;
        }

        private void setDataUkurSasaran()
        {
            euk = new EntUkurSasaran();

            euk.Jabatan = sendJabatan;
            euk.Periodeawal = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
            euk.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");

            dgvDataUkurSasaran.DataSource = iuk.selectDataUkurSasaran(euk);
        }

        private void setValidationButton()
        {
            if (dtPeriodeAkhir.Value == null)
            {
                setEnableSearchData(true);
            }
            else
            {
                setEnableSearchData(false);
            }
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateUkurSasaranMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateUkurSasaranMethod()
        {
            obj = "SimkapSmartServer.ImpUkurSasaran";

            iuk = (IntRemoteUkurSasaran)Activator.GetObject(typeof(IntRemoteUkurSasaran), setting.getUrl(obj));
        }

        #endregion

        #region Display Dgv

        private void setHeaderDgv()
        {
            dgvDataUkurSasaran.Columns[0].HeaderText = "Kegiatan";
            dgvDataUkurSasaran.Columns[1].HeaderText = "T.Kuantitas";
            dgvDataUkurSasaran.Columns[2].HeaderText = "T.Kualitas";
            dgvDataUkurSasaran.Columns[3].HeaderText = "T.Waktu";
            dgvDataUkurSasaran.Columns[4].HeaderText = "T.Satuan Waktu";
            dgvDataUkurSasaran.Columns[5].HeaderText = "T.Biaya";
            dgvDataUkurSasaran.Columns[6].HeaderText = "R.Kuantitas";
            dgvDataUkurSasaran.Columns[7].HeaderText = "R.Kualitas";
            dgvDataUkurSasaran.Columns[8].HeaderText = "R.Waktu";
            dgvDataUkurSasaran.Columns[9].HeaderText = "R.Satuan Waktu";
            dgvDataUkurSasaran.Columns[10].HeaderText = "R.Biaya";
            dgvDataUkurSasaran.Columns[11].HeaderText = "Perhitungan";
            dgvDataUkurSasaran.Columns[12].HeaderText = "Capaian";

            dgvDataUkurSasaran.Columns[0].ReadOnly = true;
            dgvDataUkurSasaran.Columns[1].ReadOnly = true;
            dgvDataUkurSasaran.Columns[2].ReadOnly = true;
            dgvDataUkurSasaran.Columns[3].ReadOnly = true;
            dgvDataUkurSasaran.Columns[4].ReadOnly = true;
            dgvDataUkurSasaran.Columns[5].ReadOnly = true;
            dgvDataUkurSasaran.Columns[6].ReadOnly = true;
            dgvDataUkurSasaran.Columns[7].ReadOnly = true;
            dgvDataUkurSasaran.Columns[8].ReadOnly = true;
            dgvDataUkurSasaran.Columns[9].ReadOnly = true;
            dgvDataUkurSasaran.Columns[10].ReadOnly = true;
            dgvDataUkurSasaran.Columns[11].ReadOnly = true;
            dgvDataUkurSasaran.Columns[12].ReadOnly = true;
            dgvDataUkurSasaran.Columns[11].HeaderText = "Perhitungan";
            dgvDataUkurSasaran.Columns[12].HeaderText = "Capaian";

            setWidthDgv();
        }

        private void setWidthDgv()
        {
            dgvDataUkurSasaran.Columns[0].Width = 570;
            dgvDataUkurSasaran.Columns[1].Width = 80;
            dgvDataUkurSasaran.Columns[2].Width = 80;
            dgvDataUkurSasaran.Columns[3].Width = 80;
            dgvDataUkurSasaran.Columns[4].Width = 107;
            dgvDataUkurSasaran.Columns[5].Width = 120;
            dgvDataUkurSasaran.Columns[6].Width = 80;
            dgvDataUkurSasaran.Columns[7].Width = 80;
            dgvDataUkurSasaran.Columns[8].Width = 80;
            dgvDataUkurSasaran.Columns[9].Width = 107;
            dgvDataUkurSasaran.Columns[10].Width = 120;
            dgvDataUkurSasaran.Columns[11].Width = 110;
            dgvDataUkurSasaran.Columns[12].Width = 110;

            dgvDataUkurSasaran.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvDataUkurSasaran.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvDataUkurSasaran.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataUkurSasaran.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvDataUkurSasaran.Columns[5].DefaultCellStyle.Format = "N2";
            dgvDataUkurSasaran.Columns[10].DefaultCellStyle.Format = "N2";
            dgvDataUkurSasaran.Columns[11].DefaultCellStyle.Format = "N2";
            dgvDataUkurSasaran.Columns[12].DefaultCellStyle.Format = "N2";
        }

        #endregion

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Ukur Sasaran";

            FrmMenuKelola frm = new FrmMenuKelola(process, viewForm, sendIpAddress, sendNama, sendJabatan, frmmenuclient);
            viewForm(frm);
        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            try
            {
                setDataUkurSasaran();
                setHeaderDgv();

                if (dgvDataUkurSasaran.RowCount > 0)
                {
                    setVisibleWorkSheet(false);

                    this.WindowState = FormWindowState.Maximized;
                }
                else
                {
                    message = "Data tidak ditemukan";

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    setVisibleWorkSheet(true);
                }

            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                setVisibleWorkSheet(true);
            }
        }

        private void datePeriode_ValueChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion
    }
}
