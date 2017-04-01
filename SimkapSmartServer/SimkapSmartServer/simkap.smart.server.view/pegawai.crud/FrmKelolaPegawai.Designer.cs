using System;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view.pegawai.crud
{
    partial class FrmKelolaPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKelolaPegawai));
            this.lblKeterangan = new DevComponents.DotNetBar.LabelX();
            this.txtJabatan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPangkat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNip = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbUnitKerja = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cmbKeterangan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.panelNotifikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblKeterangan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKeterangan.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.Black;
            this.lblKeterangan.Location = new System.Drawing.Point(38, 24);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(141, 33);
            this.lblKeterangan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblKeterangan.TabIndex = 45;
            this.lblKeterangan.Text = "Tambah Pegawai";
            // 
            // txtJabatan
            // 
            this.txtJabatan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtJabatan.Border.Class = "TextBoxBorder";
            this.txtJabatan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJabatan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJabatan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtJabatan.FocusHighlightEnabled = true;
            this.txtJabatan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJabatan.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtJabatan, true);
            this.txtJabatan.Location = new System.Drawing.Point(271, 302);
            this.txtJabatan.MaxLength = 65;
            this.txtJabatan.Name = "txtJabatan";
            this.txtJabatan.Size = new System.Drawing.Size(363, 27);
            this.txtJabatan.TabIndex = 75;
            this.txtJabatan.TextChanged += new System.EventHandler(this.txtJabatan_TextChanged);
            this.txtJabatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJabatan_KeyPress);
            // 
            // txtPangkat
            // 
            this.txtPangkat.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPangkat.Border.Class = "TextBoxBorder";
            this.txtPangkat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPangkat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPangkat.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtPangkat.FocusHighlightEnabled = true;
            this.txtPangkat.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPangkat.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtPangkat, true);
            this.txtPangkat.Location = new System.Drawing.Point(270, 170);
            this.txtPangkat.MaxLength = 25;
            this.txtPangkat.Name = "txtPangkat";
            this.txtPangkat.Size = new System.Drawing.Size(217, 27);
            this.txtPangkat.TabIndex = 74;
            this.txtPangkat.TextChanged += new System.EventHandler(this.txtPangkat_TextChanged);
            // 
            // txtNip
            // 
            this.txtNip.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNip.Border.Class = "TextBoxBorder";
            this.txtNip.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNip.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtNip.FocusHighlightEnabled = true;
            this.txtNip.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNip.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNip, true);
            this.txtNip.Location = new System.Drawing.Point(271, 81);
            this.txtNip.MaxLength = 30;
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(170, 27);
            this.txtNip.TabIndex = 73;
            this.txtNip.TextChanged += new System.EventHandler(this.txtNip_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNama.Border.Class = "TextBoxBorder";
            this.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNama.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtNama.FocusHighlightEnabled = true;
            this.txtNama.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNama, true);
            this.txtNama.Location = new System.Drawing.Point(271, 126);
            this.txtNama.MaxLength = 50;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(302, 27);
            this.txtNama.TabIndex = 72;
            this.txtNama.Click += new System.EventHandler(this.txtNama_Click);
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // cmbUnitKerja
            // 
            this.cmbUnitKerja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbUnitKerja.DisplayMember = "Text";
            this.cmbUnitKerja.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbUnitKerja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitKerja.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitKerja.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbUnitKerja, true);
            this.cmbUnitKerja.ItemHeight = 21;
            this.cmbUnitKerja.Location = new System.Drawing.Point(271, 212);
            this.cmbUnitKerja.Name = "cmbUnitKerja";
            this.cmbUnitKerja.Size = new System.Drawing.Size(296, 27);
            this.cmbUnitKerja.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.cmbUnitKerja.TabIndex = 71;
            this.cmbUnitKerja.WatermarkText = "-- pilih unit kerja --";
            this.cmbUnitKerja.SelectedValueChanged += new System.EventHandler(this.cmbUnitKerja_SelectedValueChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.ForeColor = System.Drawing.Color.Black;
            this.labelX6.Location = new System.Drawing.Point(70, 213);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(69, 23);
            this.labelX6.TabIndex = 70;
            this.labelX6.Text = "Unit Kerja";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.ForeColor = System.Drawing.Color.Black;
            this.labelX3.Location = new System.Drawing.Point(70, 170);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(137, 23);
            this.labelX3.TabIndex = 69;
            this.labelX3.Text = "Pangkat/Gol.Ruang";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.ForeColor = System.Drawing.Color.Black;
            this.labelX2.Location = new System.Drawing.Point(71, 126);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(51, 23);
            this.labelX2.TabIndex = 68;
            this.labelX2.Text = "Nama";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Black;
            this.labelX4.Location = new System.Drawing.Point(71, 82);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(37, 23);
            this.labelX4.TabIndex = 67;
            this.labelX4.Text = "NIP";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(538, 358);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 66;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(421, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 65;
            this.btnSave.Text = "Simpan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(70, 302);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 23);
            this.labelX1.TabIndex = 64;
            this.labelX1.Text = "Jabatan";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // cmbKeterangan
            // 
            this.cmbKeterangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKeterangan.DisplayMember = "Text";
            this.cmbKeterangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKeterangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeterangan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKeterangan.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbKeterangan, true);
            this.cmbKeterangan.ItemHeight = 21;
            this.cmbKeterangan.Location = new System.Drawing.Point(271, 256);
            this.cmbKeterangan.Name = "cmbKeterangan";
            this.cmbKeterangan.Size = new System.Drawing.Size(241, 27);
            this.cmbKeterangan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.cmbKeterangan.TabIndex = 77;
            this.cmbKeterangan.WatermarkText = "-- pilih keterangan --";
            this.cmbKeterangan.SelectedValueChanged += new System.EventHandler(this.cmbKeterangan_SelectedValueChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(70, 257);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(69, 23);
            this.labelX5.TabIndex = 76;
            this.labelX5.Text = "Keterangan";
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(185, 23);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(449, 38);
            // 
            // 
            // 
            this.panelNotifikasi.Style.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelNotifikasi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.MenuSide;
            this.panelNotifikasi.Style.BackColorGradientAngle = 80;
            this.panelNotifikasi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNotifikasi.Style.BorderBottomWidth = 1;
            this.panelNotifikasi.Style.BorderColor = System.Drawing.Color.DodgerBlue;
            this.panelNotifikasi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNotifikasi.Style.BorderLeftWidth = 1;
            this.panelNotifikasi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNotifikasi.Style.BorderRightWidth = 1;
            this.panelNotifikasi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.panelNotifikasi.Style.BorderTopWidth = 1;
            this.panelNotifikasi.Style.CornerDiameter = 4;
            this.panelNotifikasi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelNotifikasi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelNotifikasi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelNotifikasi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.panelNotifikasi.Style.TextShadowColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            // 
            // 
            // 
            this.panelNotifikasi.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelNotifikasi.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelNotifikasi.TabIndex = 78;
            // 
            // lblTextNotifikasi
            // 
            this.lblTextNotifikasi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTextNotifikasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTextNotifikasi.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNotifikasi.Location = new System.Drawing.Point(10, 2);
            this.lblTextNotifikasi.Name = "lblTextNotifikasi";
            this.lblTextNotifikasi.Size = new System.Drawing.Size(206, 29);
            this.lblTextNotifikasi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblTextNotifikasi.Symbol = "";
            this.lblTextNotifikasi.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTextNotifikasi.TabIndex = 45;
            this.lblTextNotifikasi.Text = "<b></b>Anda berhasil menyimpan data";
            // 
            // FrmKelolaPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 419);
            this.Controls.Add(this.panelNotifikasi);
            this.Controls.Add(this.cmbKeterangan);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtJabatan);
            this.Controls.Add(this.txtPangkat);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.cmbUnitKerja);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lblKeterangan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKelolaPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Pegawai - SIMKAP 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKelolaPegawai_FormClosing);
            this.panelNotifikasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX lblKeterangan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJabatan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPangkat;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNip;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNama;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbUnitKerja;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKeterangan;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;

        #region Variabel

        private IntPegawai ip;
        private IntUnitKerja iuk;
        private EntPegawai ep;
        private FrmMenu frmMenu;
        private FrmPegawai frmPegawai;
        private Action setDataPegawai;
        private Action setVisibleNotifikasiEditSucces;
        private EventArgs e;
        private object sender;
        private string receiveIp;
        private string receiveNama;
        private string receiveProcess;
        private string log;
        private string message;
        private bool condition;
        private bool validation;

        #endregion
    }
}