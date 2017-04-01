using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.login.pegawai.crud
{
    public partial class FrmKelolaLoginPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaLoginPegawai(string receiveIp, string receiveNama, Action setDataLoginPegawai, FrmMenu frmMenu,
                                        FrmLoginPegawai frmLoginPegawai)
        {
            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setDataLoginPegawai = setDataLoginPegawai;
            this.frmMenu = frmMenu;
            this.frmLoginPegawai = frmLoginPegawai;
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodLoginPegawai();
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
            frmLoginPegawai.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodLoginPegawai()
        {
            ilp = Controller.getLoginPegawai();
        }

        private void clearData()
        {
            cmbNamaPegawai.SelectedValue = "";
            txtKataSandi.ResetText();
            txtNamaPengguna.ResetText();

            panelNotifikasi.Focus();
        }

        private void setValidasiTextBox()
        {
            if (cmbNamaPegawai.SelectedValue == null || txtKataSandi.Text == "" || txtNamaPengguna.Text == "")
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void setEventEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (cmbNamaPegawai.SelectedValue == null || txtKataSandi.Text == "" || txtNamaPengguna.Text == "")
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void setCmbNama()
        {
            cmbNamaPegawai.DataSource = ilp.setComboBox();
            cmbNamaPegawai.DisplayMember = "nama";
            cmbNamaPegawai.ValueMember = "nip";
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Login Pegawai" + "]" + "" +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert

        private void save()
        {
            elp = new EntLoginPegawai();

            elp.Nip = cmbNamaPegawai.SelectedValue.ToString();
            elp.Namapengguna = txtNamaPengguna.Text;
            elp.Katasandi = txtKataSandi.Text;

            validation = ilp.validationInsert(elp);

            if (validation)
            {
                message = "Pegawai dengan NIP : " + cmbNamaPegawai.SelectedValue.ToString() +"sudah memnpunyai akun login";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = ilp.save(elp, logTransactionSave());

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

        private void txtNamaPengguna_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtKataSandi_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button, ComboBox and TextBox

        private void cmbNamaPegawai_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void txtKataSandi_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaLoginPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataLoginPegawai();
        }
    }
}
