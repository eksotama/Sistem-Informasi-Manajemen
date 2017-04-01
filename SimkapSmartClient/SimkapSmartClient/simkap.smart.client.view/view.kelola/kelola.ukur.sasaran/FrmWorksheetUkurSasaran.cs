using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran
{
    public partial class FrmWorksheetUkurSasaran : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmWorksheetUkurSasaran(string sendIpAddress, string sendNama, string sendPeriodeAwal, string sendPeriodeAkhir,
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
            setVisibleWorkSheet(true);
            setEnableButtonSave(true);
        }

        #region Setting

        private void setEnableButtonSave(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setDataUkurSasaran()
        {
            euk = new EntUkurSasaran();

            euk.Jabatan = sendJabatan;
            euk.Periodeawal = sendPeriodeAwal;
            euk.Periodeakhir = sendPeriodeAkhir;

            dgvDataUkurSasaran.DataSource = iuk.selectUkurSasaran(euk);
        }

        private void setVisibleWorkSheet(bool condition)
        {
            btnSave.Visible = !condition;
            btnCount.Visible = !condition;
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Ukur Sasaran Kerja" + "]" + "" +
                    "" + "   " + sendIpAddress + "   " + sendNama + "\n";

            return data;
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
            dgvDataUkurSasaran.Columns[13].Visible = false;
            dgvDataUkurSasaran.Columns[14].Visible = false;

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

        #region Get Nilai Ukur Sasaran

        private void count()
        {
            foreach (DataGridViewRow row in dgvDataUkurSasaran.Rows)
            {
                #region Kuantitas

                rKuantitas = Convert.ToDouble(row.Cells["RealisasiKuantitas"].Value.ToString());
                tKuantitas = Convert.ToDouble(row.Cells["TargetKuantitas"].Value.ToString());

                hKuantitas = (rKuantitas / tKuantitas) * 100;

                #endregion

                #region Kualitas

                rKualitas = Convert.ToDouble(row.Cells["RealisasiKualitas"].Value.ToString());
                tKualitas = Convert.ToDouble(row.Cells["TargetKualitas"].Value.ToString());

                hKualitas = (rKualitas / tKualitas) * 100;

                #endregion

                #region Waktu

                rWaktu = Convert.ToDouble(row.Cells["RealisasiWaktu"].Value.ToString());
                tWaktu = Convert.ToDouble(row.Cells["TargetWaktu"].Value.ToString());

                eWaktu = 100 - (rWaktu / tWaktu * 100);

                if (rKuantitas == 0)
                {
                    hwaktu = (1.76 * (tWaktu - 0) * 0 * 100) / tWaktu;
                }
                else
                {
                    if (eWaktu <= 24)
                    {
                        hwaktu = ((1.76 * tWaktu - rWaktu) / tWaktu) * 100;
                    }
                    else
                    {
                        hwaktu = 76 - ((((1.76 * tWaktu - rWaktu) / tWaktu) * 100) -100);
                    }
                }

                #endregion

                #region Biaya

                rbiaya = Convert.ToDouble(row.Cells["RealisasiBiaya"].Value.ToString());
                tbiaya = Convert.ToDouble(row.Cells["TargetBiaya"].Value.ToString());

                ebiaya = 100 - ((rbiaya / tbiaya) * 100);

                if (rKuantitas == 0)
                {
                    hbiaya = (1.76 * (tbiaya - 0) * 0 * 100) / tbiaya;
                }
                else
                {
                    if (ebiaya <= 24)
                    {
                        hbiaya = ((1.76 * tbiaya - rbiaya) / tbiaya) * 100;
                    }
                    else
                    {
                        hbiaya = 76 - ((((1.76 * tbiaya - rbiaya) / tbiaya) * 100) - 100);
                    }
                }

                #endregion

                if (hbiaya > 0)
                {
                    nilaiperhitungan = (hKuantitas + hKualitas + hwaktu + hbiaya) / 4;
                    nilaicapaian = nilaiperhitungan / 4;
                }
                else
                {
                    nilaiperhitungan = (hKuantitas + hKualitas + hwaktu) / 3;
                    nilaicapaian = nilaiperhitungan / 3;
                }

                row.Cells["perhitungan"].Value = nilaiperhitungan;
                row.Cells["capaian"].Value = nilaicapaian;
            }
        }

        #endregion

        #region Method Insert

        private void save()
        {
            euk = new EntUkurSasaran();
            etc = new EntRemoteTransactionClient();

            foreach (DataGridViewRow row in dgvDataUkurSasaran.Rows)
            {
                euk.Idsasaran = Convert.ToInt32(row.Cells["idsasarankerja"].Value.ToString());
                euk.Idrealisasi = Convert.ToInt32(row.Cells["idrealisasi"].Value.ToString());
                euk.Perhitungan = Convert.ToDouble(row.Cells["perhitungan"].Value.ToString());
                euk.Capaian = Convert.ToDouble(row.Cells["capaian"].Value.ToString());

                etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Ukur Sasaran Kerja" + "]" + "" +
                            "" + "   " + sendIpAddress + "   " + sendNama;

                condition = iuk.save(euk, etc);
            }

            if (condition)
            {
                sendDataToServer();

                FrmDataUkurSasaran frm = new FrmDataUkurSasaran(viewForm, sendIpAddress, sendNama, sendJabatan);
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

        private void dgvDataUkurSasaran_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            #region Auto Number

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

        #region Event Button

        private void btnView_Click(object sender, EventArgs e)
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
                    message = "Data tidak ditemukan atau kegiatan sudah di ukur";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;
                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                count();
                setEnableButtonSave(false);
            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Ukur Sasaran";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, sendJabatan, sendIpAddress, sendNama, process);
            viewForm(frm);
        }

        #endregion
    }
}
