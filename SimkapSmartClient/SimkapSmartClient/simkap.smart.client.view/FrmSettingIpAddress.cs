using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmSettingIpAddress : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmSettingIpAddress(FrmLogin frmLogin, Action startRemote)
        {
            InitializeComponent();
            InitializeFunction();

            this.startRemote = startRemote;
            this.frmLogin = frmLogin;
        }

        #region All Function

        private void InitializeFunction()
        {
            setEnableButton(true);
            setVisibleNotifikasiSave(true);
        }

        #region Setting

        private void setEventEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtIpAddress.Text == "")
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void setVisibleNotifikasiSave(bool condition)
        {
            panelNotifikasi.Visible = !condition;
            lblTextNotifikasi.Visible = !condition;
        }

        private void clear()
        {
            txtIpAddress.ResetText();
            panelNotifikasi.Focus();
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setValidationButton()
        {
            if(txtIpAddress.Text == "")
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        #endregion

        #region Method Save

        private void save()
        {
            if (txtIpAddress.Text != null)
            {
                Properties.Settings.Default.ipServer = txtIpAddress.Text;
                Properties.Settings.Default.Save();

                clear();
                setVisibleNotifikasiSave(false);
            }
        }

        #endregion

        #endregion

        #region Event Button and TextBox

        private void txtIpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void txtIpAddress_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                save();
            }
            catch(Exception ex)
            {
                message = "Terjadi kesalahan pada : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalashan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            startRemote();
            this.Close();
            frmLogin.Enabled = true;
        }

        #endregion

        #region Validasi Button

        private void txtIpAddress_TextChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion

        private void FrmSettingIpAddress_FormClosing(object sender, FormClosingEventArgs e)
        {
            startRemote();
            frmLogin.Enabled = true;
        }
    }
}
