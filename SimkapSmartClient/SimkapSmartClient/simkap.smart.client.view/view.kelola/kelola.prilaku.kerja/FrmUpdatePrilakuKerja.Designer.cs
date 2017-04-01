using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja
{
    partial class FrmUpdatePrilakuKerja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatePrilakuKerja));
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.txtNilaiRata = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtJumlah = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtKepemimpinan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtKerjasama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtDisiplin = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtKomitmen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtIntegritas = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtOrientasi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(225, 432);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 135;
            this.btnSave.Text = "Simpan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(344, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 134;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtNilaiRata
            // 
            this.txtNilaiRata.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNilaiRata.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNilaiRata.Border.Class = "TextBoxBorder";
            this.txtNilaiRata.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNilaiRata.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNilaiRata.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtNilaiRata.FocusHighlightEnabled = true;
            this.txtNilaiRata.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNilaiRata.ForeColor = System.Drawing.Color.Black;
            this.txtNilaiRata.Location = new System.Drawing.Point(347, 373);
            this.txtNilaiRata.Name = "txtNilaiRata";
            this.txtNilaiRata.ReadOnly = true;
            this.txtNilaiRata.Size = new System.Drawing.Size(92, 27);
            this.txtNilaiRata.TabIndex = 133;
            this.txtNilaiRata.TextChanged += new System.EventHandler(this.txtNilaiRata_TextChanged);
            // 
            // labelX9
            // 
            this.labelX9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.ForeColor = System.Drawing.Color.Black;
            this.labelX9.Location = new System.Drawing.Point(104, 373);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(125, 23);
            this.labelX9.TabIndex = 132;
            this.labelX9.Text = "Nilai Rata-rata";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJumlah.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJumlah.Border.Class = "TextBoxBorder";
            this.txtJumlah.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJumlah.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJumlah.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtJumlah.FocusHighlightEnabled = true;
            this.txtJumlah.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.ForeColor = System.Drawing.Color.Black;
            this.txtJumlah.Location = new System.Drawing.Point(347, 332);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.ReadOnly = true;
            this.txtJumlah.Size = new System.Drawing.Size(92, 27);
            this.txtJumlah.TabIndex = 131;
            this.txtJumlah.TextChanged += new System.EventHandler(this.txtJumlah_TextChanged);
            // 
            // labelX7
            // 
            this.labelX7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.ForeColor = System.Drawing.Color.Black;
            this.labelX7.Location = new System.Drawing.Point(104, 332);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(125, 23);
            this.labelX7.TabIndex = 130;
            this.labelX7.Text = "Jumlah";
            // 
            // txtKepemimpinan
            // 
            this.txtKepemimpinan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKepemimpinan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKepemimpinan.Border.Class = "TextBoxBorder";
            this.txtKepemimpinan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKepemimpinan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKepemimpinan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtKepemimpinan.FocusHighlightEnabled = true;
            this.txtKepemimpinan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKepemimpinan.ForeColor = System.Drawing.Color.Black;
            this.txtKepemimpinan.Location = new System.Drawing.Point(347, 291);
            this.txtKepemimpinan.Name = "txtKepemimpinan";
            this.txtKepemimpinan.Size = new System.Drawing.Size(92, 27);
            this.txtKepemimpinan.TabIndex = 129;
            this.txtKepemimpinan.TextChanged += new System.EventHandler(this.txtKepemimpinan_TextChanged);
            this.txtKepemimpinan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKepemimpinan_KeyPress);
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(104, 291);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(125, 23);
            this.labelX6.TabIndex = 128;
            this.labelX6.Text = "Kepemimpinan";
            // 
            // txtKerjasama
            // 
            this.txtKerjasama.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKerjasama.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKerjasama.Border.Class = "TextBoxBorder";
            this.txtKerjasama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKerjasama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKerjasama.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtKerjasama.FocusHighlightEnabled = true;
            this.txtKerjasama.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKerjasama.ForeColor = System.Drawing.Color.Black;
            this.txtKerjasama.Location = new System.Drawing.Point(347, 250);
            this.txtKerjasama.Name = "txtKerjasama";
            this.txtKerjasama.Size = new System.Drawing.Size(92, 27);
            this.txtKerjasama.TabIndex = 127;
            this.txtKerjasama.TextChanged += new System.EventHandler(this.txtKerjasama_TextChanged);
            this.txtKerjasama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKerjasama_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(104, 250);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(125, 23);
            this.labelX3.TabIndex = 126;
            this.labelX3.Text = "Kerjasama";
            // 
            // txtDisiplin
            // 
            this.txtDisiplin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDisiplin.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDisiplin.Border.Class = "TextBoxBorder";
            this.txtDisiplin.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDisiplin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisiplin.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtDisiplin.FocusHighlightEnabled = true;
            this.txtDisiplin.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisiplin.ForeColor = System.Drawing.Color.Black;
            this.txtDisiplin.Location = new System.Drawing.Point(347, 209);
            this.txtDisiplin.Name = "txtDisiplin";
            this.txtDisiplin.Size = new System.Drawing.Size(92, 27);
            this.txtDisiplin.TabIndex = 125;
            this.txtDisiplin.TextChanged += new System.EventHandler(this.txtDisiplin_TextChanged);
            this.txtDisiplin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisiplin_KeyPress);
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(104, 209);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(125, 23);
            this.labelX2.TabIndex = 124;
            this.labelX2.Text = "Disiplin";
            // 
            // txtKomitmen
            // 
            this.txtKomitmen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtKomitmen.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKomitmen.Border.Class = "TextBoxBorder";
            this.txtKomitmen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKomitmen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKomitmen.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtKomitmen.FocusHighlightEnabled = true;
            this.txtKomitmen.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKomitmen.ForeColor = System.Drawing.Color.Black;
            this.txtKomitmen.Location = new System.Drawing.Point(347, 167);
            this.txtKomitmen.Name = "txtKomitmen";
            this.txtKomitmen.Size = new System.Drawing.Size(92, 27);
            this.txtKomitmen.TabIndex = 123;
            this.txtKomitmen.TextChanged += new System.EventHandler(this.txtKomitmen_TextChanged);
            this.txtKomitmen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKomitmen_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(104, 167);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(125, 23);
            this.labelX1.TabIndex = 122;
            this.labelX1.Text = "Komitmen";
            // 
            // txtIntegritas
            // 
            this.txtIntegritas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIntegritas.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtIntegritas.Border.Class = "TextBoxBorder";
            this.txtIntegritas.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtIntegritas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIntegritas.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtIntegritas.FocusHighlightEnabled = true;
            this.txtIntegritas.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntegritas.ForeColor = System.Drawing.Color.Black;
            this.txtIntegritas.Location = new System.Drawing.Point(347, 124);
            this.txtIntegritas.Name = "txtIntegritas";
            this.txtIntegritas.Size = new System.Drawing.Size(92, 27);
            this.txtIntegritas.TabIndex = 121;
            this.txtIntegritas.TextChanged += new System.EventHandler(this.txtIntegritas_TextChanged);
            this.txtIntegritas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIntegritas_KeyPress);
            // 
            // labelX8
            // 
            this.labelX8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.ForeColor = System.Drawing.Color.Black;
            this.labelX8.Location = new System.Drawing.Point(104, 124);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(125, 23);
            this.labelX8.TabIndex = 120;
            this.labelX8.Text = "Integritas";
            // 
            // txtOrientasi
            // 
            this.txtOrientasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtOrientasi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOrientasi.Border.Class = "TextBoxBorder";
            this.txtOrientasi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOrientasi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrientasi.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtOrientasi.FocusHighlightEnabled = true;
            this.txtOrientasi.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrientasi.ForeColor = System.Drawing.Color.Black;
            this.txtOrientasi.Location = new System.Drawing.Point(347, 83);
            this.txtOrientasi.Name = "txtOrientasi";
            this.txtOrientasi.Size = new System.Drawing.Size(92, 27);
            this.txtOrientasi.TabIndex = 118;
            this.txtOrientasi.TextChanged += new System.EventHandler(this.txtOrientasi_TextChanged);
            this.txtOrientasi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrientasi_KeyPress);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(104, 83);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(203, 23);
            this.labelX4.TabIndex = 117;
            this.labelX4.Text = "Orientasi Pelayanan";
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(80, 28);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(156, 33);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX5.TabIndex = 116;
            this.labelX5.Text = "Ubah Nilai Prilaku";
            // 
            // FrmUpdatePrilakuKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 496);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtNilaiRata);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtKepemimpinan);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtKerjasama);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtDisiplin);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtKomitmen);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtIntegritas);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtOrientasi);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUpdatePrilakuKerja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Ubah Prilaku Kerja - SIMKAP 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUpdatePrilakuKerja_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNilaiRata;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJumlah;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKepemimpinan;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKerjasama;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDisiplin;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKomitmen;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtIntegritas;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOrientasi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;

        #region Variabel

        private IntRemotePrilakuKerja ipl;
        private IntRemoteWriteTransactionClient rwc;
        private EntRemoteTransactionClient etc;
        private EntPrilakukerja epk;
        private ThreadStart client1;
        private Thread client2;
        private Thread mThread;
        private DataGridView dg;
        private Action<Form> viewForm;
        private FrmMenuClient frmmenuclient;
        private FrmMenuKelola frmmenukelola;
        private FrmDataPrilakuKerja frmDataPrilakuKerja;
        private Action setDataPrilakuKerja;
        private Action setVisibleNotifikasiEditSucces;
        private string sendIpAddress;
        private string sendNama;
        private string sendJabatan;
        private string obj;
        private string message;
        private string data;
        private bool validation;
        private bool condition;
        private double jumlah;
        private double ratarata;
        private double var;
        private int sendIdPrilaku;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion
    }
}