using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.skp.kelola
{
    public partial class FrmInformationSKP : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmInformationSKP(Action<Form> viewForm1, string sendjabatan, string sendipaddress, string sendnama)
        {
            InitializeComponent();
            InitializeFunction();

            this.viewForm1 = viewForm1;
            this.sendjabatan = sendjabatan;
            this.sendnama = sendnama;
            this.sendipaddress = sendipaddress;
        }

        #region All Function

        public void InitializeFunction()
        {
            startRemote();

            periode = DateTime.Now.ToString("yyyy") + "/01/01";
        }

        #region Setting

        private void setDataInformation()
        {
            elp = new EntLoginPegawai();

            elp.Jabatan = sendjabatan;
            elp.Periodeawal = periode;

            dgvInformationSKP.DataSource = isk.selectInformationSKP(elp);
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
            server = "127.0.0.1";
            port = "1001";

            uri = "SimkapSmartServer.ImpSasaranKerja";
            url = "tcp://" + server + ":" + port + "/" + uri;

            isk = (IntRemoteSasaranKerja)Activator.GetObject(typeof(IntRemoteSasaranKerja), url);
        }

        #endregion

        #region Display DGV SKP

        private void setHeaderDgvInformation()
        {
            dgvInformationSKP.Columns[0].HeaderText = "Kegiatan";
            dgvInformationSKP.Columns[1].HeaderText = "Jenis Kegiatan";

            setWidthDgvInformation();
        }

        private void setWidthDgvInformation()
        {
            dgvInformationSKP.Columns[0].Width = 673;
            dgvInformationSKP.Columns[1].Width = 210;

            dgvInformationSKP.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
        }

        #endregion

        #endregion

        #region Event Button

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmSasaranKerja frm = new FrmSasaranKerja(viewForm1, sendipaddress, sendnama, sendjabatan, frmmenuclient);
            viewForm1(frm);
        }

        #endregion

        #region Event DataGridView

        private void dgvInformationSKP_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        #endregion

        private void FrmInformationSKP_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void dgvInformationSKP_MouseMove(object sender, MouseEventArgs e)
        {
            setDataInformation();
            setHeaderDgvInformation();
        }
    }
}
