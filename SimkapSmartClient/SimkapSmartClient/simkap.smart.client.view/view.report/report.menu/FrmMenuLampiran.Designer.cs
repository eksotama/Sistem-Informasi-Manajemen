using SimkapSmartClient.simkap.smart.client.setting.app;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using System;
using System.Threading;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.menu
{
    partial class FrmMenuLampiran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuLampiran));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtAwal = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtAkhir = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.itemPanel1.Location = new System.Drawing.Point(46, 117);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(367, 187);
            this.itemPanel1.TabIndex = 40;
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
            this.mtAwal,
            this.mtAkhir});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtAwal
            // 
            this.mtAwal.Image = global::SimkapSmartClient.Properties.Resources.LAP_AWAL;
            this.mtAwal.Name = "mtAwal";
            this.mtAwal.SymbolColor = System.Drawing.Color.Empty;
            this.mtAwal.Text = "Awal";
            this.mtAwal.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure;
            // 
            // 
            // 
            this.mtAwal.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtAwal.TitleText = "Lampiran Awal";
            this.mtAwal.Click += new System.EventHandler(this.mtAwal_Click);
            // 
            // mtAkhir
            // 
            this.mtAkhir.Image = global::SimkapSmartClient.Properties.Resources.LAP_AKHIR;
            this.mtAkhir.Name = "mtAkhir";
            this.mtAkhir.SymbolColor = System.Drawing.Color.Empty;
            this.mtAkhir.Text = "Akhir";
            this.mtAkhir.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet;
            // 
            // 
            // 
            this.mtAkhir.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtAkhir.TitleText = "Lampiran Akhir";
            this.mtAkhir.Click += new System.EventHandler(this.mtAkhir_Click);
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
            this.mtClose.Text = "Input Periode";
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
            this.reflectionLabel1.Location = new System.Drawing.Point(46, 41);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(367, 70);
            this.reflectionLabel1.TabIndex = 39;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Lampiran</font></font></b>";
            // 
            // FrmMenuLampiran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 345);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuLampiran";
            this.Text = "Menu Lampiran - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenuLampiran_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtAwal;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtAkhir;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtClose;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;

        #region Variabel

        private string procces;
        private Action<Form> viewForm;
        private string sendJabatan;
        private string periodeawal;
        private string periodeakhir;
        private string message;
        private bool condition;
        private SettingIpAddress setting = new SettingIpAddress();
        private IntRemoteValidationReport ir;
        private EntLaporan el;
        private ThreadStart client1;
        private Thread client2;
        private string obj;
        private string status;
        private string periodeawalmutasi;
        private string periodeakhirmutasi;
        private string tanggal;

        #endregion
    }
}