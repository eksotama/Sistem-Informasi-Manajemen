using System;
using System.Windows.Forms;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.input;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.preview;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using System.Threading;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.menu
{
    public partial class FrmMenuCoverLaporan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenuCoverLaporan(string procces, Action<Form> viewForm, string sendJabatan, string sendPeriodeAwal, string sendPeriodeAkhir)
        {
            InitializeComponent();

            this.procces = procces;
            this.sendJabatan = sendJabatan;
            this.sendPeriodeAwal = sendPeriodeAwal;
            this.sendPeriodeAkhir = sendPeriodeAkhir;
            this.viewForm = viewForm;

            startRemote();
        }

        #region Setting

        private void formShow()
        {
            FrmPrintPreview frm = new FrmPrintPreview(procces, viewForm, sendJabatan, sendPeriodeAwal, sendPeriodeAkhir, status, tanggal,
                                             periodeawalmutasi, periodeakhirmutasi);
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
            el.Periodeawal = sendPeriodeAwal;
            el.Periodeakhir = sendPeriodeAkhir;
        }

        #endregion

        #region Event Metro Panel

        private void mtCoverDepan_Click(object sender, EventArgs e)
        {
            getEntiy();

            condition = ir.validationReportPeriode(el);

            if (condition)
            {
                status = "Depan";

                formShow();
            }
            else
            {
                message = "Anda belum memiliki cover laporan pada periode " + sendPeriodeAwal + " s/d " + sendPeriodeAkhir;

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtDataPenilai_Click(object sender, EventArgs e)
        {
            getEntiy();

            condition = ir.validationReportPenilai(el);

            if (condition)
            {
                execute = ir.validationReportAtasanPenilai(el);

                if (execute)
                {
                    status = "Data Pegawai";

                    formShow();
                }
                else
                {
                    message = "Anda belum menambahkan data pegawai penilai pada periode " + sendPeriodeAwal + " s / d " + sendPeriodeAkhir;

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                message = "Anda belum menambahkan data pegawai penilai pada periode " + sendPeriodeAwal + " s/d " + sendPeriodeAkhir;

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mtClose_Click(object sender, EventArgs e)
        {
            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmMenuCoverLaporan_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
