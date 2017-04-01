using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.atasan.penilai.crud
{
    public partial class FrmKelolaAtasanPenilai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaAtasanPenilai(string receiveIp, string receiveNama, Action setDataAtasanPejabatPenilai, FrmMenu frmMenu,
                                        FrmAtasanPenilai frmAtasanPenilai)
        {
            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setDataAtasanPejabatPenilai = setDataAtasanPejabatPenilai;
            this.frmMenu = frmMenu;
            this.frmAtasanPenilai = frmAtasanPenilai;
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodAtasanPenilai();
            setCmbNama();
            cmbNamaPegawai.SelectedValue = "";
        }

        #region Setting

        private void setVisibleNotifikasiSave(bool condition)
        {
            lblTextNotifikasi.Visible = !condition;
            panelNotifikasi.Visible = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setEnableForm(bool condition)
        {
            frmAtasanPenilai.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodAtasanPenilai()
        {
            iap = Controller.getAtasanPejabatPenilai();
            ip = Controller.getPegawai();
        }

        private void clearData()
        {
            cmbNamaPegawai.SelectedValue = "";

            panelNotifikasi.Focus();
        }

        private void setValidasiTextBox()
        {
            if (cmbNamaPegawai.SelectedValue == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void setCmbNama()
        {
            cmbNamaPegawai.DataSource = ip.setCmbPegawai();
            cmbNamaPegawai.DisplayMember = "nama";
            cmbNamaPegawai.ValueMember = "nip";
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Atasan Penilai" + "]" + "" +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert

        private void saveAtasanPenilai()
        {
            eap = new EntAtasanPejabatPenilai();

            eap.Idpegawai = cmbNamaPegawai.SelectedValue.ToString();

            validation = iap.validationInsert(eap);

            if (validation)
            {
                message = "Pegawai dengan NIP : " + cmbNamaPegawai.SelectedValue.ToString() + "sudah menjadi atasan penilai";

                MessageBox.Show(message, "Infromasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = iap.save(eap, logTransactionSave());

                if (condition)
                {
                    setVisibleNotifikasiSave(false);

                    clearData();
                }
                else
                {
                    message = "Data gagal disimpan";

                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #endregion

        #region Validation Button Save

        private void cmbNamaPegawai_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button

        private void cmbNamaPegawai_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveAtasanPenilai();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaAtasanPenilai_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataAtasanPejabatPenilai();
        }
    }
}
