using System;
using System.Windows.Forms;

namespace SimkapSmartClient.simkap.smart.client.view
{
    partial class FrmUkurSasaranKerja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUkurSasaranKerja));
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.itemPanel1 = new DevComponents.DotNetBar.ItemPanel();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.mtDataUkurSasaran = new DevComponents.DotNetBar.Metro.MetroTileItem();
            this.itemContainer2 = new DevComponents.DotNetBar.ItemContainer();
            this.mtWorksheetUkurSasaran = new DevComponents.DotNetBar.Metro.MetroTileItem();
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
            this.reflectionLabel1.Size = new System.Drawing.Size(440, 70);
            this.reflectionLabel1.TabIndex = 29;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Menu Ukur Sasaran</font></font></b>";
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
            this.itemPanel1.TabIndex = 28;
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
            this.mtDataUkurSasaran});
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtDataUkurSasaran
            // 
            this.mtDataUkurSasaran.Image = global::SimkapSmartClient.Properties.Resources.lihat_skp;
            this.mtDataUkurSasaran.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDataUkurSasaran.Name = "mtDataUkurSasaran";
            this.mtDataUkurSasaran.SymbolColor = System.Drawing.Color.Empty;
            this.mtDataUkurSasaran.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue;
            this.mtDataUkurSasaran.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtDataUkurSasaran.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtDataUkurSasaran.TitleText = "Lihat Data Ukur Sasaran";
            this.mtDataUkurSasaran.Click += new System.EventHandler(this.mtDataUkurSasaran_Click);
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
            this.mtWorksheetUkurSasaran});
            // 
            // 
            // 
            this.itemContainer2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // mtWorksheetUkurSasaran
            // 
            this.mtWorksheetUkurSasaran.Image = global::SimkapSmartClient.Properties.Resources.buat_skp;
            this.mtWorksheetUkurSasaran.ImageTextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtWorksheetUkurSasaran.Name = "mtWorksheetUkurSasaran";
            this.mtWorksheetUkurSasaran.SymbolColor = System.Drawing.Color.Empty;
            this.mtWorksheetUkurSasaran.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green;
            this.mtWorksheetUkurSasaran.TileSize = new System.Drawing.Size(361, 90);
            // 
            // 
            // 
            this.mtWorksheetUkurSasaran.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mtWorksheetUkurSasaran.TitleText = "Ukur Sasaran Kerja";
            this.mtWorksheetUkurSasaran.Click += new System.EventHandler(this.mtWorksheetUkurSasaran_Click);
            // 
            // FrmUkurSasaranKerja
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
            this.Name = "FrmUkurSasaranKerja";
            this.Text = "Ukur Sasaran Kerja - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmUkurSasaranKerja_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ItemPanel itemPanel1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtDataUkurSasaran;
        private DevComponents.DotNetBar.ItemContainer itemContainer2;
        private DevComponents.DotNetBar.Metro.MetroTileItem mtWorksheetUkurSasaran;

        #region Variabel

        private string sendIpAddress;
        private string sendNama;
        private string sendJabatan;
        private Action<Form> viewForm;
        private string procces;

        #endregion
    }
}