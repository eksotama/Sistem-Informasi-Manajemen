using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmRealisasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRealisasi));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtDataRealisasiKegiatan = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtChoosePeriode = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.SuspendLayout();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(101, 37);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(426, 70);
            this.reflectionLabel1.TabIndex = 25;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Menu Realisasi Kegiatan</font></font></b>" +
    "";
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
            this.itemPanel1.Location = new System.Drawing.Point(101, 122);
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
            this.mtDataRealisasiKegiatan});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtDataRealisasiKegiatan
            // 
            this.mtDataRealisasiKegiatan.Image = global::SimkapSmartClient.Properties.Resources.lihat_skp;
            this.mtDataRealisasiKegiatan.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDataRealisasiKegiatan.Name = "mtDataRealisasiKegiatan";
            this.mtDataRealisasiKegiatan.SymbolColor = System.Drawing.Color.Empty;
            this.mtDataRealisasiKegiatan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            this.mtDataRealisasiKegiatan.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtDataRealisasiKegiatan.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtDataRealisasiKegiatan.TitleText = "Lihat Data Realisasi Kegiatan";
            this.mtDataRealisasiKegiatan.Click += new System.EventHandler(this.mtDataRealisasiKegiatan_Click);
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
            this.mtChoosePeriode});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtChoosePeriode
            // 
            this.mtChoosePeriode.Image = global::SimkapSmartClient.Properties.Resources.buat_skp;
            this.mtChoosePeriode.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtChoosePeriode.Name = "mtChoosePeriode";
            this.mtChoosePeriode.SymbolColor = System.Drawing.Color.Empty;
            this.mtChoosePeriode.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.mtChoosePeriode.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtChoosePeriode.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtChoosePeriode.TitleText = "Hitung Realisasi Kegiatan";
            this.mtChoosePeriode.Click += new System.EventHandler(this.mtChoosePeriode_Click);
            // 
            // FrmRealisasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 347);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.itemPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRealisasi";
            this.Text = "Realisasi Kegiatan - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmRealisasi_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtDataRealisasiKegiatan;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtChoosePeriode;

        #region Variabel

        private string sendIpAddress;
        private string sendNama;
        private string sendJabatan;
        private Action<Form> viewForm;
        private string procces;

        #endregion
    }
}