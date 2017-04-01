using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.administrator.crud
{
    public partial class FrmKelolaAdmin : DevComponents.DotNetBar.Metro.MetroForm
    {

        public FrmKelolaAdmin(string receiveIp, string receiveNama, string sendId, string sendNama,
                                Action setVisibleNotifikasiEditSucces, string sendJekel, string sendUser, string sendPassword,
                                Action setDataAdministrator, FrmMenu frmMenu, FrmAdministartor frmAdministartor)
        {

            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.setDataAdministrator = setDataAdministrator;
            this.frmMenu = frmMenu;
            this.frmAdministartor = frmAdministartor;

            lblKeterangan.Text = "Ubah Administrator";
            receiveId = sendId;
            txtNama.Text = sendNama;

            if (sendJekel == "Pria")
            {
                cbPria.Checked = true;
            }
            if (sendJekel == "Wanita")
            {
                cbWanita.Checked = true;
            }

            txtNamaPengguna.Text = sendUser;
            txtPassword.Text = sendPassword;       
        }

        #region All Function

        private void InitializeFunction()
        {
            setEnableButton(true);
            setMethodAdministrator();
        }

        #region Setting

        private string logTransactionEdit()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Administrator" + "]" + "  " +
                  "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private void setEnableButton(bool condition)
        {
            btnSave.Enabled = !condition;
        }

        private void setEnableForm(bool condition)
        {
            frmAdministartor.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodAdministrator()
        {
            ia = Controller.getAdmin();
        }

        private void setValidasiTextBox()
        {
            if (txtNama.Text == "" || txtNamaPengguna.Text == "" || txtPassword.Text == "" ||
                    (cbPria.Checked == false) && (cbWanita.Checked == false))
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
                if (txtNama.Text == "" || txtNamaPengguna.Text == "" || txtPassword.Text == "" ||
                    (cbPria.Checked == false) && (cbWanita.Checked == false))
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        #endregion

        #region Method Update

        private void edit()
        {
            ea = new EntAdministrator();

            ea.Idadmin = receiveId;
            ea.Nama = txtNama.Text;

            if (cbPria.Checked == true)
            {
                select = "P";
            }

            if (cbWanita.Checked == true)
            {
                select = "W";
            }

            ea.Jekel = select;
            ea.Namapengguna = txtNamaPengguna.Text;
            ea.Passwordpengguna = txtPassword.Text;

            condition = ia.edit(ea, logTransactionEdit());

            if (condition)
            {
                setVisibleNotifikasiEditSucces();
            }
            else
            {
                message = "Data gagal diubah";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Validation Button Save

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cbPria_CheckedChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cbWanita_CheckedChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtNamaPengguna_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void btnSave_Click(object sender, EventArgs e)
        {
            edit();
            btnClose_Click(sender, e);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataAdministrator();
        }
    }
}
