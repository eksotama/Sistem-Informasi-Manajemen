using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.kegiatan.crud
{
    public partial class FrmKelolaKegiatan : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaKegiatan(Action setVisibleNotifikasiEditSucces, string receiveIp, string receiveNama, string sendIdKegiatan, 
                                 string sendKegiatan, string sendOutput, string sendSatuan, string sendJenis,  string sendProcess, 
                                 string sendStatus, string sendKeterangan, Action setDataKegiatan, FrmMenu frmMenu, 
                                 FrmKegiatan frmKegiatan)
        {

            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.setDataKegiatan = setDataKegiatan;
            this.frmMenu = frmMenu;
            this.frmKegiatan = frmKegiatan;
            receiveProcess = sendProcess;

            if (sendProcess == "INSERT")
            {
                lblKeterangan.Text = "Tambah Kegiatan";
            }
            else
            {
                lblKeterangan.Text = "Ubah Kegiatan";

                receiveIdKegiatan = sendIdKegiatan;
                txtKegiatan.Text = sendKegiatan;
                txtOutput.Text = sendOutput;
                cmbSatuan.SelectedItem = sendSatuan;
                cmbStatus.SelectedItem = sendStatus;
                cmbKeterangan.SelectedItem = sendKeterangan;
                cmbJenis.SelectedValue = sendJenis;

                txtKegiatan.Cursor = Cursors.No;
                txtKegiatan.ReadOnly = true;

                this.toolTip1.SetToolTip(this.txtKegiatan, "Kegiatan tidak bisa diubah");
            }
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodKegiatan();
            setCmbJenis();
            setCmbSatuan();
            setCmbSattus();
            setCmbKeterangan();

            cmbJenis.SelectedValue = "";
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
            frmKegiatan.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setMethodKegiatan()
        {
            ik = Controller.getKegiatan();
            ijk = Controller.getJenisKegiatan();
        }

        private void clearData()
        {
            txtKegiatan.ResetText();
            txtOutput.Text = "";
            cmbJenis.SelectedValue = "";
            cmbSatuan.SelectedItem = null;
            cmbKeterangan.SelectedItem = null;
            cmbStatus.SelectedItem = null;

            panelNotifikasi.Focus();
        }

        private void setValidasiTextBox()
        {
            if (txtKegiatan.Text == "" || txtOutput.Text == "" || cmbJenis.SelectedValue == null || cmbSatuan.SelectedItem == null 
                       || cmbStatus.SelectedItem == null || cmbKeterangan.SelectedItem == null)
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
                if (txtKegiatan.Text == "" || txtOutput.Text == "" || cmbJenis.SelectedValue == null || cmbSatuan.SelectedItem == null
                       || cmbStatus.SelectedItem == null || cmbKeterangan.SelectedItem == null)
                {
                    //...
                }
                else
                {
                    btnSave_Click(sender, e);
                }
            }
        }

        private void setCmbSatuan()
        {
            cmbSatuan.Items.Add("Dokumen");
            cmbSatuan.Items.Add("Data");
            cmbSatuan.Items.Add("Lembar");
            cmbSatuan.Items.Add("Peristiwa");
            cmbSatuan.Items.Add("Buku");
            cmbSatuan.Items.Add("Pasang");
            cmbSatuan.Items.Add("Kegiatan");
            cmbSatuan.Items.Add("Berkas");
        }

        private void setCmbSattus()
        {
            cmbStatus.Items.Add("Sinkron");
            cmbStatus.Items.Add("Tidak Sinkron");
        }

        private void setCmbKeterangan()
        {
            cmbKeterangan.Items.Add("Sinkron I");
            cmbKeterangan.Items.Add("Sinkron II");
            cmbKeterangan.Items.Add("Sinkron III");
            cmbKeterangan.Items.Add("Tidak Sinkron");
        }

        private void setCmbJenis()
        {
            cmbJenis.DataSource = ijk.selectJenisKegiatan();
            cmbJenis.DisplayMember = "jenis";
            cmbJenis.ValueMember = "idjenis";
        }

        private string logTransactionEdit()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Kegiatan" + "]" + "  " +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Kegiatan" + "]" + "" +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert and Update

        private void getEntity()
        {
            ek = new EntKegiatan();

            ek.Idkegiatan = receiveIdKegiatan;
            ek.Kegiatan = txtKegiatan.Text;
            ek.Idjenis = cmbJenis.SelectedValue.ToString();
            ek.Outputkegiatan = txtOutput.Text;
            ek.Satuan = cmbSatuan.SelectedItem.ToString();
            ek.Status = cmbStatus.SelectedItem.ToString();
            ek.Keterangan = cmbKeterangan.SelectedItem.ToString();
        }

        private void saveKegiatan()
        {
            getEntity();

            validation = ik.validationInsert(ek);

            if (validation)
            {
                message = "Kegiatan " + txtKegiatan.Text + " sudah ada";

                MessageBox.Show(message, "Infromasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                condition = ik.save(ek, logTransactionSave());

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

        private void editKegiatan()
        {
            getEntity();

            condition = ik.edit(ek, logTransactionEdit());

            if (condition == true)
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

        private void cmbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cmbKeterangan_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtKegiatan_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cmbJenis_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void cmbSatuan_SelectedValueChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void txtOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void txtKegiatan_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (receiveProcess.Equals("INSERT", StringComparison.InvariantCultureIgnoreCase))
            {
                saveKegiatan();
            }
            else
            {
                editKegiatan();
                btnClose_Click(sender, e);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaKegiatan_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataKegiatan();
        }
    }
}
