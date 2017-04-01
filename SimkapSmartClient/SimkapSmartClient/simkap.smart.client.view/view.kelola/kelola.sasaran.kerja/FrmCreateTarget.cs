using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmCreateTarget : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmCreateTarget(string sendipaddress, string sendnama, string sendidpenilai, string sendidatasanpenilai,
                                        string sendperiodeawal, string sendperiodeakhir, string sendjabatan, Action<Form> viewForm1)
        {

            InitializeComponent();
            InitializeFunction();

            this.viewForm1 = viewForm1;
            receiveipaddress = sendipaddress;
            receivenama = sendnama;
            receiveidpenilai = sendidpenilai;
            receiveidatasanpenilai = sendidatasanpenilai;
            receiveperiodeawal = sendperiodeawal;
            receiveperiodeakhir = sendperiodeakhir;
            receivejabatan = sendjabatan;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setHeaderDgv();
            setVisibleWorkSheet(true);
            setVisibleButtonDgv(true);
            setEnableButtonSave(true);
            setEnableButtonWorkSheet(true);
        
            setCmbWorkSheet();

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
            FrmCreateTarget frm = new FrmCreateTarget(receiveipaddress, receivenama, receiveidpenilai, receiveidatasanpenilai,
                                                        receiveperiodeawal, receiveperiodeakhir, receivejabatan, viewForm1);
            viewForm1(frm);
        }

        private void setEnableButtonSave(bool condition)
        {   
            btnSave.Enabled = !condition;
        }


        private void setDataSKP()
        {
            elp = new EntLoginPegawai();

            elp.Periodeawal = receiveperiodeawal;
            elp.Periodeakhir = receiveperiodeakhir;
            elp.Idjenis = txtIdJenisKegiatan.Text;

            dgvSyncPernikahan.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncWakaf.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncDuplikat.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncRekomendasi.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncMasukIslam.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncTalak.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncCerai.DataSource = isk.selectDgvSyncII(elp);
            dgvSyncHaji.DataSource = isk.selectDgvSyncI(elp);
            dgvSyncSuratKeluar.DataSource = isk.selectDgvSyncI(elp);
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
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                    "" + "   " + receiveipaddress + "   " + receivenama + "\n";

            return data;
        }

        private void setCmbJenisKegiatan()
        {
            cmbJenisKegiatan.DataSource = isk.selectJenisKegiatan();
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

        #endregion

        #region Set ComboBox Dgv

        private void getEntity()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = receivejabatan;
            elp.Idjenis = txtIdJenisKegiatan.Text;
            elp.Periodeawal = receiveperiodeawal;
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

            cmbKegiatanHaji.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanNikah.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanWakaf.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanTalak.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanCerai.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanModelNA.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanKeuangan.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanDuplikat.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanMasukIslam.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanRekomendasi.DataSource = isk.selectKegiatan(elp);
            cmbKegiatanSuratKeluar.DataSource = isk.selectKegiatan(elp);

            getValueCmb();
        }

        private void setCmbKegiatanOthers()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = receivejabatan;
            elp.Periodeawal = receiveperiodeawal;
            elp.Statuskegiatan = statuskegiatan;
            elp.Keterangan = keterangan;

            cmbKegiatanLainnya.DataSource = isk.selectKegiatanOthers(elp);
            cmbKegiatanLainnya.DisplayMember = "kegiatan";
            cmbKegiatanLainnya.ValueMember = "iddetailkegiatan";
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

            obj = "SimkapSmartServer.ImpSasaranKerja";

            isk = (IntRemoteSasaranKerja)Activator.GetObject(typeof(IntRemoteSasaranKerja), setting.getUrl(obj));
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

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetSuratKeluar.DataSource = dt;

            WidthSuratKeluar();
        }

        private void headerNikah()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetNikah.DataSource = dt;

            WidthNikah();
        }

        private void headerModelNA()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetModelNA.DataSource = dt;

            WidthModelNA();
        }

        private void headerWakaf()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetWakaf.DataSource = dt;

            WidthWakaf();
        }

        private void headerTalak()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetTalak.DataSource = dt;

            WidthTalak();
        }

        private void headerCerai()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetCerai.DataSource = dt;

            WidthCerai();
        }

        private void headerMasukIslam()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetMasukIslam.DataSource = dt;

            WidthMasukIslam();
        }

        private void headerRekomendasi()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetRekomendasi.DataSource = dt;

            WidthRekomendasi();
        }

        private void headerDuplikat()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetDuplikat.DataSource = dt;

            WidthDuplikat();
        }

        private void headerHaji()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetHaji.DataSource = dt;

            WidthHaji();
        }

        private void headerOthers()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetOthers.DataSource = dt;

            WidthOthers();
        }

        private void headerKeuangan()
        {
            dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[5] {
                                new DataColumn("Kuantitas", typeof(Int32)),
                                new DataColumn("Kualitas", typeof(Int32)),
                                new DataColumn("Biaya", typeof(double)),
                                new DataColumn("Waktu",typeof(Int32)),
                                new DataColumn("Satuan Waktu",typeof(string))});
            this.dgvWorksheetKeuangan.DataSource = dt;

            WidthKeuangan();
        }

        #endregion

        #region Width

        private void WidthSuratKeluar()
        {
            dgvWorksheetSuratKeluar.Columns[0].Width = 656;
            dgvWorksheetSuratKeluar.Columns[1].Width = 80;
            dgvWorksheetSuratKeluar.Columns[2].Width = 80;
            dgvWorksheetSuratKeluar.Columns[3].Width = 120;
            dgvWorksheetSuratKeluar.Columns[4].Width = 80;
            dgvWorksheetSuratKeluar.Columns[5].Width = 107;

            formatSuratKeluar();
        }

        private void WidthKeuangan()
        {
            dgvWorksheetKeuangan.Columns[0].Width = 656;
            dgvWorksheetKeuangan.Columns[1].Width = 80;
            dgvWorksheetKeuangan.Columns[2].Width = 80;
            dgvWorksheetKeuangan.Columns[3].Width = 120;
            dgvWorksheetKeuangan.Columns[4].Width = 80;
            dgvWorksheetKeuangan.Columns[5].Width = 107;

            formatKeuangan();
        }

        private void WidthOthers()
        {
            dgvWorksheetOthers.Columns[0].Width = 656;
            dgvWorksheetOthers.Columns[1].Width = 80;
            dgvWorksheetOthers.Columns[2].Width = 80;
            dgvWorksheetOthers.Columns[3].Width = 120;
            dgvWorksheetOthers.Columns[4].Width = 80;
            dgvWorksheetOthers.Columns[5].Width = 107;

            formatOthers();
        }

        private void WidthHaji()
        {
            dgvWorksheetHaji.Columns[0].Width = 656;
            dgvWorksheetHaji.Columns[1].Width = 80;
            dgvWorksheetHaji.Columns[2].Width = 80;
            dgvWorksheetHaji.Columns[3].Width = 120;
            dgvWorksheetHaji.Columns[4].Width = 80;
            dgvWorksheetHaji.Columns[5].Width = 107;

            formatHaji();
        }

        private void WidthDuplikat()
        {
            dgvWorksheetDuplikat.Columns[0].Width = 656;
            dgvWorksheetDuplikat.Columns[1].Width = 80;
            dgvWorksheetDuplikat.Columns[2].Width = 80;
            dgvWorksheetDuplikat.Columns[3].Width = 120;
            dgvWorksheetDuplikat.Columns[4].Width = 80;
            dgvWorksheetDuplikat.Columns[5].Width = 107;

            formatDuplikat();
        }

        private void WidthRekomendasi()
        {
            dgvWorksheetRekomendasi.Columns[0].Width = 656;
            dgvWorksheetRekomendasi.Columns[1].Width = 80;
            dgvWorksheetRekomendasi.Columns[2].Width = 80;
            dgvWorksheetRekomendasi.Columns[3].Width = 120;
            dgvWorksheetRekomendasi.Columns[4].Width = 80;
            dgvWorksheetRekomendasi.Columns[5].Width = 107;

            formatRekomendasi();
        }

        private void WidthMasukIslam()
        {
            dgvWorksheetMasukIslam.Columns[0].Width = 656;
            dgvWorksheetMasukIslam.Columns[1].Width = 80;
            dgvWorksheetMasukIslam.Columns[2].Width = 80;
            dgvWorksheetMasukIslam.Columns[3].Width = 120;
            dgvWorksheetMasukIslam.Columns[4].Width = 80;
            dgvWorksheetMasukIslam.Columns[5].Width = 107;

            formatMasukIslam();
        }

        private void WidthCerai()
        {
            dgvWorksheetCerai.Columns[0].Width = 656;
            dgvWorksheetCerai.Columns[1].Width = 80;
            dgvWorksheetCerai.Columns[2].Width = 80;
            dgvWorksheetCerai.Columns[3].Width = 120;
            dgvWorksheetCerai.Columns[4].Width = 80;
            dgvWorksheetCerai.Columns[5].Width = 107;

            formatCerai();
        }

        private void WidthTalak()
        {
            dgvWorksheetTalak.Columns[0].Width = 656;
            dgvWorksheetTalak.Columns[1].Width = 80;
            dgvWorksheetTalak.Columns[2].Width = 80;
            dgvWorksheetTalak.Columns[3].Width = 120;
            dgvWorksheetTalak.Columns[4].Width = 80;
            dgvWorksheetTalak.Columns[5].Width = 107;

            formatTalak();
        }

        private void WidthWakaf()
        {
            dgvWorksheetWakaf.Columns[0].Width = 656;
            dgvWorksheetWakaf.Columns[1].Width = 80;
            dgvWorksheetWakaf.Columns[2].Width = 80;
            dgvWorksheetWakaf.Columns[3].Width = 120;
            dgvWorksheetWakaf.Columns[4].Width = 80;
            dgvWorksheetWakaf.Columns[5].Width = 107;

            formatWakaf();
        }

        private void WidthModelNA()
        {
            dgvWorksheetModelNA.Columns[0].Width = 656;
            dgvWorksheetModelNA.Columns[1].Width = 80;
            dgvWorksheetModelNA.Columns[2].Width = 80;
            dgvWorksheetModelNA.Columns[3].Width = 120;
            dgvWorksheetModelNA.Columns[4].Width = 80;
            dgvWorksheetModelNA.Columns[5].Width = 107;

            formatModelNa();
        }

        private void WidthNikah()
        {
            dgvWorksheetNikah.Columns[0].Width = 656;
            dgvWorksheetNikah.Columns[1].Width = 80;
            dgvWorksheetNikah.Columns[2].Width = 80;
            dgvWorksheetNikah.Columns[3].Width = 120;
            dgvWorksheetNikah.Columns[4].Width = 80;
            dgvWorksheetNikah.Columns[5].Width = 107;

            formatNikah();
        }

        #endregion

        #region Format

        private void formatModelNa()
        {
            dgvWorksheetModelNA.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetModelNA.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetModelNA.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetModelNA.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetModelNA.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetModelNA.Columns[3].DefaultCellStyle.Format = "N2";
        }
        private void formatNikah()
        {
            dgvWorksheetNikah.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetNikah.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetNikah.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetNikah.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetNikah.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetNikah.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatWakaf()
        {
            dgvWorksheetWakaf.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetWakaf.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetWakaf.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetWakaf.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetWakaf.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetWakaf.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatTalak()
        {
            dgvWorksheetTalak.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetTalak.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetTalak.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetTalak.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetTalak.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;


            dgvWorksheetTalak.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatCerai()
        {
            dgvWorksheetCerai.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetCerai.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetCerai.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetCerai.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetCerai.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetCerai.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatMasukIslam()
        {
            dgvWorksheetMasukIslam.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetMasukIslam.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetMasukIslam.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetMasukIslam.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetMasukIslam.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetMasukIslam.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatRekomendasi()
        {
            dgvWorksheetRekomendasi.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetRekomendasi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetRekomendasi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetRekomendasi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetRekomendasi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetRekomendasi.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatDuplikat()
        {
            dgvWorksheetDuplikat.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetDuplikat.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetDuplikat.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetDuplikat.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetDuplikat.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetDuplikat.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatHaji()
        {
            dgvWorksheetHaji.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetHaji.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetHaji.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetHaji.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetHaji.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetHaji.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatOthers()
        {
            dgvWorksheetOthers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetOthers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetOthers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetOthers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetOthers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetOthers.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatKeuangan()
        {
            dgvWorksheetKeuangan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetKeuangan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetKeuangan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetKeuangan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetKeuangan.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetKeuangan.Columns[3].DefaultCellStyle.Format = "N2";
        }

        private void formatSuratKeluar()
        {
            dgvWorksheetSuratKeluar.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetSuratKeluar.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetSuratKeluar.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;
            dgvWorksheetSuratKeluar.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvWorksheetSuratKeluar.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            dgvWorksheetSuratKeluar.Columns[3].DefaultCellStyle.Format = "N2";
        }
        

        #endregion

        #endregion

        #region Method Insert SKP

        private void save()
        {
            esk = new EntSasaranKerja();
            etc = new EntRemoteTransactionClient();

            if (procces.Equals("SURAT KELUAR", StringComparison.InvariantCultureIgnoreCase))
            {
                #region Insert Dgv Surat Keluar

                foreach (DataGridViewRow row in dgvWorksheetSuratKeluar.Rows)
                {
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanSuratKeluar"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    condition = isk.save(esk, etc);

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanNikah"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanModelNA"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    condition = isk.save(esk, etc);

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja]" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanRekomendasi"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;
                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanDuplikat"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanMasukIslam"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanTalak"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    condition = isk.save(esk, etc);

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanCerai"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    condition = isk.save(esk, etc);

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanHaji"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    condition = isk.save(esk, etc);

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanKeuangan"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;

                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanWakaf"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;
                    condition = isk.save(esk, etc);

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
                    esk.Iddetailkegiatan = row.Cells["cmbKegiatanLainnya"].Value.ToString();
                    esk.Idpenilai = receiveidpenilai;
                    esk.Idatasanpenilai = receiveidatasanpenilai;
                    esk.Kuantitas = Convert.ToInt16(row.Cells["Kuantitas"].Value.ToString());
                    esk.Kualitas = Convert.ToInt16(row.Cells["Kualitas"].Value.ToString());
                    esk.Biaya = Convert.ToDouble(row.Cells["Biaya"].Value.ToString());
                    esk.Jumlahwaktu = Convert.ToInt16(row.Cells["Waktu"].Value.ToString());
                    esk.Satuanwaktu = row.Cells["Satuan Waktu"].Value.ToString();
                    esk.Periodeawal = receiveperiodeawal;
                    esk.Periodeakhir = receiveperiodeakhir;

                    etc.Text = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Sasaran Kerja" + "]" + "" +
                                 "" + "   " + receiveipaddress + "   " + receivenama;
                    condition = isk.save(esk, etc);

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
        }

        #endregion

        #endregion

        #region Validation Button Tampil Lembar Kerja

        private void cmbJenisKegiatan_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtIdJenisKegiatan.Text = cmbJenisKegiatan.SelectedValue.ToString();
                setValidasiButton();
            }
            catch { }
        }

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setVisibleSelectWorksheet(false);
            setEnableButtonSave(true);
            setValdiationCancel();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch { }
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            setDataSKP();
            setNotifikasiSync();
            setEnableButtonSave(false);
        }

        private void cmbJenisKegiatan_Click(object sender, EventArgs e)
        {
            setCmbJenisKegiatan();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            status = "Sasaran Kerja";

            FrmChoosePenilai frm = new FrmChoosePenilai(viewForm1, receiveipaddress, receivenama, receivejabatan, status);
            viewForm1(frm);
        }

        private void btnViewWorkSheet_Click(object sender, EventArgs e)
        {
            viewWorkSheet();
        }

        #endregion

        #region Event DataGridView

        #region Auto Number Dgv

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
                dgvWorksheetModelNA.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetModelNA.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetNikah_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetNikah.CurrentCell.RowIndex;
                dgvWorksheetNikah.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetNikah.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetWakaf_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetWakaf.CurrentCell.RowIndex;
                dgvWorksheetWakaf.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetWakaf.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetKeuangan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetKeuangan.CurrentCell.RowIndex;
                dgvWorksheetKeuangan.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetKeuangan.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetRekomendasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetRekomendasi.CurrentCell.RowIndex;
                dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetDuplikat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetDuplikat.CurrentCell.RowIndex;
                dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetMasukIslam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetMasukIslam.CurrentCell.RowIndex;
                dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetTalak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetTalak.CurrentCell.RowIndex;
                dgvWorksheetTalak.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetTalak.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetCerai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetCerai.CurrentCell.RowIndex;
                dgvWorksheetCerai.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetCerai.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetHaji_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetHaji.CurrentCell.RowIndex;
                dgvWorksheetHaji.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetHaji.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetOthers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatanOthers();
                rowDgv = dgvWorksheetOthers.CurrentCell.RowIndex;
                dgvWorksheetOthers.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetOthers.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        private void dgvWorksheetSuratKeluar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                setCmbKegiatan();
                rowDgv = dgvWorksheetSuratKeluar.CurrentCell.RowIndex;
                dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[3].Value = 0;
                dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[5].Value = "Bulan";
            }
            catch { }
        }

        #endregion

        #region Validation Input Dgv

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

        private void dgvWorksheetModelNA_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                if (dgvWorksheetModelNA.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetNikah.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetWakaf.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetKeuangan.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetRekomendasi.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetDuplikat.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetMasukIslam.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetTalak.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetCerai.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetHaji.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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
                if (dgvWorksheetOthers.Columns[e.ColumnIndex].ValueType.ToString() == "System.Int32")
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

        private void dgvWorksheetSuratKeluar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[1].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetSuratKeluar.Rows)
                {
                    foreach (DataGridViewRow rowsk in dgvSyncSuratKeluar.Rows)
                    {
                        #region Sync Surat Keluar

                        dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowsk.Cells["Kuantitas"].Value.ToString());
                        dgvWorksheetSuratKeluar.Rows[e.RowIndex].Cells[4].Value = rowsk.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetModelNA_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetModelNA.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetModelNA.Rows)
                {
                    foreach (DataGridViewRow rowna in dgvSyncPernikahan.Rows)
                    {
                        #region Sync Model NA

                        dgvWorksheetModelNA.Rows[e.RowIndex].Cells[1].Value = Convert.ToInt16(rowna.Cells["Kuantitas"].Value.ToString()) * 2;
                        dgvWorksheetModelNA.Rows[e.RowIndex].Cells[4].Value = rowna.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetNikah_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetNikah.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetNikah.Rows)
                {
                    foreach (DataGridViewRow rownikah in dgvSyncPernikahan.Rows)
                    {
                        #region Sync Nikah 

                        dgvWorksheetNikah.Rows[e.RowIndex].Cells[1].Value = rownikah.Cells["Kuantitas"].Value.ToString();

                        if(dgvWorksheetNikah.Rows[e.RowIndex].Cells[4].Value.ToString() == null)
                        {
                            if (Convert.ToInt32(dgvWorksheetNikah.Rows[e.RowIndex].Cells[5].Value) > 13)
                            {
                                message = "Maximal waktu target 12 bulan";
                                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            dgvWorksheetNikah.Rows[e.RowIndex].Cells[5].Value = rownikah.Cells["JumlahWaktu"].Value.ToString();
                        }

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetWakaf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetWakaf.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetWakaf.Rows)
                {
                    foreach (DataGridViewRow rowwk in dgvSyncWakaf.Rows)
                    {
                        #region Sync Wakaf

                        dgvWorksheetWakaf.Rows[e.RowIndex].Cells[1].Value = rowwk.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetWakaf.Rows[e.RowIndex].Cells[4].Value = rowwk.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetKeuangan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetKeuangan.Rows[e.RowIndex].Cells[2].Value = 100;
            }
            catch { }
        }

        private void dgvWorksheetRekomendasi_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetRekomendasi.Rows)
                {
                    foreach (DataGridViewRow rowrk in dgvSyncRekomendasi.Rows)
                    {
                        #region Rekomendasi

                        dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[1].Value = rowrk.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetRekomendasi.Rows[e.RowIndex].Cells[4].Value = rowrk.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetDuplikat_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetDuplikat.Rows)
                {
                    foreach (DataGridViewRow rowdk in dgvSyncDuplikat.Rows)
                    {
                        #region Duplikat

                        dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[1].Value = rowdk.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetDuplikat.Rows[e.RowIndex].Cells[4].Value = rowdk.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetMasukIslam_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetMasukIslam.Rows)
                {
                    foreach (DataGridViewRow rowms in dgvSyncMasukIslam.Rows)
                    {
                        #region Masuk Islam

                        dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[1].Value = rowms.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetMasukIslam.Rows[e.RowIndex].Cells[4].Value = rowms.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetTalak_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetTalak.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetTalak.Rows)
                {
                    foreach (DataGridViewRow rowtk in dgvSyncTalak.Rows)
                    {
                        #region Talak

                        dgvWorksheetTalak.Rows[e.RowIndex].Cells[1].Value = rowtk.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetTalak.Rows[e.RowIndex].Cells[4].Value = rowtk.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetCerai_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetCerai.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetCerai.Rows)
                {
                    foreach (DataGridViewRow rowcr in dgvSyncCerai.Rows)
                    {
                        #region Cerai

                        dgvWorksheetCerai.Rows[e.RowIndex].Cells[1].Value = rowcr.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetCerai.Rows[e.RowIndex].Cells[4].Value = rowcr.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetHaji_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetHaji.Rows[e.RowIndex].Cells[2].Value = 100;

                foreach (DataGridViewRow row in dgvWorksheetHaji.Rows)
                {
                    foreach (DataGridViewRow rowhj in dgvSyncHaji.Rows)
                    {
                        #region Haji

                        dgvWorksheetHaji.Rows[e.RowIndex].Cells[1].Value = rowhj.Cells["Kuantitas"].Value.ToString();
                        dgvWorksheetHaji.Rows[e.RowIndex].Cells[4].Value = rowhj.Cells["JumlahWaktu"].Value.ToString();

                        #endregion
                    }
                }
            }
            catch { }
        }

        private void dgvWorksheetOthers_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvWorksheetOthers.Rows[e.RowIndex].Cells[2].Value = 100;
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
