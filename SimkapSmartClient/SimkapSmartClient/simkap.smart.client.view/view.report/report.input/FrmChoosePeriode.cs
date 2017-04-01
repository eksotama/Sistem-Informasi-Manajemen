using System;
using System.Windows.Forms;
using System.Threading;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.menu;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.preview;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.input
{
    public partial class FrmChoosePeriode : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmChoosePeriode(Action<Form> viewForm, string sendJabatan, string procces)
        {
            InitializeComponent();

            this.viewForm = viewForm;
            this.sendJabatan = sendJabatan;
            this.procces = procces;

            setEnableButton(true);
            startRemote();
        }

        #region Setting

        private void setEnableButton(bool condition)
        {
            btnPrint.Enabled = !condition;
        }

        private void setValidationButton()
        {
            if(dtPeriodeAkhir.Value == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void formPreviewShow()
        {
            FrmPrintPreview frm = new FrmPrintPreview(procces, viewForm, sendJabatan, dtPeriodeAwal.Value.ToString("yyyy-MM-dd"),
                                                dtPeriodeAkhir.Value.ToString("yyyy-MM-dd"), status, dtTanggal.Value.ToString("yyyy-MM-dd"),
                                                    periodeawalmutasi, periodeakhirmutasi);
            viewForm(frm);
        }

        private void formMenuMutasiShow()
        {
            FrmMenuMutasi frm = new FrmMenuMutasi(procces, viewForm, sendJabatan, dtPeriodeAwal.Value.ToString("yyyy-MM-dd"),
                                                    dtPeriodeAkhir.Value.ToString("yyyy-MM-dd"));
            viewForm(frm);
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
            obj = "SimkapSmartServer.ImpValidationReport";
            ir = (IntRemoteValidationReport)Activator.GetObject(typeof(IntRemoteValidationReport), setting.getUrl(obj));
        }

        #endregion

        #region Inisialisasi Entity

        private void getEntiy()
        {
            el = new EntLaporan();

            el.Jabatan = sendJabatan;
            el.Periodeawal = dtPeriodeAwal.Value.ToString("yyyy-MM-dd");
            el.Periodeakhir = dtPeriodeAkhir.Value.ToString("yyyy-MM-dd");
            el.Tanggal = dtTanggal.Value.ToString("yyyy-MM-dd");
        }

        #endregion

        #region Validtion

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion

        #region Event Button

        private void btnPrint_Click(object sender, EventArgs e)
        {
            getEntiy();
            
            #region Cover

            if (procces.Equals("Cover",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                FrmMenuCoverLaporan frm = new FrmMenuCoverLaporan(procces, viewForm, sendJabatan, dtPeriodeAwal.Value.ToString("yyyy-MM-dd"), 
                                                    dtPeriodeAkhir.Value.ToString("yyyy-MM-dd"));
                viewForm(frm);
            }

            #endregion

            #region Capaian Harian

            else if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                execute = ir.validationReportSasaranKerja(el);

                if (execute)
                {
                    condition = ir.validationReportCapaian(el);

                    if (condition)
                    {
                        formPreviewShow();
                    }
                    else
                    {
                        message = "Tidak ada laporan capaian kinerja harian pada tanggal " + DateTime.Now.ToString("dd/MM/yyyy");

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    message = "Anda belum membuat target kegiatan pada periode " + dtPeriodeAwal.Value.ToString("yyyy-MM-dd") + " s/d " +
                                dtPeriodeAkhir.Value.ToString("yyyy-MM-dd");

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Sasaran Kerja

            else if (procces.Equals("Sasaran Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                condition = ir.validationReportSasaranKerja(el);

                if (condition)
                {
                    formPreviewShow();
                }
                else
                {
                    message = "Tidak ada laporan sasaran kerja pada periode " + dtPeriodeAwal.Value.ToString("yyyy-MM-dd") + " s/d " +
                                                    dtPeriodeAkhir.Value.ToString("yyyy-MM-dd");

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Ukur Sasaran

            else if (procces.Equals("Ukur Sasaran",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                condition = ir.validationReportUkurSasaran(el);

                if (condition)
                {
                    formPreviewShow();
                }
                else
                {
                    message = "Tidak ada laporan ukur sasaran pada periode " + dtPeriodeAwal.Value.ToString("yyyy-MM-dd") + " s/d " +
                                                    dtPeriodeAkhir.Value.ToString("yyyy-MM-dd");

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion

            #region Perilaku Kerja

            else if (procces.Equals("Perilaku Kerja",
                StringComparison.InvariantCultureIgnoreCase))
            {
                formMenuMutasiShow();
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                StringComparison.InvariantCultureIgnoreCase))
            {
                formMenuMutasiShow();
            }

            #endregion

            #region Lampiran

            else if (procces.Equals("Lampiran",
                StringComparison.InvariantCultureIgnoreCase))
            {
                FrmMenuLampiran frm = new FrmMenuLampiran(procces, viewForm, sendJabatan, dtPeriodeAwal.Value.ToString("yyyy-MM-dd"),
                                                    dtPeriodeAkhir.Value.ToString("yyyy-MM-dd"));
                viewForm(frm);
            }

            #endregion
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport(viewForm, sendJabatan);
            viewForm(frm);
        }

        #endregion

        private void FrmChoosePeriode_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
