using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja
{
    public partial class FrmDataPrilakuKerja : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmDataPrilakuKerja(Action<Form> viewForm, string sendIpAddress, string sendNama, string sendJabatan, 
                                    FrmMenuClient frmmenuclient, FrmMenuKelola frmmenukelola)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm = viewForm;
            this.sendIpAddress = sendIpAddress;
            this.sendNama = sendNama;
            this.sendJabatan = sendJabatan;
            this.frmmenuclient = frmmenuclient;
            this.frmmenukelola = frmmenukelola;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(true);
            setVisibleWorkSheet(true);
            setEnableButtonSeacrh(true);
        }

        #region Setting

        private void setEnableButtonSeacrh(bool condition)
        {
            btnSearch.Enabled = !condition;
        }

        private void setVisibleWorkSheet(bool condition)
        {
            dgvDataPrilakuKerja.Visible = !condition;
            btnCancel.Visible = !condition;
            btnEdit.Visible = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnCancel.Enabled = !condition;
            btnClose.Enabled = condition;
            btnEdit.Enabled = !condition;
            btnSearch.Enabled = condition;
            dtPeriodeAwal.Enabled = condition;
            dtPeriodeAkhir.Enabled = condition;
        }

        private void setVisibleNotifikasiEditDefault(bool condition)
        {
            lblTextNotifikasi.Visible = !condition;
            panelNotifikasi.Visible = !condition;
            lblakhir.Visible = condition;
            lblawal.Visible = condition;
            dtPeriodeAkhir.Visible = condition;
            dtPeriodeAwal.Visible = condition;
            btnSearch.Visible = condition;
        }

        private void setVisibleNotifikasiEditSucces()
        {
            lblTextNotifikasi.Visible = true;
            panelNotifikasi.Visible = true;

            lblakhir.Visible = false;
            lblawal.Visible = false;
            dtPeriodeAkhir.Visible = false;
            dtPeriodeAwal.Visible = false;
            btnSearch.Visible = false;
        }

        private void setDataPrilakuKerja()
        {
            epk = new EntPrilakukerja();

            epk.Jabatan = sendJabatan;
            epk.Periodeawal = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
            epk.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");

            dgvDataPrilakuKerja.DataSource = ipl.selectPrilakuKerja(epk);
        }

        private void setEnableForm(bool condition)
        {
            this.Enabled = !condition;
            frmmenuclient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
        }

        private void getDataEditDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendIdPrilaku = Convert.ToInt32(dgvDataPrilakuKerja[8, e.RowIndex].Value.ToString());
                sendOrientasi = Convert.ToDouble(dgvDataPrilakuKerja[0, e.RowIndex].Value.ToString());
                sendIntegritas = Convert.ToDouble(dgvDataPrilakuKerja[1, e.RowIndex].Value.ToString());
                sendKomitmen = Convert.ToDouble(dgvDataPrilakuKerja[2, e.RowIndex].Value.ToString());
                sendDisiplin = Convert.ToDouble(dgvDataPrilakuKerja[3, e.RowIndex].Value.ToString());
                sendKerjasama = Convert.ToDouble(dgvDataPrilakuKerja[4, e.RowIndex].Value.ToString());
                sendKepemimpinan = Convert.ToDouble(dgvDataPrilakuKerja[4, e.RowIndex].Value.ToString());
                sendJumlah = Convert.ToDouble(dgvDataPrilakuKerja[6, e.RowIndex].Value.ToString());
                sendNilaiRata = Convert.ToDouble(dgvDataPrilakuKerja[7, e.RowIndex].Value.ToString());
            }
            catch { }
        }

        private void setValidationButton()
        {
            if (dtPeriodeAkhir.Value == null)
            {
                setEnableButtonSeacrh(true);
            }
            else
            {
                setEnableButtonSeacrh(false);
            }
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreatePrilakuKerjaMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreatePrilakuKerjaMethod()
        {
            obj = "SimkapSmartServer.ImpPrilakuKerja";

            ipl = (IntRemotePrilakuKerja)Activator.GetObject(typeof(IntRemotePrilakuKerja), setting.getUrl(obj));
        }

        #endregion

        #region Display DGV

        private void setHeaderDgvPrilakuKerja()
        {
            dgvDataPrilakuKerja.Columns[0].HeaderText = "Orientasi Pelayanan";
            dgvDataPrilakuKerja.Columns[1].HeaderText = "Integritas";
            dgvDataPrilakuKerja.Columns[2].HeaderText = "Komitmen";
            dgvDataPrilakuKerja.Columns[3].HeaderText = "Displin";
            dgvDataPrilakuKerja.Columns[4].HeaderText = "Kerjasama";
            dgvDataPrilakuKerja.Columns[5].HeaderText = "Kepemimpinan";
            dgvDataPrilakuKerja.Columns[6].HeaderText = "Jumlah";
            dgvDataPrilakuKerja.Columns[7].HeaderText = "Nilai Rata-rata";
            dgvDataPrilakuKerja.Columns[8].Visible = false;

            setWidthDgvPrilakuKerja();
        }

        private void setWidthDgvPrilakuKerja()
        {
            dgvDataPrilakuKerja.Columns[0].Width = 120;
            dgvDataPrilakuKerja.Columns[1].Width = 100;
            dgvDataPrilakuKerja.Columns[2].Width = 100;
            dgvDataPrilakuKerja.Columns[3].Width = 100;
            dgvDataPrilakuKerja.Columns[4].Width = 100;
            dgvDataPrilakuKerja.Columns[5].Width = 100;
            dgvDataPrilakuKerja.Columns[6].Width = 100;
            dgvDataPrilakuKerja.Columns[7].Width = 121;

            dgvDataPrilakuKerja.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvDataPrilakuKerja.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #endregion

        #region Validation Button

        private void dtPeriodeAkhir_ValueChanged(object sender, EventArgs e)
        {
            setValidationButton();
        }

        #endregion

        #region Event Button and Date Input

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmUpdatePrilakuKerja frm = new FrmUpdatePrilakuKerja(sendIdPrilaku, sendOrientasi, sendIntegritas, sendKomitmen,
                                                         sendDisiplin, sendKerjasama, sendKepemimpinan, sendJumlah, sendNilaiRata,
                                                         sendJabatan, sendIpAddress, sendNama, setDataPrilakuKerja,
                                                        setVisibleNotifikasiEditSucces, frmmenukelola, frmmenuclient, this);
            frm.Show();

            setEnableForm(true);
            setVisibleNotifikasiEditDefault(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                setDataPrilakuKerja();
                setHeaderDgvPrilakuKerja();
                setVisibleWorkSheet(false);

                this.WindowState = FormWindowState.Maximized;
            }
            catch
            {
                message = "Koneksi server terputus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Perilaku Kerja";

            FrmMenuKelola frm = new FrmMenuKelola(process, viewForm, sendIpAddress, sendNama, sendJabatan, frmmenuclient);
            viewForm(frm);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
            setVisibleNotifikasiEditDefault(true);
        }

        #endregion

        #region Event DataGridView

        private void dgvDataPrilakuKerja_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            #region "Auto Number DataGridView"

            dg = (DataGridView)sender;
            string rowNumber = (e.RowIndex + 1).ToString();

            while (rowNumber.Length < dg.RowCount.ToString().Length) rowNumber = "0" + rowNumber;

            size = e.Graphics.MeasureString(rowNumber, this.Font);
            if (dg.RowHeadersWidth < (int)(size.Width + 20)) dg.RowHeadersWidth = (int)(size.Width + 20);

            b = SystemBrushes.ControlText;

            e.Graphics.DrawString(rowNumber, dg.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y +
                ((e.RowBounds.Height - size.Height) / 2));

            #endregion
        }

        private void dgvDataPrilakuKerja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataEditDgv(e);
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(false);
        }

        #endregion
    }
}
