using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmMenuKelola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuKelola));
            this.lblKet = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtDataKelola = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtKelola = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
            // 
            // lblKet
            // 
            this.lblKet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblKet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKet.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKet.ForeColor = System.Drawing.Color.Black;
            this.lblKet.Location = new System.Drawing.Point(91, 49);
            this.lblKet.Name = "lblKet";
            this.lblKet.Size = new System.Drawing.Size(367, 70);
            this.lblKet.TabIndex = 25;
            this.lblKet.Text = "<b><font size=\"+12\"><font color=\"#0000\">keterangan</font></font></b>";
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
            this.itemPanel1.Location = new System.Drawing.Point(91, 120);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(367, 187);
            this.itemPanel1.TabIndex = 24;
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
            this.mtDataKelola});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtDataKelola
            // 
            this.mtDataKelola.Image = global::SimkapSmartClient.Properties.Resources.lihat_skp;
            this.mtDataKelola.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDataKelola.Name = "mtDataKelola";
            this.mtDataKelola.SymbolColor = System.Drawing.Color.Empty;
            this.mtDataKelola.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            this.mtDataKelola.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtDataKelola.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtDataKelola.TitleText = "keterangan";
            this.mtDataKelola.Click += new System.EventHandler(this.mtDataKelola_Click);
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
            this.mtKelola});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtKelola
            // 
            this.mtKelola.Image = global::SimkapSmartClient.Properties.Resources.buat_skp;
            this.mtKelola.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtKelola.Name = "mtKelola";
            this.mtKelola.SymbolColor = System.Drawing.Color.Empty;
            this.mtKelola.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.mtKelola.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtKelola.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtKelola.TitleText = "keterangan";
            this.mtKelola.Click += new System.EventHandler(this.mtKelola_Click);
            // 
            // FrmMenuKelola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 351);
            this.Controls.Add(this.lblKet);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenuKelola";
            this.Text = "Keterangan";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMenuKelola_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel lblKet;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtDataKelola;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtKelola;

        #region Variabel

        private FrmMenuClient frmMenuClient;
        private Action<Form> viewForm;
        private string sendjabatan;
        private string sendipaddress;
        private string sendnama;
        private string procces;

        #endregion
    }
}