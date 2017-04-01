using System;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;


namespace SimkapSmartServer.simkap.smart.server.view.login.pegawai.crud
{
    partial class FrmKelolaLoginPegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKelolaLoginPegawai));
            this.cmbNamaPegawai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtNamaPengguna = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtKataSandi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelNotifikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNamaPegawai
            // 
            this.cmbNamaPegawai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNamaPegawai.DisplayMember = "Text";
            this.cmbNamaPegawai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamaPegawai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNamaPegawai.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbNamaPegawai.FocusHighlightEnabled = true;
            this.cmbNamaPegawai.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNamaPegawai.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbNamaPegawai, true);
            this.cmbNamaPegawai.ItemHeight = 21;
            this.cmbNamaPegawai.Location = new System.Drawing.Point(245, 77);
            this.cmbNamaPegawai.Name = "cmbNamaPegawai";
            this.cmbNamaPegawai.Size = new System.Drawing.Size(284, 27);
            this.cmbNamaPegawai.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.cmbNamaPegawai.TabIndex = 69;
            this.cmbNamaPegawai.WatermarkText = "-- pilih nama  --";
            this.cmbNamaPegawai.Click += new System.EventHandler(this.cmbNamaPegawai_Click);
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
            this.labelX3.Location = new System.Drawing.Point(66, 77);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 23);
            this.labelX3.TabIndex = 68;
            this.labelX3.Text = "Nama";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(459, 234);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 67;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(342, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 66;
            this.btnSave.Text = "Simpan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Roboto Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(33, 19);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(364, 33);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX5.TabIndex = 65;
            this.labelX5.Text = "Tambah Login Pegawai";
            // 
            // txtNamaPengguna
            // 
            this.txtNamaPengguna.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNamaPengguna.Border.Class = "TextBoxBorder";
            this.txtNamaPengguna.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNamaPengguna.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtNamaPengguna.FocusHighlightEnabled = true;
            this.txtNamaPengguna.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamaPengguna.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNamaPengguna, true);
            this.txtNamaPengguna.Location = new System.Drawing.Point(245, 128);
            this.txtNamaPengguna.MaxLength = 10;
            this.txtNamaPengguna.Name = "txtNamaPengguna";
            this.txtNamaPengguna.Size = new System.Drawing.Size(240, 27);
            this.txtNamaPengguna.TabIndex = 72;
            this.txtNamaPengguna.TextChanged += new System.EventHandler(this.txtNamaPengguna_TextChanged);
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
            this.labelX1.Location = new System.Drawing.Point(66, 128);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(97, 23);
            this.labelX1.TabIndex = 71;
            this.labelX1.Text = "Nama Pengguna";
            // 
            // txtKataSandi
            // 
            this.txtKataSandi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKataSandi.Border.Class = "TextBoxBorder";
            this.txtKataSandi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKataSandi.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtKataSandi.FocusHighlightEnabled = true;
            this.txtKataSandi.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKataSandi.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtKataSandi, true);
            this.txtKataSandi.Location = new System.Drawing.Point(245, 178);
            this.txtKataSandi.MaxLength = 15;
            this.txtKataSandi.Name = "txtKataSandi";
            this.txtKataSandi.Size = new System.Drawing.Size(240, 27);
            this.txtKataSandi.TabIndex = 74;
            this.txtKataSandi.UseSystemPasswordChar = true;
            this.txtKataSandi.TextChanged += new System.EventHandler(this.txtKataSandi_TextChanged);
            this.txtKataSandi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKataSandi_KeyPress);
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
            this.labelX2.Location = new System.Drawing.Point(66, 178);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(77, 23);
            this.labelX2.TabIndex = 73;
            this.labelX2.Text = "Kata Sandi";
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(245, 19);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(310, 38);
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
            this.panelNotifikasi.TabIndex = 75;
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
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // FrmKelolaLoginPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 309);
            this.Controls.Add(this.panelNotifikasi);
            this.Controls.Add(this.txtKataSandi);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtNamaPengguna);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbNamaPegawai);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKelolaLoginPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Login Pegawai - SIMKAP 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKelolaLoginPegawai_FormClosing);
            this.panelNotifikasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamaPegawai;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNamaPengguna;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKataSandi;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;

        #region Variabel

        private IntLoginPegawai ilp;
        private EntLoginPegawai elp;
        private Action setDataLoginPegawai;
        private FrmLoginPegawai frmLoginPegawai;
        private FrmMenu frmMenu;
        private EventArgs e;
        private object sender;
        private string receiveIp;
        private string receiveNama;
        private string log;
        private string message;
        private bool condition;
        private bool validation;

        #endregion
    }
}