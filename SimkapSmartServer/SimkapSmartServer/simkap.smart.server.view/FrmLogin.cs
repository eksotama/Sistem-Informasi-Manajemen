using System;
using System.Net;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            InitializeFunction();
        }

        #region All Function

        #region Setting

        private string logTransactionLogin()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Login" + "]" + "" +
                    "" + "   " + lblIpAddress.Text + "   " + txtNama.Text;

            return log;
        }

        private void InitializeFunction()
        {
            setIPaddress();
            setLoginMethod();
            setVisibleButton(true);
            setVisibaleLabelButtonTextBox(true);
            setVisibleWarningBox(true);
            setEnableButton(true);
        }

        private void setEnableButton(bool conditon)
        {
            btnLogin.Enabled = !conditon;
        }

        private void setVisibleWarningBox(bool condition)
        {
            warningLogin.Visible = !condition;
        }

        private void setVisibaleLabelButtonTextBox(bool condition)
        {
            lblKataSandi.Visible = condition;
            lblNama.Visible = condition;
            txtNama.Visible = condition;
            txtPass.Visible = condition;
            btnLogin.Visible = condition;
            btnLihatPass.Visible = condition;
            lblProgressText.Visible = !condition;
            circularProgress1.Visible = !condition;
            lblProgressText.Focus();
        }

        private void setIPaddress()
        {
            IPHostEntry kompdata = Dns.GetHostEntry(Dns.GetHostName());

            for (int i = 0; i < kompdata.AddressList.Length; i++)
            {
                sendIpServer = string.Empty;
                sendHostServer = string.Empty;

                if (kompdata.AddressList[i].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    sendIpServer = kompdata.AddressList[i].ToString();
                    sendHostServer = kompdata.HostName;

                    lblIpAddress.Text = sendIpServer;
                    lblHostName.Text = sendHostServer;

                    break;
                }
            }
        }

        private void setEventEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtNama.Text == "" || txtPass.Text == "")
                {
                    //.....
                }
                else
                {
                    btnLogin_Click(sender, el);
                }
            }
        }

        private void setVisibleButton(bool condition)
        {
            btnSembunyiPass.Visible = !condition;
            btnLihatPass.Visible = condition;
        }

        private void setSystemPassword(bool condition)
        {
            txtPass.UseSystemPasswordChar = !condition;
        }

        private void clearTextBox()
        {
            txtNama.ResetText();
            txtPass.ResetText();

            txtNama.Focus();
        }

        private void setLoginMethod()
        {
            ls = Controller.getLogin();
        }

        private void setValidasiTextBox()
        {
            if (txtNama.Text == "" || txtPass.Text == "")
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgress1.Value = Convert.ToInt32(circularProgress1.Value) + 10;

            if (Convert.ToInt32(circularProgress1.Value) == 100)
            {
                FrmMenu frm = new FrmMenu(sendNama, lblIpAddress.Text, lblHostName.Text);
                frm.Show();
                this.Hide();

                timer1.Enabled = false;
            }
        }

        #endregion

        #region Method Login

        private void loginUser(object sender, EventArgs e)
        {
            et = new EntAdministrator();

            et.Namapengguna = txtNama.Text;
            et.Passwordpengguna = txtPass.Text;

            condition = ls.loginUser(et, logTransactionLogin());

            if (condition == true)
            {
                sendNama = txtNama.Text;

                setVisibleWarningBox(true);
                setVisibaleLabelButtonTextBox(false);
                timer1.Start();
                timer1_Tick(sender, e);
            }
            else
            {
                setVisibleWarningBox(false);
            }

            clearTextBox();
        }

        #endregion

        #endregion

        #region Validation Button Login

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginUser(sender, e);
        }

        private void btnLihatPass_Click(object sender, EventArgs e)
        {
            setSystemPassword(true);
            setVisibleButton(false);
        }

        private void btnSembunyiPass_Click(object sender, EventArgs e)
        {
            setSystemPassword(false);
            setVisibleButton(true);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void warningLogin_CloseClick(object sender, EventArgs e)
        {
            setVisibleWarningBox(true);
        }

        #endregion
    }
}
