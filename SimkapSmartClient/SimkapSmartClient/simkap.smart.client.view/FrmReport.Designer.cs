using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtCoverLaporan = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLaporanSKP = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLaporanLCKH = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtLaporanUkurSasaran = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLaporanPrilakuKerja = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.mtLaporanPerstasiKerja = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer3 = new DevComponents.DotNetBar.ItemContainer();
            this.mtLampiranLaporan = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.reflectionLabel1.Location = new System.Drawing.Point(43, 39);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(548, 70);
            this.reflectionLabel1.TabIndex = 22;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Menu Laporan</font></font></b>";
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
            this.itemContainer2,
            this.itemContainer3});
            this.itemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemPanel1.Location = new System.Drawing.Point(43, 115);
            this.itemPanel1.Name = "itemPanel1";
            this.itemPanel1.Size = new System.Drawing.Size(548, 278);
            this.itemPanel1.TabIndex = 23;
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
            this.mtCoverLaporan,
            this.mtLaporanSKP,
            this.mtLaporanLCKH});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtCoverLaporan
            // 
            this.mtCoverLaporan.Image = global::SimkapSmartClient.Properties.Resources.LAP_COVER;
            this.mtCoverLaporan.Name = "mtCoverLaporan";
            this.mtCoverLaporan.SymbolColor = System.Drawing.Color.Empty;
            this.mtCoverLaporan.Text = "Cover";
            this.mtCoverLaporan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum;
            // 
            // 
            // 
            this.mtCoverLaporan.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtCoverLaporan.TitleText = "Halaman Depan Laporan";
            this.mtCoverLaporan.Click += new System.EventHandler(this.mtCoverLaporan_Click);
            // 
            // mtLaporanSKP
            // 
            this.mtLaporanSKP.Image = global::SimkapSmartClient.Properties.Resources.LAP_SKP_;
            this.mtLaporanSKP.Name = "mtLaporanSKP";
            this.mtLaporanSKP.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporanSKP.Text = "Sasaran Kerja";
            this.mtLaporanSKP.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive;
            // 
            // 
            // 
            this.mtLaporanSKP.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporanSKP.TitleText = "Sasaran Kerja Pegawai";
            this.mtLaporanSKP.Click += new System.EventHandler(this.mtLaporanSKP_Click);
            // 
            // mtLaporanLCKH
            // 
            this.mtLaporanLCKH.Image = global::SimkapSmartClient.Properties.Resources.LAP_LCKH;
            this.mtLaporanLCKH.Name = "mtLaporanLCKH";
            this.mtLaporanLCKH.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporanLCKH.Text = "Capaian Kinerja";
            this.mtLaporanLCKH.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Magenta;
            // 
            // 
            // 
            this.mtLaporanLCKH.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporanLCKH.TitleText = "Capaian Kinerja Harian Pegawai";
            this.mtLaporanLCKH.Click += new System.EventHandler(this.mtLaporanLCKH_Click);
            // 
            // itemContainer2
            // 
            // 
            // 
            // 
            this.itemContainer2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer2.Name = "itemContainer2";
            this.itemContainer2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mtLaporanUkurSasaran,
            this.mtLaporanPrilakuKerja,
            this.mtLaporanPerstasiKerja});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtLaporanUkurSasaran
            // 
            this.mtLaporanUkurSasaran.Image = global::SimkapSmartClient.Properties.Resources.LAP_UKUR;
            this.mtLaporanUkurSasaran.Name = "mtLaporanUkurSasaran";
            this.mtLaporanUkurSasaran.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporanUkurSasaran.Text = "Ukur Sasaran";
            this.mtLaporanUkurSasaran.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Rust;
            // 
            // 
            // 
            this.mtLaporanUkurSasaran.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporanUkurSasaran.TitleText = "Ukur Sasaran Kerja Pegawai";
            this.mtLaporanUkurSasaran.Click += new System.EventHandler(this.mtLaporanUkurSasaran_Click);
            // 
            // mtLaporanPrilakuKerja
            // 
            this.mtLaporanPrilakuKerja.Image = global::SimkapSmartClient.Properties.Resources.LAP_PERILAKU;
            this.mtLaporanPrilakuKerja.Name = "mtLaporanPrilakuKerja";
            this.mtLaporanPrilakuKerja.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporanPrilakuKerja.Text = "Perilaku Kerja";
            this.mtLaporanPrilakuKerja.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee;
            // 
            // 
            // 
            this.mtLaporanPrilakuKerja.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporanPrilakuKerja.TitleText = "Penilaian Perilaku Kerja";
            this.mtLaporanPrilakuKerja.Click += new System.EventHandler(this.mtLaporanPrilakuKerja_Click);
            // 
            // mtLaporanPerstasiKerja
            // 
            this.mtLaporanPerstasiKerja.Image = global::SimkapSmartClient.Properties.Resources.LAP_PRESTASI;
            this.mtLaporanPerstasiKerja.Name = "mtLaporanPerstasiKerja";
            this.mtLaporanPerstasiKerja.SymbolColor = System.Drawing.Color.Empty;
            this.mtLaporanPerstasiKerja.Text = "Prestasi Kerja";
            this.mtLaporanPerstasiKerja.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen;
            // 
            // 
            // 
            this.mtLaporanPerstasiKerja.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLaporanPerstasiKerja.TitleText = "Penilaian Prestasi Kerja";
            this.mtLaporanPerstasiKerja.Click += new System.EventHandler(this.mtLaporanPerstasiKerja_Click);
            // 
            // itemContainer3
            // 
            // 
            // 
            // 
            this.itemContainer3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainer3.Name = "itemContainer3";
            this.itemContainer3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.mtLampiranLaporan});
            // 
            // 
            // 
            this.itemContainer3.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtLampiranLaporan
            // 
            this.mtLampiranLaporan.Image = global::SimkapSmartClient.Properties.Resources.LAP_LAMPIRAN;
            this.mtLampiranLaporan.Name = "mtLampiranLaporan";
            this.mtLampiranLaporan.SymbolColor = System.Drawing.Color.Empty;
            this.mtLampiranLaporan.Text = "Lampiran";
            this.mtLampiranLaporan.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange;
            // 
            // 
            // 
            this.mtLampiranLaporan.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtLampiranLaporan.TitleText = "Halaman Lampiran Laporan";
            this.mtLampiranLaporan.Click += new System.EventHandler(this.mtLampiranLaporan_Click);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 433);
            this.Controls.Add(this.itemPanel1);
            this.Controls.Add(this.reflectionLabel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmReport";
            this.Text = "Menu Laporan - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmReport_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporanSKP;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporanLCKH;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporanPerstasiKerja;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporanUkurSasaran;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLaporanPrilakuKerja;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtCoverLaporan;
        private DevComponents.DotNetBar.ItemContainer itemContainer3;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtLampiranLaporan;

        #region Variabel

        private string sendJabatan;
        private Action<Form> viewForm;
        private string procces;

        #endregion
    }
}