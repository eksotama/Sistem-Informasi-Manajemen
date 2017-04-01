using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmSasaranKerja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSasaranKerja));
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtDataSKP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtInformationSKP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtInputSKP = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.itemPanel1.Location = new System.Drawing.Point(60, 114);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(367, 187);
            this.itemPanel1.TabIndex = 0;
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
            this.mtDataSKP,
            this.mtInformationSKP});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtDataSKP
            // 
            this.mtDataSKP.Image = global::SimkapSmartClient.Properties.Resources.lihat_skp;
            this.mtDataSKP.Name = "mtDataSKP";
            this.mtDataSKP.SymbolColor = System.Drawing.Color.Empty;
            this.mtDataSKP.Text = "Lihat Data";
            this.mtDataSKP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            // 
            // 
            // 
            this.mtDataSKP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtDataSKP.TitleText = "Sasaran Kerja Pegawai";
            this.mtDataSKP.Click += new System.EventHandler(this.mtDataSKP_Click);
            // 
            // mtInformationSKP
            // 
            this.mtInformationSKP.Image = global::SimkapSmartClient.Properties.Resources.info_skp;
            this.mtInformationSKP.Name = "mtInformationSKP";
            this.mtInformationSKP.SymbolColor = System.Drawing.Color.Empty;
            this.mtInformationSKP.Text = "Daftar Sasaran Kerja";
            this.mtInformationSKP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish;
            // 
            // 
            // 
            this.mtInformationSKP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtInformationSKP.TitleText = "Informasi";
            this.mtInformationSKP.Click += new System.EventHandler(this.mtInformationSKP_Click);
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
            this.mtInputSKP});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtInputSKP
            // 
            this.mtInputSKP.Image = global::SimkapSmartClient.Properties.Resources.buat_skp;
            this.mtInputSKP.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtInputSKP.Name = "mtInputSKP";
            this.mtInputSKP.SymbolColor = System.Drawing.Color.Empty;
            this.mtInputSKP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.mtInputSKP.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtInputSKP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtInputSKP.TitleText = "Buat Target Sasaran Kerja";
            this.mtInputSKP.Click += new System.EventHandler(this.mtInputSKP_Click);
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
            this.reflectionLabel1.Location = new System.Drawing.Point(60, 38);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(367, 70);
            this.reflectionLabel1.TabIndex = 21;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Menu Sasaran Kerja</font></font></b>";
            // 
            // FrmSasaranKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 347);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSasaranKerja";
            this.Text = "Sasaran Kerja  - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmSasaranKerja_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtDataSKP;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtInformationSKP;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtInputSKP;

        #region Variabel

        private FrmMenuClient frmmenuclient;
        private Action<Form> viewForm1;
        private string sendipaddress;
        private string sendnama;
        private string sendjabatan;
        private string procces;

        #endregion
    }
}