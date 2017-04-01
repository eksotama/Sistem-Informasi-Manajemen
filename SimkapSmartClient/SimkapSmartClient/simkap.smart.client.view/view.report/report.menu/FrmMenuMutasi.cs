using SimkapSmartClient.simkap.smart.client.view.view.report.report.input;
using SimkapSmartClient.simkap.smart.client.view.view.report.report.preview;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.menu
{
    public partial class FrmMenuMutasi : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmMenuMutasi(string procces, Action<Form> viewForm,
                                string sendJabatan, string periodeawal, string periodeakhir)
        {
            InitializeComponent();

            this.procces = procces;
            this.viewForm = viewForm;
            this.sendJabatan = sendJabatan;
            this.periodeawal = periodeawal;
            this.periodeakhir = periodeakhir;

            setTittleForm();
            startRemote();
        }

        #region Setting

        private void setTittleForm()
        {
            if (procces.Equals("Perilaku Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                mtBiasa.TitleText = "Lap. Perilaku Kerja Biasa";
                mtMutasi.TitleText = "Lap. Perilaku Kerja Mutasi";
            }
            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                mtBiasa.TitleText = "Lap. Prestasi Kerja Biasa";
                mtMutasi.TitleText = "Lap. Prestasi Kerja Mutasi";
            }
        }

        private void setMessage()
        {
            message = "Koneksi ke server terputus";

            MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        #endregion

        #region View Fom

        private void formShow()
        {
            FrmPrintPreview frm = new FrmPrintPreview(procces, viewForm, sendJabatan, periodeawal, periodeakhir, status, tanggal,
                                                        periodeawalmutasi, periodeakhirmutasi);
            viewForm(frm);
        }

        private void formMutasiShow()
        {
            FrmChoosePeriodeMutasi frm = new FrmChoosePeriodeMutasi(procces, viewForm, sendJabatan, periodeawal, periodeakhir, status, tanggal);
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

        private void mtBiasa_Click(object sender, EventArgs e)
        {
            getEntiy();

            #region Perilaku Kerja

            if (procces.Equals("Perilaku Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    condition = ir.validationReportPerilaku(el);

                    if (condition)
                    {
                        status = "Perilaku Kerja Biasa";
                        formShow();
                    }
                    else
                    {
                        message = "Tidak ada laporan perilaku biasa pada periode " + periodeawal + " s/d " + periodeakhir;

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                condition = ir.validationReportPerilaku(el);

                if (condition)
                {
                    excute = ir.validationReportUkurSasaran(el);

                    if (excute)
                    {
                        status = "Prestasi Kerja Biasa";
                        formShow();
                    }
                    else
                    {
                        message = "Anda belum menambahkan data ukur sasaran " + periodeawal + " s/d " + periodeakhir;

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    message = "Anda belum menambahkan data perilaku kerja " + periodeawal + " s/d " + periodeakhir;

                    MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            #endregion
        }

        private void mtMutasi_Click(object sender, EventArgs e)
        {
            getEntiy();

            #region Perilaku Kerja

            if (procces.Equals("Perilaku Kerja",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    condition = ir.validationReportPerilaku(el);

                    if (condition)
                    {
                        status = "Perilaku Kerja Mutasi";
                        formMutasiShow();
                    }
                    else
                    {
                        message = "Tidak ada laporan perilaku mutasi pada periode " + periodeawal + " s/d " + periodeakhir;

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion

            #region Prestasi Kerja

            else if (procces.Equals("Prestasi Kerja",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                try
                {
                    condition = ir.validationReportPerilaku(el);

                    if (condition)
                    {
                        excute = ir.validationReportUkurSasaran(el);

                        if (excute)
                        {
                            status = "Prestasi Kerja Mutasi";
                            formMutasiShow();
                        }
                        else
                        {
                            message = "Anda belum menambahkan data ukur sasaran " + periodeawal + " s/d " + periodeakhir;

                            MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        message = "Anda belum menambahkan data perilaku kerja pada periode " + periodeawal + " s/d " + periodeakhir;

                        MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    setMessage();
                }
            }

            #endregion
        }

        private void mtClose_Click(object sender, EventArgs e)
        {
            FrmChoosePeriode frm = new FrmChoosePeriode(viewForm, sendJabatan, procces);
            viewForm(frm);
        }

        #endregion

        private void FrmMenuMutasi_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
