using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.jenis.kegiatan.crud
{
    public partial class FrmKelolaJenisKegiatan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaJenisKegiatan(string receiveIp, string receiveNama, string sendIdJnsKegiatan, Action setVisibleNotifikasiEditSucces,
                                       string sendProcess, string sendJenis, Action setDataJenisKegiatan, FrmMenu frmMenu,
                                            FrmJenisKegiatan frmJenisKegiatan)
        {

            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.receiveProcess = sendProcess;
            this.setDataJenisKegiatan = setDataJenisKegiatan;
            this.frmMenu = frmMenu;
            this.frmJenisKegiatan = frmJenisKegiatan;

            if (sendProcess == "INSERT")
            {
                lblKeterangan.Text = "Tambah Jenis Kegiatan";
            }
            else
            {
                lblKeterangan.Text = "Ubah Jenis Kegiatan";
                receiveIdJenis = sendIdJnsKegiatan;
                txtJenis.Text = sendJenis;
            }
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodJenisKegiatan();
        }

        #region Setting

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Jenis Kegiatan" + "]" + "" +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private string logTransactionEdit()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Jenis Kegiatan" + "]" + "  " +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

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
            frmJenisKegiatan.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodJenisKegiatan()
        {
            ijk = Controller.getJenisKegiatan();
        }

        private void setValidasiTextBox()
        {
            if (txtJenis.Text == "")
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
                if (txtJenis.Text == "")
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
            txtJenis.ResetText();

            panelNotifikasi.Focus();
        }

        #endregion

        #region Method Insert and Update

        private void getEntity()
        {
            ejk = new EntJenisKegiatan();

            ejk.Idjenis = receiveIdJenis;
            ejk.Jenis = txtJenis.Text;
        }

        private void save()
        {
            getEntity();

            condition = ijk.save(ejk, logTransactionSave());

            if (condition == true)
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

        private void edit()
        {
            getEntity();

            condition = ijk.edit(ejk, logTransactionEdit());

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

        private void txtJenis_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (receiveProcess.Equals("INSERT", StringComparison.InvariantCultureIgnoreCase))
            {
                save();
            }
            else
            {
                edit();
                btnClose_Click(sender, e);
            }
        }

        private void txtJenis_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void txtJenis_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaJenisKegiatan_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataJenisKegiatan();
        }
    }
}
