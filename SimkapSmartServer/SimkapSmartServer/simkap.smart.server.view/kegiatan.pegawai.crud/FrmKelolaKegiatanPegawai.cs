using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.kegiatan.pegawai.crud
{
    public partial class FrmKelolaKegiatanPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaKegiatanPegawai(string receiveIp, string receiveNama, Action setDataDetailKegiatanPegawai, FrmMenu frmMenu,
                                            FrmKegiatanPegawai frmKegiatanPegawai)
        {
            InitializeComponent();
            InitializeFunction();
                
            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setDataDetailKegiatanPegawai = setDataDetailKegiatanPegawai;
            this.frmMenu = frmMenu;
            this.frmKegiatanPegawai = frmKegiatanPegawai;
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodTambahDetailKegiatan();
            setCmbKegiatan();
            setCmbNama();

            cmbKegiatan.SelectedValue = "";
            cmbNama.SelectedValue = "";
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
            frmKegiatanPegawai.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodTambahDetailKegiatan()
        {
            idk = Controller.getDetailKegiatan();
        }

        private void clearData()
        {
            cmbKegiatan.SelectedValue = "";
            cmbNama.SelectedValue = "";

            panelNotifikasi.Focus();
        }

        private void setValidasiTextBox()
        {
            if (cmbNama.SelectedValue == null || cmbKegiatan.SelectedValue == null)
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
            cmbNama.DataSource = idk.setComboBox();
            cmbNama.DisplayMember = "nama";
            cmbNama.ValueMember = "nip";
        }

        private void setCmbKegiatan()
        {
            cmbKegiatan.DataSource = idk.setCmbKegiatan();
            cmbKegiatan.DisplayMember = "kegiatan";
            cmbKegiatan.ValueMember = "idkegiatan";
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Detail Kegiatan" + "]" +
                    "  " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert

        private void save()
        {
            edk = new EntDetailKegiatan();

            edk.Nip = cmbNama.SelectedValue.ToString();
            edk.Idkegiatan = cmbKegiatan.SelectedValue.ToString();


            condition = idk.save(edk, logTransactionSave());

            if (condition)
            {
                setVisibleNotifikasiSave(false);

                clearData();
            }
            else
            {
                message = "Data gagal disimpan";

                MessageBox.Show(message, "Pesan Kesalahan  - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Validation Button Save

        private void cmbNama_SelectedValueChanged_1(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cmbKegiatan_SelectedIndexChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and ComboBox

        private void cmbNama_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void FrmKelolaKegiatanPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataDetailKegiatanPegawai();
        }
    }
}
