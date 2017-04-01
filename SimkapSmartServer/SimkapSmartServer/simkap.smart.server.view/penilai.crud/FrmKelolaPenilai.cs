using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.penilai.crud
{
    public partial class FrmKelolaPenilai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaPenilai(string receiveIp, string receiveNama, Action setDataPejabatPenilai, FrmMenu frmMenu,
                            FrmPejabatPenilai frmPejabatPenilai)
        {
            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setDataPejabatPenilai = setDataPejabatPenilai;
            this.frmMenu = frmMenu;
            this.frmPejabatPenilai = frmPejabatPenilai;
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodTambahPejabatPenilai();
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
            frmPejabatPenilai.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodTambahPejabatPenilai()
        {
            ipp = Controller.getPejabatPenilai();
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
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Penilai" + "]" +
                   "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert

        private void savePejabatPenilai()
        {
            epp = new EntPejabatPenilai();

            epp.Idpegawai = cmbNamaPegawai.SelectedValue.ToString();

            validation = ipp.validationInsert(epp);

            if (validation)
            {
                message = "Pegawai dengan NIP : " + cmbNamaPegawai.SelectedValue.ToString() + "sudah menjadi penilai";

                MessageBox.Show(message, "Infromasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = ipp.save(epp, logTransactionSave());

                if (condition)
                {
                    setVisibleNotifikasiSave(false);

                    clearData();
                }
                else
                {
                    message = "Data gagal disimpan";

                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        #region Event Button and ComboBox

        private void cmbNamaPegawai_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            savePejabatPenilai();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaPenilai_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataPejabatPenilai();
        }
    }
}
