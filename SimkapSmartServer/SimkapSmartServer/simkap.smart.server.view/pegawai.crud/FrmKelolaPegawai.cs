using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.pegawai.crud
{
    public partial class FrmKelolaPegawai : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaPegawai(string sendProcess, string receiveIp, string receiveNama, string sendNip, string sendNama,
                                string sendPagolru, string sendUnitKerja, string sendJabatan, string sendKeterangan,
                                Action setVisibleNotifikasiEditSucces, Action setDataPegawai,
                                FrmMenu frmMenu, FrmPegawai frmPegawai)
        {

            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.setDataPegawai = setDataPegawai;
            this.frmMenu = frmMenu;
            this.frmPegawai = frmPegawai;
            receiveProcess = sendProcess;

            if (sendProcess == "INSERT")
            {
                lblKeterangan.Text = "Tambah Pegawai";
            }
            else
            {
                txtJabatan.Visible = false;
                labelX1.Visible = false;

                lblKeterangan.Text = "Ubah Pegawai";
                txtNip.Text = sendNip;
                txtNama.Text = sendNama;
                txtPangkat.Text = sendPagolru;
                txtJabatan.Text = sendJabatan;
                cmbKeterangan.SelectedItem = sendKeterangan;
                cmbUnitKerja.SelectedValue = sendUnitKerja;
            }
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodPegawai();
            setCmbKeterangan();
            setCmbUnit();

            cmbUnitKerja.SelectedValue = "";
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
            frmPegawai.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodPegawai()
        {
            ip = Controller.getPegawai();
            iuk = Controller.getUnitKerja();
        }

        private void setValidasiTextBox()
        {
            if (txtNama.Text == "" || txtPangkat.Text == "" || txtJabatan.Text == "" || cmbUnitKerja.SelectedItem == null || 
                cmbKeterangan.SelectedItem == null)
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
                if (txtNama.Text == "" || txtPangkat.Text == "" || txtJabatan.Text == "" || cmbUnitKerja.SelectedItem == null || 
                        cmbKeterangan.SelectedItem == null)
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void setCmbUnit()
        {
            cmbUnitKerja.DataSource = iuk.selectUnitKerja();
            cmbUnitKerja.DisplayMember = "unit";
            cmbUnitKerja.ValueMember = "idunit";
        }

        private void setCmbKeterangan()
        {
            cmbKeterangan.Items.Add("Pegawai KUA KEC. Klaten Selatan");
            cmbKeterangan.Items.Add("Lainnya");
        }

        private void clearData()
        {
            txtNip.ResetText();
            txtNama.ResetText();
            txtPangkat.ResetText();
            txtJabatan.ResetText();
            cmbUnitKerja.SelectedValue = "";
            cmbKeterangan.SelectedItem = null;

            panelNotifikasi.Focus();
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Pegawai" + "]" + " " +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private string logTransactionEdit()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Pegawai" + "]" +
                    "   " + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert and Update

        private void getEntity()
        {
            ep = new EntPegawai();

            ep.Nip = txtNip.Text;
            ep.Nama = txtNama.Text;
            ep.Pagolru = txtPangkat.Text;
            ep.Jabatan = txtJabatan.Text;
            ep.Idunit = cmbUnitKerja.SelectedValue.ToString();
            ep.Keterangan = cmbKeterangan.SelectedItem.ToString();
        }

        private void save()
        {
            getEntity();

            validation = ip.validationInsert(ep);

            if (validation)
            {
                message = "Sudah ada pegawai dengan jabatan " + txtJabatan.Text;

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = ip.save(ep, logTransactionSave());

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

        private void edit()
        {
            getEntity();

            condition = ip.edit(ep, logTransactionEdit());

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

        private void cmbKeterangan_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtNip_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtPangkat_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtJabatan_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cmbUnitKerja_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button, TextBox and ComboBox

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

        private void txtNama_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        private void txtJabatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        #endregion

        private void FrmKelolaPegawai_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataPegawai();
        }
    }
}
