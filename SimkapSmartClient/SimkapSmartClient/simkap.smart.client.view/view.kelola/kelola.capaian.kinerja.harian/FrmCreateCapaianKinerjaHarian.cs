using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola
{
    public partial class FrmCreateCapaianKinerjaHarian : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCreateCapaianKinerjaHarian(string sendipaddress, string sendnama, string sendperiodeawal, string sendperiodeakhir, string sendjabatan, 
                                                Action<Form> viewForm)
        {
            InitializeComponent();
            InitializeFunction();

            receiveipaddress = sendipaddress;
            receivenama = sendnama;
            receiveperiodeawal = sendperiodeawal;
            receivejabatan = sendjabatan;
            receiveperiodeakhir = sendperiodeakhir;
            this.viewForm = viewForm;
        }
        
        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setHeaderDgv();
            setCmbWorkSheet();
            setVisibleWorkSheet(true);
            setVisibleButtonDgv(true);
            setEnableButtonWorkSheet(true);
            setEnableButtonSave(true);

            cmbJenisKegiatan.SelectedValue = null;
            cmbWorkSheet.SelectedItem = "";
        }

        #region Message

        private void setMessageSync()
        {
            message = "Tidak ada data yang disinkronkan";
            MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void setMessageCancel()
        {
            message = "hapus data target kegiatan terlebih dahulu";
            MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void setMessageInputFalse()
        {
            message = "Inputkan data sesuai format yang sudah ditentukan";
            MessageBox.Show(message, "Pesan Kesalahan  - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void setMessageInputTrue()
        {
            message = "Inputan hanya bisa angka";
            MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void setMessageInsert()
        {
            message = "Data gagal disimpan";
            MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region Notifikasi

        private void setNotifikasiSync()
        {
            if (procces.Equals("SURAT KELUAR", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncSuratKeluar.Rows.Count > 1)
                {
                    message = "Data Surat Keluar berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("NIKAH", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncPernikahan.Rows.Count > 1)
                {
                    message = "Data Nikah berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("MODEL NA", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncPernikahan.Rows.Count > 1)
                {
                    message = "Data Pernikahan Model NA berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("REKOMENDASI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncRekomendasi.Rows.Count > 1)
                {
                    message = "Data Rekomendasi berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("DUPLIKAT", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncDuplikat.Rows.Count > 1)
                {
                    message = "Data Duplikat berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("MASUK ISLAM", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncMasukIslam.Rows.Count > 1)
                {
                    message = "Data Masuk Islam berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("TALAK", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncTalak.Rows.Count > 1)
                {
                    message = "Data Talak berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("CERAI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncCerai.Rows.Count > 1)
                {
                    message = "Data Cerai berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("WAKAF", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncWakaf.Rows.Count > 1)
                {
                    message = "Data Wakaf berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi  - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }

            if (procces.Equals("HAJI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvSyncHaji.Rows.Count > 1)
                {
                    message = "Data Haji berhasil disinkronkan";
                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    setMessageSync();
                }
            }
        }

        #endregion

        #region Validation Button

        private void setValdiationCancel()
        {
            #region Surat Keluar

            if (procces.Equals("SURAT KELUAR", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetSuratKeluar.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbSuratKeluar.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Nikah

            else if (procces.Equals("NIKAH", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetNikah.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbNikah.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Model NA

            else if (procces.Equals("MODEL NA", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetModelNA.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbModelNA.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Rekomendasi

            else if (procces.Equals("REKOMENDASI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetRekomendasi.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbRekomendasi.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Duplikat

            else if (procces.Equals("DUPLIKAT", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetDuplikat.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbDuplikat.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Masuk Islam

            else if (procces.Equals("MASUK ISLAM", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetMasukIslam.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbMasukIslam.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Talak

            else if (procces.Equals("TALAK", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetTalak.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbTalak.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Cerai

            else if (procces.Equals("CERAI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetCerai.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbCerai.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Haji

            else if (procces.Equals("HAJI", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetHaji.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbHaji.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Keuanagan

            else if (procces.Equals("KEUANGAN", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetKeuangan.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbKeuangan.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Wakaf

            else if (procces.Equals("WAKAF", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetWakaf.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbWakaf.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion

            #region Others

            else if (procces.Equals("OTHERS", StringComparison.InvariantCultureIgnoreCase))
            {
                if (dgvWorksheetOthers.Rows.Count > 1)
                {
                    setMessageCancel();
                }
                else
                {
                    tbOthers.Visible = false;
                    setEnableButtonAndCmbWorkSheet(false);
                    setVisibleButtonDgv(true);
                }
            }

            #endregion
        }


        #endregion

        #region Setting

        private void refershForm()
        {
            FrmCreateCapaianKinerjaHarian frm = new FrmCreateCapaianKinerjaHarian(receiveipaddress, receivenama,
                                           receiveperiodeawal, receiveperiodeakhir, receivejabatan, viewForm);
            viewForm(frm);
        }

        private void setEnableButtonSave(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setEnableCmbJenisKegiatan(bool condition)
        {
            cmbJenisKegiatan.Enabled = !condition;
        }

        private void setVisibleWorkSheet(bool condition)
        {
            tbCerai.Visible = !condition;
            tbNikah.Visible = !condition;
            tbDuplikat.Visible = !condition;
            tbHaji.Visible = !condition;
            tbKeuangan.Visible = !condition;
            tbMasukIslam.Visible = !condition;
            tbModelNA.Visible = !condition;
            tbRekomendasi.Visible = !condition;
            tbTalak.Visible = !condition;
            tbWakaf.Visible = !condition;
            tbCerai.Visible = !condition;
            tbOthers.Visible = !condition;
            tbSuratKeluar.Visible = !condition;
            tbSelectWorkSheet.Visible = condition;
        }

        private void setVisibleButtonDgv(bool condition)
        {
            btnSync.Visible = !condition;
            btnSave.Visible = !condition;
            btnCancel.Visible = !condition;
            btnDelete.Visible = !condition;
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                    "" + "   " + receiveipaddress + "   " + receivenama + "\n";

            return data;
        }

        private void setCmbJenisKegiatan()
        {
            cmbJenisKegiatan.DataSource = irl.selectJenisKegiatan();
            cmbJenisKegiatan.DisplayMember = "jenis";
            cmbJenisKegiatan.ValueMember = "idjenis";
        }

        private void setValidasiButton()
        {
            if (cmbJenisKegiatan.SelectedValue == null || cmbWorkSheet.SelectedItem == null)
            {
                setEnableButtonWorkSheet(true);
            }
            else
            {
                setEnableButtonWorkSheet(false);
            }
        }

        private void setEnableButtonWorkSheet(bool condition)
        {
            btnViewWorkSheet.Enabled = !condition;
        }

        private void setEnableButtonAndCmbWorkSheet(bool condition)
        {
            btnViewWorkSheet.Enabled = !condition;
            cmbJenisKegiatan.Enabled = !condition;
            cmbWorkSheet.Enabled = !condition;
        }

        private void setCmbWorkSheet()
        {
            cmbWorkSheet.Items.Add("Sinkron Model NA.[Pernikahan]");
            cmbWorkSheet.Items.Add("Sinkron Pernikahan");
            cmbWorkSheet.Items.Add("Sinkron Wakaf");
            cmbWorkSheet.Items.Add("Sinkron Rekomendasi Nikah");
            cmbWorkSheet.Items.Add("Sinkron Duplikat Nikah");
            cmbWorkSheet.Items.Add("Sinkron Masuk Islam");
            cmbWorkSheet.Items.Add("Sinkron Talak");
            cmbWorkSheet.Items.Add("Sinkron Cerai");
            cmbWorkSheet.Items.Add("Sinkron Haji");
            cmbWorkSheet.Items.Add("Sinkron Surat Keluar");
            cmbWorkSheet.Items.Add("Keuangan");
            cmbWorkSheet.Items.Add("Lainnya");
        }

        private void setVisibleSelectWorksheet(bool condition)
        {
            tbSelectWorkSheet.Visible = !condition;
        }

        private void viewWorkSheet()
        {
            if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Pernikahan" && txtIdJenisKegiatan.Text == "JK0001")
            {
                tbNikah.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Model NA.[Pernikahan]" && txtIdJenisKegiatan.Text == "JK0001")
            {
                tbModelNA.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Wakaf" && txtIdJenisKegiatan.Text == "JK0004")
            {
                tbWakaf.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Rekomendasi Nikah" && txtIdJenisKegiatan.Text == "JK0007")
            {
                tbRekomendasi.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Duplikat Nikah" && txtIdJenisKegiatan.Text == "JK0006")
            {
                tbDuplikat.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Masuk Islam" && txtIdJenisKegiatan.Text == "JK0005")
            {
                tbMasukIslam.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Talak" && txtIdJenisKegiatan.Text == "JK0008")
            {
                tbTalak.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Cerai" && txtIdJenisKegiatan.Text == "JK0008")
            {
                tbCerai.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Haji" && txtIdJenisKegiatan.Text == "JK0003")
            {
                tbHaji.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Keuangan" && txtIdJenisKegiatan.Text == "JK0002")
            {
                tbKeuangan.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Sinkron Surat Keluar" && txtIdJenisKegiatan.Text == "JK0009")
            {
                tbSuratKeluar.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else if (cmbWorkSheet.SelectedItem.ToString() == "Lainnya")
            {
                tbOthers.Visible = true;
                setVisibleSelectWorksheet(true);
                setEnableButtonAndCmbWorkSheet(true);
            }
            else
            {
                message = "Lembar Kerja dan Jenis Pelayanan yang di pilih tidak sesuai";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setDataLCKH()
        {
            elp = new EntLoginPegawai();

            elp.Idjenis = txtIdJenisKegiatan.Text;
            elp.Tanggal = dtDate.Value.Date.ToString("yyyy-MM-dd");

            dgvSyncPernikahan.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncWakaf.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncDuplikat.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncRekomendasi.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncMasukIslam.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncTalak.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncCerai.DataSource = irl.selectDgvSyncII(elp);
            dgvSyncHaji.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncSuratKeluar.DataSource = irl.selectDgvSyncI(elp);
            dgvSyncModelNA.DataSource = irl.selectDgvSyncII(elp);
        }

        #endregion

        #region Set ComboBox Dgv

        private void getEntity()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = receivejabatan;
            elp.Idjenis = txtIdJenisKegiatan.Text;
            elp.Periodeawal = receiveperiodeawal;
            elp.Periodeakhir = receiveperiodeakhir;
            elp.Tanggal = dtDate.Value.Date.ToString("yyyy-MM-dd");
            elp.Statuskegiatan = statuskegiatan;
            elp.Keterangan = keterangan;
        }

        private void getValueCmb()
        {
            cmbKegiatanSuratKeluar.DisplayMember = "kegiatan";
            cmbKegiatanSuratKeluar.ValueMember = "iddetailkegiatan";

            cmbKegiatanHaji.DisplayMember = "kegiatan";
            cmbKegiatanHaji.ValueMember = "iddetailkegiatan";

            cmbKegiatanTalak.DisplayMember = "kegiatan";
            cmbKegiatanTalak.ValueMember = "iddetailkegiatan";

            cmbKegiatanCerai.DisplayMember = "kegiatan";
            cmbKegiatanCerai.ValueMember = "iddetailkegiatan";

            cmbKegiatanWakaf.DisplayMember = "kegiatan";
            cmbKegiatanWakaf.ValueMember = "iddetailkegiatan";

            cmbKegiatanNikah.DisplayMember = "kegiatan";
            cmbKegiatanNikah.ValueMember = "iddetailkegiatan";

            cmbKegiatanModelNA.DisplayMember = "kegiatan";
            cmbKegiatanModelNA.ValueMember = "iddetailkegiatan";

            cmbKegiatanKeuangan.DisplayMember = "kegiatan";
            cmbKegiatanKeuangan.ValueMember = "iddetailkegiatan";

            cmbKegiatanDuplikat.DisplayMember = "kegiatan";
            cmbKegiatanDuplikat.ValueMember = "iddetailkegiatan";

            cmbKegiatanMasukIslam.DisplayMember = "kegiatan";
            cmbKegiatanMasukIslam.ValueMember = "iddetailkegiatan";

            cmbKegiatanRekomendasi.DisplayMember = "kegiatan";
            cmbKegiatanRekomendasi.ValueMember = "iddetailkegiatan";
        }

        private void setCmbKegiatan()
        {
            getEntity();

            cmbKegiatanHaji.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanNikah.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanWakaf.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanTalak.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanCerai.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanModelNA.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanKeuangan.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanDuplikat.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanMasukIslam.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanRekomendasi.DataSource = irl.selectKegiatan(elp);
            cmbKegiatanSuratKeluar.DataSource = irl.selectKegiatan(elp);

            getValueCmb();
        }

        private void setCmbKegiatanOthers()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = receivejabatan;
            elp.Periodeawal = receiveperiodeawal;
            elp.Periodeakhir = receiveperiodeakhir;
            elp.Tanggal = dtDate.Value.Date.ToString("yyyy-MM-dd");
            elp.Statuskegiatan = statuskegiatan;
            elp.Keterangan = keterangan;

            cmbKegiatanLainnya.DataSource = irl.selectKegiatanOthers(elp);
            cmbKegiatanLainnya.DisplayMember = "kegiatan";
            cmbKegiatanLainnya.ValueMember = "iddetailkegiatan";
        }


        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateLCKHMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateLCKHMethod()
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

        #region Dislpay DGV

        private void setHeaderDgv()
        {
            headerNikah();
            headerModelNA();
            headerWakaf();
            headerHaji();
            headerCerai();
            headerTalak();
            headerKeuangan();
            headerRekomendasi();
            headerDuplikat();
            headerOthers();
            headerMasukIslam();
            headerSuratKeluar();
        }

        #region Header

        private void headerSuratKeluar()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetSuratKeluar.DataSource = dt;

            WidthSuratKeluar();
        }

        private void headerNikah()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetNikah.DataSource = dt;

            WidthNikah();
        }

        private void headerModelNA()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetModelNA.DataSource = dt;

            WidthModelNA();
        }

        private void headerWakaf()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetWakaf.DataSource = dt;

            WidthWakaf();
        }

        private void headerTalak()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetTalak.DataSource = dt;

            WidthTalak();
        }

        private void headerCerai()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetCerai.DataSource = dt;

            WidthCerai();
        }

        private void headerMasukIslam()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetMasukIslam.DataSource = dt;

            WidthMasukIslam();
        }

        private void headerRekomendasi()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetRekomendasi.DataSource = dt;

            WidthRekomendasi();
        }

        private void headerDuplikat()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetDuplikat.DataSource = dt;

            WidthDuplikat();
        }

        private void headerHaji()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetHaji.DataSource = dt;

            WidthHaji();
        }

        private void headerOthers()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetOthers.DataSource = dt;

            WidthOthers();
        }

        private void headerKeuangan()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[2] {
                                new DataColumn("Volume", typeof(Int32)),
                                new DataColumn("Keterangan", typeof(string))});
            this.dgvWorksheetKeuangan.DataSource = dt;

            WidthKeuangan();
        }

        #endregion

        #region Width

        private void WidthSuratKeluar()
        {
            dgvWorksheetSuratKeluar.Columns[0].Width = 690;
            dgvWorksheetSuratKeluar.Columns[1].Width = 80;
            dgvWorksheetSuratKeluar.Columns[2].Width = 353;

            dgvWorksheetSuratKeluar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthKeuangan()
        {
            dgvWorksheetKeuangan.Columns[0].Width = 690;
            dgvWorksheetKeuangan.Columns[1].Width = 80;
            dgvWorksheetKeuangan.Columns[2].Width = 353;

            dgvWorksheetKeuangan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthOthers()
        {
            dgvWorksheetOthers.Columns[0].Width = 690;
            dgvWorksheetOthers.Columns[1].Width = 80;
            dgvWorksheetOthers.Columns[2].Width = 353;
        
            dgvWorksheetOthers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthHaji()
        {
            dgvWorksheetHaji.Columns[0].Width = 690;
            dgvWorksheetHaji.Columns[1].Width = 80;
            dgvWorksheetHaji.Columns[2].Width = 353;

            dgvWorksheetHaji.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthDuplikat()
        {
            dgvWorksheetDuplikat.Columns[0].Width = 690;
            dgvWorksheetDuplikat.Columns[1].Width = 80;
            dgvWorksheetDuplikat.Columns[2].Width = 353;

            dgvWorksheetDuplikat.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthRekomendasi()
        {
            dgvWorksheetRekomendasi.Columns[0].Width = 690;
            dgvWorksheetRekomendasi.Columns[1].Width = 80;
            dgvWorksheetRekomendasi.Columns[2].Width = 353;

            dgvWorksheetRekomendasi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter; ;
        }

        private void WidthMasukIslam()
        {
            dgvWorksheetMasukIslam.Columns[0].Width = 690;
            dgvWorksheetMasukIslam.Columns[1].Width = 80;
            dgvWorksheetMasukIslam.Columns[2].Width = 353;

            dgvWorksheetMasukIslam.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthCerai()
        {
            dgvWorksheetCerai.Columns[0].Width = 690;
            dgvWorksheetCerai.Columns[1].Width = 80;
            dgvWorksheetCerai.Columns[2].Width = 353;

            dgvWorksheetCerai.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthTalak()
        {
            dgvWorksheetTalak.Columns[0].Width = 690;
            dgvWorksheetTalak.Columns[1].Width = 80;
            dgvWorksheetTalak.Columns[2].Width = 353;

            dgvWorksheetTalak.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthWakaf()
        {
            dgvWorksheetWakaf.Columns[0].Width = 690;
            dgvWorksheetWakaf.Columns[1].Width = 80;
            dgvWorksheetWakaf.Columns[2].Width = 353;

            dgvWorksheetWakaf.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthModelNA()
        {
            dgvWorksheetModelNA.Columns[0].Width = 690;
            dgvWorksheetModelNA.Columns[1].Width = 80;
            dgvWorksheetModelNA.Columns[2].Width = 353;

            dgvWorksheetModelNA.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        private void WidthNikah()
        {
            dgvWorksheetNikah.Columns[0].Width = 690;
            dgvWorksheetNikah.Columns[1].Width = 80;
            dgvWorksheetNikah.Columns[2].Width = 353;

            dgvWorksheetNikah.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #endregion

        #region Method Insert LCKH

        private void save()
        {
            elc = new EntLCKH();
            etc = new EntRemoteTransactionClient();

            if (procces.Equals("SURAT KELUAR", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Surat Keluar

                foreach (DataGridViewRow row in dgvWorksheetSuratKeluar.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanSuratKeluar"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("NIKAH", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Nikah

                foreach (DataGridViewRow row in dgvWorksheetNikah.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanNikah"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("MODEL NA", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Model NA

                foreach (DataGridViewRow row in dgvWorksheetModelNA.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanModelNA"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("REKOMENDASI", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Rekomendasi

                foreach (DataGridViewRow row in dgvWorksheetRekomendasi.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanRekomendasi"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("DUPLIKAT", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Duplikat

                foreach (DataGridViewRow row in dgvWorksheetDuplikat.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanDuplikat"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("MASUK ISLAM", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Masuk Islam

                foreach (DataGridViewRow row in dgvWorksheetMasukIslam.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanMasukIslam"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("TALAK", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Talak

                foreach (DataGridViewRow row in dgvWorksheetTalak.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanTalak"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("CERAI", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Cerai

                foreach (DataGridViewRow row in dgvWorksheetCerai.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanCerai"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("HAJI", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Haji

                foreach (DataGridViewRow row in dgvWorksheetHaji.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanHaji"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("KEUANGAN", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Keuangan

                foreach (DataGridViewRow row in dgvWorksheetKeuangan.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanKeuangan"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("WAKAF", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Wakaf

                foreach (DataGridViewRow row in dgvWorksheetWakaf.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanWakaf"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else if (procces.Equals("OTHERS", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Others

                foreach (DataGridViewRow row in dgvWorksheetOthers.Rows)
                {
                    elc.Idetailkegiatan = row.Cells["cmbKegiatanLainnya"].Value.ToString();
                    elc.Jumlah = Convert.ToInt16(row.Cells["Volume"].Value.ToString());
                    elc.Keterangan = row.Cells["Keterangan"].Value.ToString();

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Capaian Kinerja Harian" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = irl.save(elc, etc);

                    if (condition)
                    {
                        sendDataToServer();

                        refershForm();
                    }
                    else
                    {
                        setMessageInsert();
                    }
                }

                #endregion
            }

            else
            {
                setMessageInsert();
            }
        }

        #endregion

        #endregion

        #region Validation Button Tampil Lembar Kerja

        private void cmbWorkSheet_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiButton();

            if (cmbWorkSheet.SelectedItem.ToString() != "Lainnya")
            {
                setEnableCmbJenisKegiatan(false);
            }
            else
            {
                setEnableCmbJenisKegiatan(true);
                setEnableButtonWorkSheet(false);
                cmbJenisKegiatan.SelectedValue = "";
            }
        }

        private void cmbJenisKegiatan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdJenisKegiatan.Text = cmbJenisKegiatan.SelectedValue.ToString();
                setValidasiButton();
            }
            catch { }
        }

        #endregion

        #region Event Button and ComboBox

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (procces.Equals("SURAT KELUAR", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetSuratKeluar.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("NIKAH", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetNikah.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("REKOMENDASI", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetRekomendasi.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("DUPLIKAT", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetDuplikat.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("MASUK ISLAM", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetMasukIslam.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("TALAK", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetTalak.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("CERAI", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetCerai.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("HAJI", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetHaji.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("KEUANGAN", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetKeuangan.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("WAKAF", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetWakaf.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("MODEL NA", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetModelNA.Rows.RemoveAt(rowDgv);
                }
                else if (procces.Equals("OTHERS", StringComparison.InvariantCultureIgnoreCase))
                {
                    dgvWorksheetOthers.Rows.RemoveAt(rowDgv);
                }
            }
            catch { }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            setDataLCKH();
            setNotifikasiSync();
            setEnableButtonSave(false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setVisibleSelectWorksheet(false);
            setEnableButtonSave(true);
            setValdiationCancel();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            status = "Capaian Harian";

            FrmChoosePeriodeKegiatan frm = new FrmChoosePeriodeKegiatan(viewForm, receivejabatan, receiveipaddress, receivenama, status);
            viewForm(frm);
        }

        private void btnViewWorkSheet_Click(object sender, EventArgs e)
        {
            viewWorkSheet();
        }

        private void cmbJenisKegiatan_Click(object sender, EventArgs e)
        {
            setCmbJenisKegiatan();
        }

        #endregion

        #region Event DataGridView

        #region Auto Number Dgv

        private void dgvWorksheetAktaNikah_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetModelNA_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetNikah_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetWakaf_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetKeuangan_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetRekomendasi_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetDuplikat_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetMasukIslam_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetTalak_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetCerai_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetHaji_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetOthers_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dgvWorksheetSuratKeluar_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));
        }

        #endregion

        #region SET ComboBox DGV

        private void dgvWorksheetModelNA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetModelNA.CurrentCell.RowIndex;
                dgvWorksheetModelNA.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetNikah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetNikah.CurrentCell.RowIndex;
                dgvWorksheetNikah.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetWakaf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetWakaf.CurrentCell.RowIndex;
                dgvWorksheetWakaf.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetKeuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetKeuangan.CurrentCell.RowIndex;
                dgvWorksheetKeuangan.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetRekomendasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetRekomendasi.CurrentCell.RowIndex;
                dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetDuplikat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetDuplikat.CurrentCell.RowIndex;
                dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetMasukIslam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetMasukIslam.CurrentCell.RowIndex;
                dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetTalak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetTalak.CurrentCell.RowIndex;
                dgvWorksheetTalak.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetCerai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetCerai.CurrentCell.RowIndex;
                dgvWorksheetCerai.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetHaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetHaji.CurrentCell.RowIndex;
                dgvWorksheetHaji.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetSuratKeluar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetSuratKeluar.CurrentCell.RowIndex;
                dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        private void dgvWorksheetOthers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatanOthers();
                rowDgv = dgvWorksheetOthers.CurrentCell.RowIndex;
                dgvWorksheetOthers.Rows[e.RowIndex].Cells[2].Value = "-";
            }
            catch { }
        }

        #endregion

        #region Validation Input Dgv

        private void dgvWorksheetModelNA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetNikah_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetWakaf_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetKeuangan_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetRekomendasi_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetDuplikat_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetMasukIslam_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetTalak_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetCerai_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetHaji_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetSuratKeluar_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        private void dgvWorksheetOthers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetSuratKeluar.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
                {
                    setMessageInputTrue();
                }
                else
                {
                    setMessageInputFalse();
                }
            }
        }

        #endregion

        #region Dgv Cell End Edit

        private void dgvWorksheetModelNA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetModelNA.Rows)
                {
                    foreach (DataGridViewRow rowmd in dgvSyncModelNA.Rows)
                    {
                        dgvWorksheetModelNA.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowmd.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetNikah_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetNikah.Rows)
                {
                    foreach (DataGridViewRow rownikah in dgvSyncPernikahan.Rows)
                    {
                        dgvWorksheetNikah.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rownikah.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetWakaf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetWakaf.Rows)
                {
                    foreach (DataGridViewRow rowwk in dgvSyncWakaf.Rows)
                    {
                        dgvWorksheetWakaf.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowwk.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetRekomendasi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetRekomendasi.Rows)
                {
                    foreach (DataGridViewRow rowrk in dgvSyncRekomendasi.Rows)
                    {
                        dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowrk.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetDuplikat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetDuplikat.Rows)
                {
                    foreach (DataGridViewRow rowdp in dgvSyncDuplikat.Rows)
                    {
                        dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowdp.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetMasukIslam_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetMasukIslam.Rows)
                {
                    foreach (DataGridViewRow rowms in dgvSyncMasukIslam.Rows)
                    {
                        dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowms.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetTalak_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetTalak.Rows)
                {
                    foreach (DataGridViewRow rowtalak in dgvSyncTalak.Rows)
                    {
                        dgvWorksheetTalak.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowtalak.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetCerai_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetCerai.Rows)
                {
                    foreach (DataGridViewRow rowcerai in dgvSyncCerai.Rows)
                    {
                        dgvWorksheetCerai.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowcerai.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetHaji_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetHaji.Rows)
                {
                    foreach (DataGridViewRow rowhaji in dgvSyncHaji.Rows)
                    {
                        dgvWorksheetHaji.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowhaji.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetSuratKeluar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvWorksheetSuratKeluar.Rows)
                {
                    foreach (DataGridViewRow rowsk in dgvSyncSuratKeluar.Rows)
                    {
                        dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowsk.Cells["jumlah"].Value.ToString());
                    }
                }
            }
            catch { }
        }

        #endregion

        #region SET Variabel Proses

        private void dgvWorksheetModelNA_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "MODEL NA";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron II";
        }

        private void dgvWorksheetNikah_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "NIKAH";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetWakaf_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "WAKAF";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetKeuangan_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancel.Visible = true;
            btnSave.Visible = true;
            btnDelete.Visible = true;
            setEnableButtonSave(false);

            procces = "KEUANGAN";
            statuskegiatan = "Tidak Sinkron";
            keterangan = "Tidak Sinkron";
        }

        private void dgvWorksheetRekomendasi_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "REKOMENDASI";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetDuplikat_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "DUPLIKAT";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetMasukIslam_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "MASUK ISLAM";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetTalak_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "TALAK";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetCerai_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "CERAI";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron II";
        }

        private void dgvWorksheetHaji_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "HAJI";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";   
        }

        private void dgvWorksheetSuratKeluar_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleButtonDgv(false);

            procces = "SURAT KELUAR";
            statuskegiatan = "Sinkron";
            keterangan = "Sinkron I";
        }

        private void dgvWorksheetOthers_MouseMove(object sender, MouseEventArgs e)
        {
            btnCancel.Visible = true;
            btnDelete.Visible = true;
            btnSave.Visible = true;
            setEnableButtonSave(false);

            procces = "OTHERS";
            statuskegiatan = "Tidak Sinkron";
            keterangan = "Tidak Sinkron";
        }

        #endregion

        #endregion

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
