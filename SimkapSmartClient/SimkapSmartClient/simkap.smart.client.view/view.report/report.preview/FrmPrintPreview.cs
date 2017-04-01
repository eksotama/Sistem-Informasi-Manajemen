using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.report.report.cover;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.menu;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.input;
using SimkapSmartClient.simkap.smart.client.setting.report.report.ukur.sasaran;
using SimkapSmartClient.simkap.smart.client.setting.report.report.sasaran.kerja;
using SimkapSmartClient.simkap.smart.client.setting.report.report.prilaku.kerja;
using SimkapSmartClient.simkap.smart.client.setting.report.report.capaian.kinerja.harian;
using SimkapSmartClient.simkap.smart.client.setting.report.report.lampiran;
using SimkapSmartClient.simkap.smart.client.setting.report.report.prestasi.kerja;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.preview
{
    public partial class FrmPrintPreview : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPrintPreview(string procces, Action<Form> viewForm, string jabatan,
                                string periodeawal, string periodeakhir, string status, string tanggal, string periodeawalmutasi, 
                                  string periodeakhirmutasi)
        {
            InitializeComponent();

            this.procces = procces;
            this.viewForm = viewForm;
            this.jabatan = jabatan;
            this.periodeawal = periodeawal;
            this.periodeakhir = periodeakhir;
            this.status = status;
            this.tanggal = tanggal;
            this.periodeawalmutasi = periodeawalmutasi;
            this.periodeakhirmutasi = periodeakhirmutasi;

            setTittleForm();
            startRemote();
            printPreview();
        }

        #region Setting

        private void setTittleForm()
        {
            #region Cover

            if (procces.Equals("Cover",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Depan",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Cover Depan - SIMKAP 1.0.0";
                }
                else if (status.Equals("Data Pegawai",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Cover Data Pegawai - SIMKAP 1.0.0";
                }
            }

            #endregion

            #region Capaian Harian

            else if (procces.Equals("Capaian Harian",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Cetak Capaian Harian - SIMKAP 1.0.0";
            }

            #endregion

            #region Sasaran Kerja

            else if (procces.Equals("Sasaran Kerja",
                StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Cetak Sasaran Kerja - SIMKAP 1.0.0";
            }

            #endregion

            #region Ukur Sasaran

            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                this.Text = "Cetak Ukur Sasaran - SIMKAP 1.0.0";
            }

            #endregion

            #region Perilaku Kerja

            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Perilaku Kerja Biasa",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Sasaran Kerja Biasa - SIMKAP 1.0.0";
                }
                else if (status.Equals("Perilaku Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Sasaran Kerja Mutasi - SIMKAP 1.0.0";
                }
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Prestasi Kerja Biasa",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Prestasi Kerja Biasa - SIMKAP 1.0.0";
                }
                else if (status.Equals("Prestasi Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Prestasi Kerja Mutasi - SIMKAP 1.0.0";
                }
            }

            #endregion

            #region Lampiran

            else if (procces.Equals("Lampiran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Awal",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Lampiran Awal - SIMKAP 1.0.0";
                }
                else if (status.Equals("Akhir",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    this.Text = "Cetak Lampiran Akhir - SIMKAP 1.0.0";
                }
            }

            #endregion
        }

        private void setMessage()
        {
            message = "Koneksi ke server terputus";

            MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void formPeriodeShow()
        {
            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, jabatan, procces);
            viewForm(frm);
        }

        private void formMenuMutasiShow()
        {
            FrmMenuMutasi frm = new FrmMenuMutasi(procces, viewForm, jabatan, periodeawal, periodeakhir);
            viewForm(frm);
        }

        private void formMenuCoverShow()
        {
            FrmMenuCoverLaporan frm = new FrmMenuCoverLaporan(procces, viewForm, jabatan, periodeawal, periodeakhir);
            viewForm(frm);
        }

        #endregion

        #region Closing Form

        private void ClosingForm()
        {
            #region Cover

            if (procces.Equals("Cover",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Depan",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuCoverShow();
                }
                else if (status.Equals("Data Pegawai",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuCoverShow();
                }
            }

            #endregion

            #region Capaian Harian

            else if (procces.Equals("Capaian Harian",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                formPeriodeShow();
            }

            #endregion

            #region Sasaran Kerja

            else if (procces.Equals("Sasaran Kerja",
                StringComparison.InvariantCultureIgnoreCase))
            {
                formPeriodeShow();
            }

            #endregion

            #region Ukur Sasaran

            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                formPeriodeShow();
            }

            #endregion

            #region Perilaku Kerja

            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Perilaku Kerja Biasa",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuMutasiShow();
                }
                else if (status.Equals("Perilaku Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuMutasiShow();
                }
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Prestasi Kerja Biasa",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuMutasiShow();
                }
                else if (status.Equals("Prestasi Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    formMenuMutasiShow();
                }
            }

            #endregion

            #region Lampiran

            else if (procces.Equals("Lampiran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Awal",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    FrmMenuLampiran frm = new FrmMenuLampiran(procces, viewForm, jabatan, periodeawal, periodeakhir);
                    viewForm(frm);
                }
                else if (status.Equals("Akhir",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    FrmMenuLampiran frm = new FrmMenuLampiran(procces, viewForm, jabatan, periodeawal, periodeakhir);
                    viewForm(frm);
                }
            }

            #endregion
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(getMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void getMethod()
        {
            obj = "SimkapSmartServer.ImpReport";
            ir = (IntRemoteReport)Activator.GetObject(typeof(IntRemoteReport), setting.getUrl(obj));
        }

        #endregion

        #region Preview

        private void printPreview()
        {
            et = new EntLaporan();

            et.Jabatan = jabatan;
            et.Periodeawal = periodeawal;
            et.Periodeakhir = periodeakhir;
            et.Tanggal = tanggal;
            et.Periodeawalmutasi = periodeawalmutasi;
            et.Periodeakhirmutasi = periodeakhirmutasi;

            #region Cover

            if (procces.Equals("Cover",
                  StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Depan",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpCoverDepan cryRpt = new CrpCoverDepan();

                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));
                        cryRpt.Database.Tables["LaporanPeriode"].SetDataSource(ir.reportPeriode(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
                else if (status.Equals("Data Pegawai",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpCover cryRpt = new CrpCover();

                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["AtasanPenilai"].SetDataSource(ir.reportAtasanPenilai(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));
                        cryRpt.Database.Tables["LaporanPeriode"].SetDataSource(ir.reportPeriode(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
            }

            #endregion

            #region Capaian Harian

            else if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    CrpLCKH cryRpt = new CrpLCKH();

                    cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                    cryRpt.Database.Tables["CapaianHarian"].SetDataSource(ir.reportCapaian(et));
                    cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                    crystalReportViewer1.ReportSource = cryRpt;
                    crystalReportViewer1.Refresh();
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion

            #region Sasaran Kerja

            else if (procces.Equals("Sasaran Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    CrpWorksheet cryRpt = new CrpWorksheet();

                    cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));
                    cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                    cryRpt.Database.Tables["SKPAwal"].SetDataSource(ir.reportSasaranKerja(et));

                    crystalReportViewer1.ReportSource = cryRpt;
                    crystalReportViewer1.Refresh();
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion

            #region Ukur Sasaran

            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    CrpUkurSasaran cryRpt = new CrpUkurSasaran();

                    cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                    cryRpt.Database.Tables["UkurSasaran"].SetDataSource(ir.reportUkurSasaran(et));

                    crystalReportViewer1.ReportSource = cryRpt;
                    crystalReportViewer1.Refresh();
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion

            #region Perilaku Kerja

            else if (procces.Equals("Perilaku Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Perilaku Kerja Biasa",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpPrilakuKerja cryRpt = new CrpPrilakuKerja();

                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["UkurSasaran"].SetDataSource(ir.reportUkurSasaran(et));
                        cryRpt.Database.Tables["PerilakuKerja"].SetDataSource(ir.reportPerilaku(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
                else if (status.Equals("Perilaku Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpPrilakuKerjaMutasi cryRpt = new CrpPrilakuKerjaMutasi();

                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["UkurSasaran"].SetDataSource(ir.reportUkurSasaran(et));
                        cryRpt.Database.Tables["UkurSasaranMutasi"].SetDataSource(ir.reportUkurSasaranMutasi(et));
                        cryRpt.Database.Tables["PerilakuKerja"].SetDataSource(ir.reportPerilaku(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Prestasi Kerja Biasa",
                    StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpPenilaianPrestasi cryRpt = new CrpPenilaianPrestasi();

                        cryRpt.Database.Tables["AtasanPenilai"].SetDataSource(ir.reportAtasanPenilai(et));
                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["UkurSasaran"].SetDataSource(ir.reportUkurSasaran(et));
                        cryRpt.Database.Tables["PerilakuKerja"].SetDataSource(ir.reportPerilaku(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
                else if (status.Equals("Prestasi Kerja Mutasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpPenilaianPrestasiMutasi cryRpt = new CrpPenilaianPrestasiMutasi();

                        cryRpt.Database.Tables["AtasanPenilai"].SetDataSource(ir.reportAtasanPenilai(et));
                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["UkurSasaran"].SetDataSource(ir.reportUkurSasaran(et));
                        cryRpt.Database.Tables["UkurSasaranMutasi"].SetDataSource(ir.reportUkurSasaran(et));
                        cryRpt.Database.Tables["PerilakuKerja"].SetDataSource(ir.reportPerilaku(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
            }

            #endregion

            #region Lampiran

            else if (procces.Equals("Lampiran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                if (status.Equals("Awal",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpLampiranAwal cryRpt = new CrpLampiranAwal();

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
                else if (status.Equals("Akhir",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    try
                    {
                        CrpLampiranAkhir cryRpt = new CrpLampiranAkhir();

                        cryRpt.Database.Tables["AtasanPenilai"].SetDataSource(ir.reportAtasanPenilai(et));
                        cryRpt.Database.Tables["Penilai"].SetDataSource(ir.reportPenilai(et));
                        cryRpt.Database.Tables["YangDinilai"].SetDataSource(ir.reportYangDiniali(et));

                        crystalReportViewer1.ReportSource = cryRpt;
                        crystalReportViewer1.Refresh();
                    }
                    catch
                    {
                        setMessage();
                    }
                }
            }

            #endregion
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ClosingForm();
        }

        #endregion
    }
}
