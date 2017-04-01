using System;
using System.Windows.Forms;
using SimkapSmartServer.simkap.smart.server.control;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartServer.simkap.smart.server.view.unit.kerja.crud
{
    public partial class FrmKelolaUnitKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmKelolaUnitKerja(Action setVisibleNotifikasiEditSucces, string receiveIp, string receiveNama, string sendProcess,
                                    string sendUnitKerja, string sendIdUnit, string sendAlamatUnit, Action setDataUnitKerja,
                                        FrmMenu frmMenu, FrmUnitKerja frmUnitKerja)
        {

            InitializeComponent();
            InitializeFunction();

            this.receiveIp = receiveIp;
            this.receiveNama = receiveNama;
            this.receiveProcess = sendProcess; ;
            this.setVisibleNotifikasiEditSucces = setVisibleNotifikasiEditSucces;
            this.setDataUnitKerja = setDataUnitKerja;
            this.frmMenu = frmMenu;
            this.frmUnitKerja = frmUnitKerja;

            if (sendProcess == "INSERT")
            {
                lblKeterangan.Text = "Kelola Unit Kerja";
            }
            else
            {
                lblKeterangan.Text = "Ubah Unit Kerja";
                receiveId = sendIdUnit;
                txtUnitKerja.Text = sendUnitKerja;
                txtAlamat.Text = sendAlamatUnit;
            }
        }

        #region All Function

        private void InitializeFunction()
        {
            setVisibleNotifikasiSave(true);
            setEnableButton(true);
            setMethodUnitKerja();
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
            frmUnitKerja.Enabled = !condition;
            frmMenu.Enabled = !condition;
        }

        private void setValidasiTextBox()
        {
            if (txtUnitKerja.Text == "" || txtAlamat.Text == "")
            {
                setEnableButton(true);
            }
            else
            {
                setEnableButton(false);
            }
        }

        private void setMethodUnitKerja()
        {
            iuk = Controller.getUnitKerja();
        }

        private void setEventEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtUnitKerja.Text == "" || txtAlamat.Text == "")
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
            txtUnitKerja.ResetText();
            txtAlamat.ResetText();

            panelNotifikasi.Focus();
        }

        private string logTransactionSave()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Insert Unit Kerja" + "]" + "" +
                  "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        private string logTransactionUpdate()
        {
            log = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Update Unit Kerja" + "]" + "  " +
                    "" + "   " + receiveIp + "   " + receiveNama;

            return log;
        }

        #endregion

        #region Method Insert and Update

        private void getEntity()
        {
            euk = new EntUnitKerja();

            euk.Idunit = receiveId;
            euk.Unitkerja = txtUnitKerja.Text;
            euk.Alamatunit = txtAlamat.Text;
        }

        private void saveUnitKerja()
        {
            getEntity();

            condition = iuk.save(euk, logTransactionUpdate());

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

        private void editUnitKerja()
        {
            getEntity();

            condition = iuk.edit(euk, log);

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

        #region Vadlidation Button Save

        private void txtUnitKerja_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            setValidasiTextBox();
        }

        #endregion

        #region Event Button and TextBox

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            setEventEnter(e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (receiveProcess.Equals("INSERT", StringComparison.InvariantCultureIgnoreCase))
            {
                saveUnitKerja();
            }
            else
            {
                editUnitKerja();
                btnClose_Click(sender, e);
            }
        }

        private void txtUnitKerja_Click(object sender, EventArgs e)
        {
            setVisibleNotifikasiSave(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            setEnableForm(false);
        }

        #endregion

        private void FrmKelolaUnitKerja_FormClosing(object sender, FormClosingEventArgs e)
        {
            setEnableForm(false);
            setDataUnitKerja();
        }
    }
}

