using System;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view.administrator.crud
{
    partial class FrmKelolaAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKelolaAdmin));
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNamaPengguna = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblKeterangan = new DevComponents.DotNetBar.LabelX();
            this.txtNama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cbPria = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cbWanita = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPassword.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtPassword.FocusHighlightEnabled = true;
            this.txtPassword.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtPassword, true);
            this.txtPassword.Location = new System.Drawing.Point(267, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 27);
            this.txtPassword.TabIndex = 41;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
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
            this.txtNamaPengguna.Location = new System.Drawing.Point(267, 150);
            this.txtNamaPengguna.Name = "txtNamaPengguna";
            this.txtNamaPengguna.Size = new System.Drawing.Size(219, 27);
            this.txtNamaPengguna.TabIndex = 40;
            this.txtNamaPengguna.TextChanged += new System.EventHandler(this.txtNamaPengguna_TextChanged);
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
            this.labelX3.Location = new System.Drawing.Point(68, 150);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
            this.labelX3.TabIndex = 39;
            this.labelX3.Text = "Nama Pengguna";
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
            this.labelX2.Location = new System.Drawing.Point(68, 112);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(108, 23);
            this.labelX2.TabIndex = 36;
            this.labelX2.Text = "Jenis Kelamin";
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
            this.lblKeterangan.Location = new System.Drawing.Point(35, 18);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(280, 33);
            this.lblKeterangan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblKeterangan.TabIndex = 35;
            this.lblKeterangan.Text = "Ubah Administrator";
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
            this.txtNama.Location = new System.Drawing.Point(268, 75);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(270, 27);
            this.txtNama.TabIndex = 34;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
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
            this.labelX4.Location = new System.Drawing.Point(68, 76);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(50, 23);
            this.labelX4.TabIndex = 33;
            this.labelX4.Text = "Nama";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(442, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 32;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(326, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 31;
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
            this.labelX1.Location = new System.Drawing.Point(69, 192);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(81, 23);
            this.labelX1.TabIndex = 30;
            this.labelX1.Text = "Kata Sandi";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // cbPria
            // 
            // 
            // 
            // 
            this.cbPria.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbPria.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbPria.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPria.Location = new System.Drawing.Point(268, 112);
            this.cbPria.Name = "cbPria";
            this.cbPria.Size = new System.Drawing.Size(47, 23);
            this.cbPria.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbPria.TabIndex = 42;
            this.cbPria.Text = "Pria";
            this.cbPria.TextColor = System.Drawing.SystemColors.HotTrack;
            this.cbPria.CheckedChanged += new System.EventHandler(this.cbPria_CheckedChanged);
            // 
            // cbWanita
            // 
            // 
            // 
            // 
            this.cbWanita.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.cbWanita.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.cbWanita.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWanita.Location = new System.Drawing.Point(345, 112);
            this.cbWanita.Name = "cbWanita";
            this.cbWanita.Size = new System.Drawing.Size(69, 23);
            this.cbWanita.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbWanita.TabIndex = 43;
            this.cbWanita.Text = "Wanita";
            this.cbWanita.TextColor = System.Drawing.SystemColors.HotTrack;
            this.cbWanita.CheckedChanged += new System.EventHandler(this.cbWanita_CheckedChanged);
            // 
            // FrmKelolaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 309);
            this.Controls.Add(this.cbWanita);
            this.Controls.Add(this.cbPria);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNamaPengguna);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKelolaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Admin - SIMKAP 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKelolaAdmin_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNamaPengguna;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblKeterangan;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNama;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbWanita;
        private DevComponents.DotNetBar.Controls.CheckBoxX cbPria;

        #region Variabel

        private IntAdministrator ia;
        private Action setDataAdministrator;
        private Action setVisibleNotifikasiEditSucces;
        private FrmMenu frmMenu;
        private FrmAdministartor frmAdministartor;
        private EntAdministrator ea;
        private EventArgs e;
        private object sender;
        private string receiveIp;
        private string receiveNama;
        private string select;
        private string log;
        private string message;
        private string receiveId;
        private bool condition;

        #endregion
    }
}