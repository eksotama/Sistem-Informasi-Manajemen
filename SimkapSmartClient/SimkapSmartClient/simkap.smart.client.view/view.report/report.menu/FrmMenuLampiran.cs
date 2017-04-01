using System;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.input;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.preview;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using System.Threading;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.menu
{
    public partial class FrmMenuLampiran : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenuLampiran(string procces, Action<Form> viewForm, string sendJabatan, string periodeawal, string periodeakhir)
        {
            InitializeComponent();

            this.procces = procces;
            this.viewForm = viewForm;
            this.sendJabatan = sendJabatan;
            this.periodeawal = periodeawal;
            this.periodeakhir = periodeakhir;

            startRemote();
        }

        #region Setting

        private void formShow()
        {
            FrmPrintPreview frm = new FrmPrintPreview(procces, viewForm, sendJabatan, periodeawal, periodeakhir, status,
                                                        tanggal, periodeawalmutasi, periodeakhirmutasi);
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
            el.Periodeawal = periodeawal;
            el.Periodeakhir = periodeakhir;
        }

        #endregion

        #region Event Metro Panel

        private void mtAwal_Click(object sender, EventArgs e)
        {
            status = "Awal";

            formShow();
        }

        private void mtClose_Click(object sender, EventArgs e)
        {
            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        private void mtAkhir_Click(object sender, EventArgs e)
        {
            getEntiy();

            condition = ir.validationReportSasaranKerja(el);

            if (condition)
            {
                status = "Akhir";

                formShow();
            }
            else
            {
                message = "Anda belum menambahkan data penilai " + periodeawal + " s/d " + periodeakhir;

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void FrmMenuLampiran_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
