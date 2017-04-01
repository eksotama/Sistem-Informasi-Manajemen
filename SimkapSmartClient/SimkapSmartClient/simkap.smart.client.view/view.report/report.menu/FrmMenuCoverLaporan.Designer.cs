using SimkapSmartClient.simkap.smart.client.setting.app;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.menu
{
    partial class FrmMenuCoverLaporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCoverLaporan));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtCoverDepan = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtDataPenilai = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtClose = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemPanel1.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemPanel1.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemPanel1.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1,
            this.itemContainer2});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(42, 113);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(367, 187);
            this.itemPanel1.TabIndex = 31;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mtCoverDepan,
            this.mtDataPenilai});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtCoverDepan
            // 
            this.mtCoverDepan.Image = global::SimkapSmartClient.Properties.Resources.LAP_DEPAN;
            this.mtCoverDepan.Name = "mtCoverDepan";
            this.mtCoverDepan.SymbolColor = System.Drawing.Color.Empty;
            this.mtCoverDepan.Text = "Cover Depan";
            this.mtCoverDepan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mtCoverDepan.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtCoverDepan.TitleText = "Halaman Depan Laporan";
            this.mtCoverDepan.Click += new System.EventHandler(this.mtCoverDepan_Click);
            // 
            // mtDataPenilai
            // 
            this.mtDataPenilai.Image = global::SimkapSmartClient.Properties.Resources.LAP_PEGAWAI;
            this.mtDataPenilai.Name = "mtDataPenilai";
            this.mtDataPenilai.SymbolColor = System.Drawing.Color.Empty;
            this.mtDataPenilai.Text = "Data Pegawai";
            this.mtDataPenilai.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.mtDataPenilai.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtDataPenilai.TitleText = "Halaman Data Pegawai";
            this.mtDataPenilai.Click += new System.EventHandler(this.mtDataPenilai_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mtClose});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtClose
            // 
            this.mtClose.Image = global::SimkapSmartClient.Properties.Resources.LAP_PERIODE;
            this.mtClose.Name = "mtClose";
            this.mtClose.SymbolColor = System.Drawing.Color.Empty;
            this.mtClose.Text = "Pilih Periode";
            this.mtClose.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.mtClose.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtClose.TitleText = "Keluar";
            this.mtClose.Click += new System.EventHandler(this.mtClose_Click);
            // 
            // reflectionLabel1
            // 
            this.reflectionLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.reflectionLabel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel1.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel1.Location = new System.Drawing.Point(42, 37);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(367, 70);
            this.reflectionLabel1.TabIndex = 30;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Cover Laporan</font></font></b>";
            // 
            // FrmMenuCoverLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 337);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuCoverLaporan";
            this.Text = "Menu Cover Laporan - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenuCoverLaporan_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtCoverDepan;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtDataPenilai;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtClose;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;

        #region Variabel

        private string sendJabatan;
        private string sendPeriodeAwal;
        private string sendPeriodeAkhir;
        private Action<Form> viewForm;
        private string procces;
        private string status;
        private string message;
        private bool condition;
        private SettingIpAddress setting = new SettingIpAddress();
        private IntRemoteValidationReport ir;
        private EntLaporan el;
        private ThreadStart client1;
        private Thread client2;
        private string obj;
        private bool execute;
        private string tanggal;
        private string periodeawalmutasi;
        private string periodeakhirmutasi;

        #endregion
    }
}