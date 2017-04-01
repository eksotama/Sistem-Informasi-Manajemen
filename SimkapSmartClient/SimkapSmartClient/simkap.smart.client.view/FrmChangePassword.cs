using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view
{
    public partial class FrmChangePassword : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmChangePassword(string ipaddress, string nama)
        {
            InitializeComponent();
            InitializeFunction();

            receiveipaddress = ipaddress;
            receivenama = nama;
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            startRemote();
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

        private void setValidasiTextBox()
        {
            if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
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
                if (txtOldPassword.Text == "" || txtNewPassword.Text == "" || txtConfirmPassword.Text == "")
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void clearData()
        {
            txtOldPassword.ResetText();
            txtNewPassword.ResetText();
            txtConfirmPassword.ResetText();

            panelNotifikasi.Focus();
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Login Pegawai" + "]" + "" +
                    "" + "   " + receiveipaddress + "   " + receivenama + "\n";

            return data;
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            ThreadStart client1 = new ThreadStart(setLogoutMethod);
            Thread client2 = new Thread(client1);
            client2.Start();
        }

        private void setLogoutMethod()
        {
            obj = "SimkapSmartServer.ImpChangePassword";

            rwc = (IntRemoteWriteTransactionClient)Activator.GetObject(typeof(IntRemoteWriteTransactionClient), setting.getUrl(obj));
            rcp = (IntRemoteChangePassword)Activator.GetObject(typeof(IntRemoteChangePassword), setting.getUrl(obj));
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
            Thread mThread = new Thread(new ThreadStart(ConnectAsClient));
            mThread.Start();
        }

        #endregion

        #region Method Update

        private void editLoginPegawai()
        {
            elp = new EntLoginPegawai();
            rtc = new EntRemoteTransactionClient();

            elp.Namapengguna = receivenama;
            elp.Katasandi = txtConfirmPassword.Text;

            rtc.Text = setData();

            conditionselect = rcp.selectPassword(elp);

            if (conditionselect)
            {
                if (txtNewPassword.Text == txtConfirmPassword.Text)
                {
                    condition = rcp.edit(elp, rtc);

                    if (condition)
                    {
                        sendDataToServer();

                        setVisibleNotifikasiSave(false);

                        clearData();
                    }
                    else
                    {
                        message = "Data gagal diubah";

                        MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    message = "Konfirmasi kata sandi baru tidak valid";

                    MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                message = "Kata sandi lama tidak valid";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Validation Button Save

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void txtOldPassword_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            editLoginPegawai();
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void FrmChangePassword_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
