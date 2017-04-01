using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran;
using SimkapSmartClient.simkap.smart.client.view.view.kelola.penilaian.realisasi;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all
{
    public partial class FrmChoosePeriodeKegiatan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmChoosePeriodeKegiatan(Action<Form> viewForm, string sendjabatan, string sendipaddress, string sendnama, string procces)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm = viewForm;
            this.sendjabatan = sendjabatan;
            this.sendipaddress = sendipaddress;
            this.sendnama = sendnama;
            this.procces = procces;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setEnableButton(true);
        }

        #region Setting

        private void setEnableButton(bool conditon)
        {
            btnNext.Enabled = !conditon;
        }

        private void setValidasiButton()
        {
            if (dtPeriodeAkhir.Value == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
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
            obj = "SimkapSmartServer.ImpValidationPeriode";

            iv = (IntRemoteValidationPeriode)Activator.GetObject(typeof(IntRemoteValidationPeriode), setting.getUrl(obj));
        }

        #endregion

        #region Cek Data

        private void setValidationPeriode()
        {
            ers = new EntValidationPeriode();

            ers.Periodeawal = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
            ers.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");
            ers.Jabatan = sendjabatan;

            condition = iv.selectPeriode(ers);

            if (condition)
            {
                if (procces.Equals("Capaian Harian",
                        StringComparison.InvariantCultureIgnoreCase))
                {
                    FrmCreateCapaianKinerjaHarian frm = new FrmCreateCapaianKinerjaHarian(sendipaddress, sendnama,
                                                            dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd"), dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd"),
                                                            sendjabatan, viewForm);
                    viewForm(frm);
                }
                else if (procces.Equals("Realisasi",
                            StringComparison.InvariantCultureIgnoreCase))
                {
                    FrmViewRealisasi frm = new FrmViewRealisasi(sendipaddress, sendnama,
                                                 dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd"), dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd"),
                                                    sendjabatan, viewForm);

                    viewForm(frm);
                }
                else if (procces.Equals("Ukur Sasaran",
                             StringComparison.InvariantCultureIgnoreCase))
                {
                    FrmWorksheetUkurSasaran frm = new FrmWorksheetUkurSasaran(sendipaddress, sendnama,
                                                        dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd"), dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd"),
                                                                sendjabatan, viewForm);
                    viewForm(frm);
                }
            }
            else
            {
                message = "Anda belum membuat target kegiatan pada periode tersebut";

                MessageBox.Show(message, "Information - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #endregion

        #region Validation Button

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            setValidasiButton();
        }

        #endregion

        #region Event Button

        private void btnNext_Click(object sender, EventArgs e)
        {
            setValidationPeriode();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (procces.Equals("Capaian Harian",
                    StringComparison.InvariantCultureIgnoreCase))
            {
                this.Close();
            }
            else if (procces.Equals("Realisasi",
                        StringComparison.InvariantCultureIgnoreCase))
            {
                FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, sendipaddress, sendnama, sendjabatan, frmmenuclient);
                viewForm(frm);
            }
            else if (procces.Equals("Ukur Sasaran",
                         StringComparison.InvariantCultureIgnoreCase))
            {
                FrmMenuKelola frm = new FrmMenuKelola(procces, viewForm, sendipaddress, sendnama, sendjabatan, frmmenuclient);
                viewForm(frm);
            }
        }

        #endregion

        private void FrmChoosePeriodeKegiatan_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
