using System;
using System.Windows.Forms;
using System.Threading;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.menu;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.preview;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.input
{
    public partial class FrmChoosePeriodeMutasi : DevComponents.DotNetBar.Metro.MetroForm
    {

        public FrmChoosePeriodeMutasi(string procces, Action<Form> viewForm, string sendJabatan, string periodeawal, string periodeakhir, 
                                            string status, string tanggal)
        {
            InitializeComponent();

            this.procces = procces;
            this.viewForm = viewForm;
            this.sendJabatan = sendJabatan;
            this.periodeawal = periodeawal;
            this.periodeakhir = periodeakhir;
            this.status = status;
            this.tanggal = tanggal;

            setEnableButton(true);
            startRemote();
        }

        #region Setting

        private void setEnableButton(bool condition)
        {
            btnViewPrint.Enabled = !condition;
        }

        private void setValidationButton()
        {
            if (dtPeriodeAkhirMutasi.Value == null)
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
            FrmPrintPreview frm = new FrmPrintPreview(procces, viewForm, sendJabatan, periodeawal,
                                                        periodeakhir, status, tanggal, dtPeriodeAwalMutasi.Value.ToString("yyyy-MM-dd"),
                                                        dtPeriodeAkhirMutasi.Value.ToString("yyyy-MM-dd"));
            viewForm(frm);
        }

        private void setMessage()
        {
            message = "Koneksi ke server terputus";

            MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            el.Periodeawalmutasi = dtPeriodeAwalMutasi.Value.ToString("yyyy-MM-dd");
            el.Periodeakhirmutasi = dtPeriodeAkhirMutasi.Value.ToString("yyyy-MM-dd");
        }

        #endregion

        #region Validation Button

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion

        #region Event Metro Panel

        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            getEntiy();

            if (procces.Equals("Perilaku Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    condition = ir.validationReportUkurSasaranMutasi(el);

                    if (condition)
                    {
                        status = "Perilaku Kerja Mutasi";
                        formPreviewShow();
                    }
                    else
                    {
                        message = "Tidak ada laporan mutasi ukur sasaran pada periode " + dtPeriodeAwalMutasi.Value.ToString("yyyy-MM-dd") + " s/d " + periodeakhir;

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    setMessage();
                }
            }
            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                status = "Prestasi Kerja Mutasi";
                formPreviewShow();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmMenuMutasi frm = new FrmMenuMutasi(procces, viewForm, sendJabatan, periodeawal, periodeakhir);
            viewForm(frm);
        }

        #endregion

        private void FrmChoosePeriodeMutasi_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
