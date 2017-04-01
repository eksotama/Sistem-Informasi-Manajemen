using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            InitializeFunction();
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setIPaddress();
            timer1.Start();
            setEnableButton(true);
            setVisibleWarningBox(true);
        }

        #region Setting

        private void showForm(KeyEventArgs  e)
        {
            if(e.KeyCode == Keys.F12)
            {
                FrmSettingIpAddress frm = new FrmSettingIpAddress(this, startRemote);
                frm.Show();

                this.Enabled = false;
            }
        }

        private void setCmbJabatan()
        {
            try
            {
                cmbJabatan.DataSource = rlc.setCmbPegawai();
                cmbJabatan.DisplayMember = "jabatan";
                cmbJabatan.ValueMember = "jabatan";
            }
            catch
            {
                MessageBox.Show("Koneksi ke server terputus", "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                clearTextBox();
            }
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Login" + "]" + "" +
                    "" + "   " + lblIpAddress.Text + "   " + txtUser.Text + "\n";

            return data;
        }

        private void setVisibleWarningBox(bool condition)
        {
            warningLogin.Visible = !condition;
        }

        private void setEventEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtUser.Text == "" || txtPass.Text == "" || cmbJabatan.SelectedValue == null)
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
            try
            {
                txtUser.ResetText();
                txtPass.ResetText();
                cmbJabatan.SelectedValue = "";

                txtUser.Focus();
            }
            catch { }
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

        private void setValidasiTextBox()
        {
            if (txtUser.Text == "" || txtPass.Text == "" || cmbJabatan.SelectedValue == null)
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void setEnableButton(bool conditon)
        {
            btnLogin.Enabled = !conditon;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgress1.Value = Convert.ToInt32(circularProgress1.Value) + 10;

            if (Convert.ToInt32(circularProgress1.Value) == 100)
            {
                circularProgress1.Value = 20;
            }
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setLoginMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setLoginMethod()
        {
            obj = "SimkapSmartServer.ImpLoginClient";
            rlc = (IntRemoteLoginClient)Activator.GetObject(typeof(IntRemoteLoginClient), setting.getUrl(obj));
            rwc = (IntRemoteWriteTransactionClient)Activator.GetObject(typeof(IntRemoteWriteTransactionClient), setting.getUrl(obj));
        }

        #endregion

        #region Connected Method Monitoring to Server

        private void ConnectAsClient()
        {
            string s = setData();

            rwc.writeLogTransactionClient(s, setting.getServer(), setting.getPort2());
        }

        private void sendDataToServer()
        {
            mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        #endregion

        #region Method Login

        private void loginUser()
        {
            elp = new EntLoginPegawai();
            rc = new EntRemoteTransactionClient();

            elp.Namapengguna = txtUser.Text;
            elp.Jabatan = cmbJabatan.SelectedValue.ToString();
            elp.Katasandi = txtPass.Text;

            rc.Text = setData();

            condition = rlc.loginClient(elp, rc);

            if (condition)
            {
                sendDataToServer();

                setVisibleWarningBox(true);

                sendNama = txtUser.Text;

                FrmMenuClient frm = new FrmMenuClient(sendNama, sendIpServer, sendHostServer, elp.Jabatan);
                frm.Show();
                this.Hide();
            }
            else
            {
                setVisibleWarningBox(false);
                clearTextBox();
            }
        }

        #endregion

        #endregion

        #region Validation Button Login

        private void cmbJabatan_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button, ComboBox and TextBox

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            showForm(e);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            showForm(e);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            startRemote();
            setEventEnter(e);
        }

        private void btnSembunyiPass_Click(object sender, EventArgs e)
        {
            setSystemPassword(false);
            setVisibleButton(true);
        }

        private void btnLihatPass_Click(object sender, EventArgs e)
        {
            setSystemPassword(true);
            setVisibleButton(false);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginUser();
            }
            catch
            {
                MessageBox.Show("Koneksi ke server terputus", "Pesan Kesalahan - SIMKAP 1.0.0", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                clearTextBox();
            }
        }

        private void warningLogin_CloseClick(object sender, EventArgs e)
        {
            setVisibleWarningBox(true);
        }

        private void cmbJabatan_Click(object sender, EventArgs e)
        {
            setCmbJabatan();
        }

        #endregion
    }
}
