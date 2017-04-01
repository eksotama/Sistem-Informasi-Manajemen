using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmMenuClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuClient));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.itemPanel2 = new DevComponents.DotNetBar.ItemPanel();
            this.SKP = new DevComponents.DotNetBar.ControlContainerItem();
            this.metroTileItem5 = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.labelItem4 = new DevComponents.DotNetBar.LabelItem();
            this.metroStatusBar1 = new DevComponents.DotNetBar.Metro.MetroStatusBar();
            this.labelItem5 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem6 = new DevComponents.DotNetBar.LabelItem();
            this.lblDate = new DevComponents.DotNetBar.LabelItem();
            this.labelItem7 = new DevComponents.DotNetBar.LabelItem();
            this.lblTime = new DevComponents.DotNetBar.LabelItem();
            this.labelItem10 = new DevComponents.DotNetBar.LabelItem();
            this.lblIpAddress = new DevComponents.DotNetBar.LabelItem();
            this.labelItem8 = new DevComponents.DotNetBar.LabelItem();
            this.lblHostName = new DevComponents.DotNetBar.LabelItem();
            this.lblJabatan = new DevComponents.DotNetBar.LabelItem();
            this.labelItem9 = new DevComponents.DotNetBar.LabelItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemPanel3 = new DevComponents.DotNetBar.ItemPanel();
            this.lblNama = new DevComponents.DotNetBar.ButtonItem();
            this.btnChangePassword = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.LBL = new DevComponents.DotNetBar.LabelItem();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.labelItem2 = new DevComponents.DotNetBar.LabelItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mtLapLCKH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtSKP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLCKH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtRealisasi = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtUkurSasaran = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLPrilakuKerja = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLaporan = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPanel1
            // 
            this.itemPanel1.BackColor = System.Drawing.Color.Black;
            this.itemPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // 
            // 
            this.itemPanel1.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel1.ContainerControlProcessDialogKey = true;
            this.itemPanel1.Controls.Add(this.pictureBox2);
            this.itemPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.itemPanel1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1});
            this.itemPanel1.Location = new System.Drawing.Point(0, 0);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(966, 82);
            this.itemPanel1.TabIndex = 0;
            this.itemPanel1.Text = "itemPanel1";
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // itemPanel2
            // 
            // 
            // 
            // 
            this.itemPanel2.BackgroundStyle.Class = "ItemPanel";
            this.itemPanel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel2.ContainerControlProcessDialogKey = true;
            this.itemPanel2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.SKP});
            this.itemPanel2.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel2.Location = new System.Drawing.Point(0, 116);
            this.itemPanel2.Name = "itemPanel2";
            this.itemPanel2.Size = new System.Drawing.Size(200, 388);
            this.itemPanel2.TabIndex = 1;
            this.itemPanel2.Text = "itemPanel2";
            // 
            // SKP
            // 
            this.SKP.AllowItemResize = false;
            this.SKP.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.SKP.Name = "SKP";
            // 
            // metroTileItem5
            // 
            this.metroTileItem5.GlobalItem = false;
            this.metroTileItem5.Name = "metroTileItem5";
            this.metroTileItem5.SymbolColor = System.Drawing.Color.Empty;
            this.metroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Default;
            // 
            // 
            // 
            this.metroTileItem5.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // labelItem4
            // 
            this.labelItem4.BackColor = System.Drawing.SystemColors.Menu;
            this.labelItem4.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem4.Font = new System.Drawing.Font("HighlandGothicFLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelItem4.Name = "labelItem4";
            this.labelItem4.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelItem4.Stretch = true;
            this.labelItem4.Text = "MENU";
            this.labelItem4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // metroStatusBar1
            // 
            // 
            // 
            // 
            this.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.metroStatusBar1.ContainerControlProcessDialogKey = true;
            this.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroStatusBar1.Font = new System.Drawing.Font("Segoe UI", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroStatusBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem5,
            this.labelItem6,
            this.lblDate,
            this.labelItem7,
            this.lblTime,
            this.labelItem10,
            this.lblIpAddress,
            this.labelItem8,
            this.lblHostName,
            this.lblJabatan,
            this.labelItem9});
            this.metroStatusBar1.Location = new System.Drawing.Point(0, 707);
            this.metroStatusBar1.Name = "metroStatusBar1";
            this.metroStatusBar1.Size = new System.Drawing.Size(966, 22);
            this.metroStatusBar1.TabIndex = 3;
            this.metroStatusBar1.Text = "metroStatusBar1";
            // 
            // labelItem5
            // 
            this.labelItem5.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem5.Name = "labelItem5";
            this.labelItem5.Symbol = "";
            this.labelItem5.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelItem5.Text = "Terhubung ke server";
            // 
            // labelItem6
            // 
            this.labelItem6.Name = "labelItem6";
            this.labelItem6.Text = "                    ";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Name = "lblDate";
            this.lblDate.Text = "tanggal";
            // 
            // labelItem7
            // 
            this.labelItem7.Name = "labelItem7";
            this.labelItem7.Text = "|";
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Name = "lblTime";
            this.lblTime.Text = "jam";
            // 
            // labelItem10
            // 
            this.labelItem10.Name = "labelItem10";
            this.labelItem10.Stretch = true;
            this.labelItem10.Text = "                    ";
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Text = "ip address";
            // 
            // labelItem8
            // 
            this.labelItem8.Name = "labelItem8";
            this.labelItem8.Text = "|";
            // 
            // lblHostName
            // 
            this.lblHostName.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Stretch = true;
            this.lblHostName.Text = "host name";
            // 
            // lblJabatan
            // 
            this.lblJabatan.Name = "lblJabatan";
            this.lblJabatan.Stretch = true;
            this.lblJabatan.Text = "jabatan";
            // 
            // labelItem9
            // 
            this.labelItem9.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem9.Name = "labelItem9";
            this.labelItem9.Text = "Versi 1.0.0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.itemPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 625);
            this.panel1.TabIndex = 4;
            // 
            // itemPanel3
            // 
            this.itemPanel3.BackColor = System.Drawing.SystemColors.Menu;
            // 
            // 
            // 
            this.itemPanel3.BackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.itemPanel3.BackgroundStyle.BackColorGradientAngle = 90;
            this.itemPanel3.BackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.itemPanel3.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel3.BackgroundStyle.BorderBottomWidth = 1;
            this.itemPanel3.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.itemPanel3.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel3.BackgroundStyle.BorderLeftWidth = 1;
            this.itemPanel3.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel3.BackgroundStyle.BorderRightWidth = 1;
            this.itemPanel3.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.itemPanel3.BackgroundStyle.BorderTopWidth = 1;
            this.itemPanel3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemPanel3.ContainerControlProcessDialogKey = true;
            this.itemPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemPanel3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.lblNama,
            this.LBL,
            this.mtSKP,
            this.mtLCKH,
            this.mtRealisasi,
            this.mtUkurSasaran,
            this.mtLPrilakuKerja,
            this.labelItem2,
            this.mtLaporan});
            this.itemPanel3.ItemTemplate = this.metroTileItem5;
            this.itemPanel3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel3.Location = new System.Drawing.Point(0, 0);
            this.itemPanel3.Name = "itemPanel3";
            this.itemPanel3.ScrollBarAppearance = DevComponents.DotNetBar.eScrollBarAppearance.ApplicationScroll;
            this.itemPanel3.Size = new System.Drawing.Size(182, 623);
            this.itemPanel3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.itemPanel3.TabIndex = 3;
            this.itemPanel3.Text = "itemPanel3";
            // 
            // lblNama
            // 
            this.lblNama.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.lblNama.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.lblNama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNama.FontBold = true;
            this.lblNama.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblNama.HotFontBold = true;
            this.lblNama.Name = "lblNama";
            this.lblNama.PopupFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnChangePassword,
            this.btnClose});
            this.lblNama.Symbol = "";
            this.lblNama.Text = "    buttonItem1";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnChangePassword.FontBold = true;
            this.btnChangePassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.PopupFont = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnChangePassword.Symbol = "";
            this.btnChangePassword.Text = "Ganti Kata Sandi";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.FontBold = true;
            this.btnClose.Name = "btnClose";
            this.btnClose.PopupFont = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Symbol = "";
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // LBL
            // 
            this.LBL.BackColor = System.Drawing.SystemColors.Menu;
            this.LBL.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.LBL.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LBL.Name = "LBL";
            this.LBL.SingleLineColor = System.Drawing.Color.Transparent;
            this.LBL.Stretch = true;
            this.LBL.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItem1});
            this.LBL.Text = "MENU";
            this.LBL.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelItem1
            // 
            this.labelItem1.BackColor = System.Drawing.SystemColors.Menu;
            this.labelItem1.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem1.Font = new System.Drawing.Font("HighlandGothicFLF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelItem1.Name = "labelItem1";
            this.labelItem1.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelItem1.Stretch = true;
            this.labelItem1.Text = "MENU";
            this.labelItem1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelItem2
            // 
            this.labelItem2.BackColor = System.Drawing.SystemColors.Menu;
            this.labelItem2.BorderType = DevComponents.DotNetBar.eBorderType.Raised;
            this.labelItem2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelItem2.Name = "labelItem2";
            this.labelItem2.Text = "LAPORAN";
            this.labelItem2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(184, 82);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel2.BackgroundImage")));
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Size = new System.Drawing.Size(782, 625);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 5;
            // 
            // mtLapLCKH
            // 
            this.mtLapLCKH.Name = "mtLapLCKH";
            this.mtLapLCKH.SymbolColor = System.Drawing.Color.Empty;
            this.mtLapLCKH.Text = " SKP dan LCKH";
            this.mtLapLCKH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue;
            this.mtLapLCKH.TileSize = new System.Drawing.Size(180, 80);
            // 
            // 
            // 
            this.mtLapLCKH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLapLCKH.TitleText = "Laporan";
            // 
            // mtSKP
            // 
            this.mtSKP.Image = global::SimkapSmartClient.Properties.Resources.lckh;
            this.mtSKP.Name = "mtSKP";
            this.mtSKP.SymbolColor = System.Drawing.Color.Empty;
            this.mtSKP.Text = "Kelola Data Sasaran Kerja";
            this.mtSKP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish;
            // 
            // 
            // 
            this.mtSKP.TileStyle.BackColorGradientAngle = 80;
            this.mtSKP.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.mtSKP.TileStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtSKP.TileStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtSKP.TileStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtSKP.TileStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtSKP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtSKP.TitleText = "Sasaran Kerja Pegawai";
            this.mtSKP.Click += new System.EventHandler(this.mtSKP_Click);
            // 
            // mtLCKH
            // 
            this.mtLCKH.Image = global::SimkapSmartClient.Properties.Resources.lckh;
            this.mtLCKH.Name = "mtLCKH";
            this.mtLCKH.SymbolColor = System.Drawing.Color.Empty;
            this.mtLCKH.Text = "Kelola Data Capaian Kinerja";
            this.mtLCKH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.mtLCKH.TileStyle.BackColorGradientAngle = 80;
            this.mtLCKH.TileStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.mtLCKH.TileStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtLCKH.TileStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtLCKH.TileStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtLCKH.TileStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.mtLCKH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLCKH.TitleText = "Capaian Kinerja Harian Pegawai";
            this.mtLCKH.Click += new System.EventHandler(this.mtLCKH_Click);
            // 
            // mtRealisasi
            // 
            this.mtRealisasi.Image = global::SimkapSmartClient.Properties.Resources.lckh;
            this.mtRealisasi.Name = "mtRealisasi";
            this.mtRealisasi.SymbolColor = System.Drawing.Color.Empty;
            this.mtRealisasi.Text = "Kelola Data Realisasi";
            this.mtRealisasi.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal;
            // 
            // 
            // 
            this.mtRealisasi.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtRealisasi.TitleText = "Realisasi Kegiatan";
            this.mtRealisasi.Click += new System.EventHandler(this.mtRealisasi_Click);
            // 
            // mtUkurSasaran
            // 
            this.mtUkurSasaran.Image = global::SimkapSmartClient.Properties.Resources.lckh;
            this.mtUkurSasaran.Name = "mtUkurSasaran";
            this.mtUkurSasaran.SymbolColor = System.Drawing.Color.Empty;
            this.mtUkurSasaran.Text = "Kelola Data Ukur Sasaran";
            this.mtUkurSasaran.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.MaroonWashed;
            // 
            // 
            // 
            this.mtUkurSasaran.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtUkurSasaran.TitleText = "Ukur Sasaran Kerja";
            this.mtUkurSasaran.Click += new System.EventHandler(this.mtUkurSasaran_Click);
            // 
            // mtLPrilakuKerja
            // 
            this.mtLPrilakuKerja.Image = global::SimkapSmartClient.Properties.Resources.lckh;
            this.mtLPrilakuKerja.Name = "mtLPrilakuKerja";
            this.mtLPrilakuKerja.SymbolColor = System.Drawing.Color.Empty;
            this.mtLPrilakuKerja.Text = "Kelola Data Perilaku Kerja ";
            this.mtLPrilakuKerja.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.mtLPrilakuKerja.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLPrilakuKerja.TitleText = "Perilaku Kerja Pegawai";
            this.mtLPrilakuKerja.Click += new System.EventHandler(this.mtLPrilakuKerja_Click);
            // 
            // mtLaporan
            // 
            this.mtLaporan.Image = global::SimkapSmartClient.Properties.Resources.Laporan;
            this.mtLaporan.Name = "mtLaporan";
            this.mtLaporan.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporan.Text = "Laporan Penilaian Prestasi Kerja Pegawai";
            this.mtLaporan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            this.mtLaporan.TileSize = new System.Drawing.Size(180, 85);
            // 
            // 
            // 
            this.mtLaporan.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporan.Click += new System.EventHandler(this.mtLaporan_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SimkapSmartClient.Properties.Resources.bg_menu_client;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(966, 82);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(739, 116);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroStatusBar1);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMenuClient";
            this.Text = "Menu Klien - SIMKAP 1.0.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuClient_FormClosing);
            this.itemPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemPanel itemPanel2;
        private DevComponents.DotNetBar.ControlContainerItem SKP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Metro.MetroTileItem metroTileItem5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevComponents.DotNetBar.LabelItem labelItem4;
        private DevComponents.DotNetBar.Metro.MetroStatusBar metroStatusBar1;
        private DevComponents.DotNetBar.LabelItem labelItem5;
        private DevComponents.DotNetBar.LabelItem lblIpAddress;
        private DevComponents.DotNetBar.LabelItem labelItem8;
        private DevComponents.DotNetBar.LabelItem lblHostName;
        private DevComponents.DotNetBar.LabelItem labelItem9;
        private DevComponents.DotNetBar.LabelItem lblDate;
        private DevComponents.DotNetBar.LabelItem labelItem7;
        private DevComponents.DotNetBar.LabelItem lblTime;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelItem labelItem6;
        private DevComponents.DotNetBar.LabelItem labelItem10;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.LabelItem lblJabatan;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ItemPanel itemPanel3;
        private DevComponents.DotNetBar.ButtonItem lblNama;
        private DevComponents.DotNetBar.ButtonItem btnChangePassword;
        private DevComponents.DotNetBar.LabelItem LBL;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtSKP;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLCKH;
        private DevComponents.DotNetBar.LabelItem labelItem2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLPrilakuKerja;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtRealisasi;
        private SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtUkurSasaran;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporan;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLapLCKH;

        #region Variabel

        private IntRemoteWriteTransactionClient rwc;
        private IntRemoteSaveWriteTransactionClient rswc;
        private string message;
        private string data;
        private string obj;
        private string procces;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion
    }
}