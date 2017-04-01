using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.skp.kelola
{
    public partial class FrmViewDataSKP : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmViewDataSKP(string sendnama, string sendjabatan, Action<Form> viewForm1, string sendipaddress, 
                                FrmMenuClient frmmenuclient, FrmMenuKelola frmmenukelola)
        {
            InitializeComponent();
            InitializeFunction();

            this.sendnama = sendnama;
            this.sendjabatan = sendjabatan;
            this.viewForm1 = viewForm1;
            this.sendipaddress = sendipaddress;
            this.frmmenukelola = frmmenukelola;
            this.frmmenuclient = frmmenuclient;
        }

        #region All Function

        private void InitializeFunction()
        {
            startRemote();
            setVisibleNotifikasiEditDefault(true);
            setEnableButton(true);
            setVisibaleWorksheetDgv(true);
        }

        #region Setting

        private void setVisibaleWorksheetDgv(bool condition)
        {
            dgvSKP.Visible = !condition;
            btnCancel.Visible = !condition;
            btnEdit.Visible = !condition;
            btnDelete.Visible = !condition;
        }

        private void setEnableButton(bool condition)
        {
            btnCancel.Enabled = !condition;
            btnClose.Enabled = condition;
            btnEdit.Enabled = !condition;
            btnSeacrh.Enabled = condition;
            dtPeriodeAwal.Enabled = condition;
            dtPeriodeAkhir.Enabled = condition;
            btnDelete.Enabled = !condition;
        }

        private void setVisibleNotifikasiEditDefault(bool condition)
        {
            lblTextNotifikasi.Visible = !condition;
            panelNotifikasi.Visible = !condition;
            lblakhir.Visible = condition;
            lblawal.Visible = condition;
            dtPeriodeAkhir.Visible = condition;
            dtPeriodeAwal.Visible = condition;
            btnSeacrh.Visible = condition;
        }

        private void setVisibleNotifikasiEditSucces()
        {
            lblTextNotifikasi.Visible = true;
            panelNotifikasi.Visible = true;
            lblakhir.Visible = false;
            lblawal.Visible = false;
            dtPeriodeAkhir.Visible = false;
            dtPeriodeAwal.Visible = false;
            btnSeacrh.Visible = false;
        }

        private string setData()
        {
            data = DateTime.Now.ToString("dd/MM/yyyy") + "  " + DateTime.Now.ToString("hh:mm:ss") + "  " + "[" + "Delete SKP" + "]" + "" +
                    "" + "   " + sendipaddress + "   " + sendnama + "\n";

            return data;
        }

        private void setDataSKP()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = sendjabatan;
            elp.Periodeawal = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
            elp.Periodeakhir = dtPeriodeAkhir.Value.Date.ToString("yyyy-MM-dd");

            dgvSKP.DataSource = isk.selectSKP(elp);
        }

        private void setEnableForm(bool condition)
        {
            this.Enabled = !condition;
            frmmenuclient.Enabled = !condition;
            frmmenukelola.Enabled = !condition;
        }

        private void getDataDgv(DataGridViewCellEventArgs e)
        {
            try
            {
                sendperiodeawal.Text = dtPeriodeAwal.Value.Date.ToString("yyyy-MM-dd");
                id = Convert.ToInt32(dgvSKP[6, e.RowIndex].Value.ToString());
            }
            catch { }
        }

        #endregion

        #region Connected Method Remoting to Server

        private void startRemote()
        {
            client1 = new ThreadStart(setCreateSKPMethod);
            client2 = new Thread(client1);
            client2.Start();
        }

        private void setCreateSKPMethod()
        {
            obj = "SimkapSmartServer.ImpSasaranKerja";

            isk = (IntRemoteSasaranKerja)Activator.GetObject(typeof(IntRemoteSasaranKerja), setting.getUrl(obj));
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

        #region Display DGV SKP

        private void setHeaderDgvSKP()
        {
            dgvSKP.Columns[0].HeaderText = "Kegiatan";
            dgvSKP.Columns[1].HeaderText = "Kuantitas";
            dgvSKP.Columns[2].HeaderText = "Kualitas";
            dgvSKP.Columns[3].HeaderText = "Waktu";
            dgvSKP.Columns[4].HeaderText = "Satuan Waktu";
            dgvSKP.Columns[5].HeaderText = "Biaya";
            dgvSKP.Columns[6].Visible = false;

            setWidthDgvSKP();
        }

        private void setWidthDgvSKP()
        {
            dgvSKP.Columns[0].Width = 658;
            dgvSKP.Columns[1].Width = 80;
            dgvSKP.Columns[2].Width = 80;
            dgvSKP.Columns[3].Width = 80;
            dgvSKP.Columns[4].Width = 107;
            dgvSKP.Columns[5].Width = 120;

            formatDgv();
        }

        private void formatDgv()
        {
            dgvSKP.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvSKP.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvSKP.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvSKP.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dgvSKP.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight;

            dgvSKP.Columns[5].DefaultCellStyle.Format = "N2";
        }

        #endregion

        #region Method Delete

        private void delete()
        {
            esk = new EntSasaranKerja();
            etc = new EntRemoteTransactionClient();

            esk.Idsasarankerja = id;

            etc.Text = setData();

            condition = isk.delete(esk, etc);

            if (condition)
            {
                sendDataToServer();

                message = "Data berhasil di hapus";

                MessageBox.Show(message, "Informasi - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                setDataSKP();
            }
            else
            {
                message = "Data gagal di hapus";

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #endregion

        #region Event Button

        private void btnDelete_Click(object sender, EventArgs e)
        {
            message = "Apakah anda yakin ingin mengahpus data ini ?";

            if (MessageBox.Show(message, "Peringatan - SIMKAP 1.0.0",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                delete();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmUpdateSKP frm = new FrmUpdateSKP(sendperiodeawal, sendjabatan, sendipaddress, sendnama, setDataSKP, 
                                                    setVisibleNotifikasiEditSucces, frmmenukelola, frmmenuclient, this);
            frm.Show();

            setEnableForm(true);

            setVisibleNotifikasiEditDefault(true);
        }

        private void btnSeacrh_Click(object sender, EventArgs e)
        {
            try
            {
                setDataSKP();
                setHeaderDgvSKP();

                setVisibaleWorksheetDgv(false);

                this.WindowState = FormWindowState.Maximized;

            }
            catch (Exception ex)
            {
                message = "Terjadi kesalahan pada  : " + ex.Message;

                MessageBox.Show(message, "Pesan Kesalahan - SIMKAP 1.0.0",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                setVisibaleWorksheetDgv(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            setEnableButton(true);
            setVisibleNotifikasiEditDefault(true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            process = "Sasaran Kerja";

            FrmMenuKelola frm = new FrmMenuKelola(process, viewForm1, sendipaddress, sendnama, sendjabatan, frmmenuclient);
            viewForm1(frm);
        }

        #endregion

        #region Event DataGridView

        private void dgvSKP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private void dgvSKP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            getDataDgv(e);
            setEnableButton(false);
        }

        #endregion

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            setVisibleNotifikasiEditDefault(true);
        }
    }
}
