using System;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtNama = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLihatPass = new DevComponents.DotNetBar.LabelX();
            this.btnSembunyiPass = new DevComponents.DotNetBar.LabelX();
            this.lblIpAddress = new DevComponents.DotNetBar.LabelX();
            this.lblHostName = new DevComponents.DotNetBar.LabelX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKataSandi = new DevComponents.DotNetBar.LabelX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.warningLogin = new DevComponents.DotNetBar.Controls.WarningBox();
            this.lblNama = new DevComponents.DotNetBar.LabelX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.lblProgressText = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(25, 419);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnLogin.Size = new System.Drawing.Size(270, 44);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnLogin.Symbol = "";
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Masuk";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPass.Border.Class = "TextBoxBorder";
            this.txtPass.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPass.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtPass.FocusHighlightEnabled = true;
            this.txtPass.Font = new System.Drawing.Font("Roboto Condensed Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtPass, true);
            this.txtPass.Location = new System.Drawing.Point(25, 370);
            this.txtPass.MaxLength = 24;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(270, 29);
            this.txtPass.TabIndex = 10;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WatermarkFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.WatermarkText = "Masukkan kata sandi akun";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtNama
            // 
            this.txtNama.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtNama.Border.Class = "TextBoxBorder";
            this.txtNama.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNama.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtNama.FocusHighlightEnabled = true;
            this.txtNama.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtNama, true);
            this.txtNama.Location = new System.Drawing.Point(25, 290);
            this.txtNama.MaxLength = 26;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(270, 29);
            this.txtNama.TabIndex = 9;
            this.txtNama.WatermarkColor = System.Drawing.Color.DimGray;
            this.txtNama.WatermarkFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.WatermarkText = "Masukkan nama pengguna";
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // btnLihatPass
            // 
            this.btnLihatPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.btnLihatPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnLihatPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLihatPass.ForeColor = System.Drawing.Color.Black;
            this.btnLihatPass.Location = new System.Drawing.Point(267, 375);
            this.btnLihatPass.Name = "btnLihatPass";
            this.btnLihatPass.SingleLineColor = System.Drawing.Color.Transparent;
            this.btnLihatPass.Size = new System.Drawing.Size(26, 19);
            this.btnLihatPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnLihatPass.Symbol = "";
            this.btnLihatPass.SymbolColor = System.Drawing.SystemColors.Desktop;
            this.btnLihatPass.TabIndex = 15;
            this.btnLihatPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLihatPass.Click += new System.EventHandler(this.btnLihatPass_Click);
            // 
            // btnSembunyiPass
            // 
            this.btnSembunyiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.btnSembunyiPass.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.btnSembunyiPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSembunyiPass.ForeColor = System.Drawing.Color.Black;
            this.btnSembunyiPass.Location = new System.Drawing.Point(267, 375);
            this.btnSembunyiPass.Name = "btnSembunyiPass";
            this.btnSembunyiPass.SingleLineColor = System.Drawing.Color.Transparent;
            this.btnSembunyiPass.Size = new System.Drawing.Size(25, 23);
            this.btnSembunyiPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnSembunyiPass.Symbol = "";
            this.btnSembunyiPass.SymbolColor = System.Drawing.SystemColors.Desktop;
            this.btnSembunyiPass.TabIndex = 16;
            this.btnSembunyiPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSembunyiPass.Click += new System.EventHandler(this.btnSembunyiPass_Click);
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblIpAddress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblIpAddress.ForeColor = System.Drawing.Color.Black;
            this.lblIpAddress.Location = new System.Drawing.Point(116, 469);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(75, 23);
            this.lblIpAddress.TabIndex = 17;
            this.lblIpAddress.Text = "IP Address";
            this.lblIpAddress.Visible = false;
            // 
            // lblHostName
            // 
            this.lblHostName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblHostName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHostName.ForeColor = System.Drawing.Color.Black;
            this.lblHostName.Location = new System.Drawing.Point(200, 469);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(75, 23);
            this.lblHostName.TabIndex = 18;
            this.lblHostName.Text = "Host Name";
            this.lblHostName.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.ForeColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 216);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblKataSandi
            // 
            this.lblKataSandi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblKataSandi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKataSandi.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKataSandi.ForeColor = System.Drawing.Color.Black;
            this.lblKataSandi.Location = new System.Drawing.Point(25, 341);
            this.lblKataSandi.Name = "lblKataSandi";
            this.lblKataSandi.Size = new System.Drawing.Size(100, 23);
            this.lblKataSandi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblKataSandi.TabIndex = 22;
            this.lblKataSandi.Text = "Kata Sandi";
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // warningLogin
            // 
            this.warningLogin.BackColor = System.Drawing.Color.White;
            this.warningLogin.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLogin.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.warningLogin, true);
            this.warningLogin.Image = ((System.Drawing.Image)(resources.GetObject("warningLogin.Image")));
            this.warningLogin.Location = new System.Drawing.Point(14, 215);
            this.warningLogin.Name = "warningLogin";
            this.warningLogin.OptionsButtonVisible = false;
            this.warningLogin.OptionsText = "";
            this.warningLogin.Size = new System.Drawing.Size(295, 40);
            this.warningLogin.TabIndex = 26;
            this.warningLogin.Text = "<b>Peringatan</b> Nama pengguna atau kata sandi tidak valid.";
            this.warningLogin.CloseClick += new System.EventHandler(this.warningLogin_CloseClick);
            // 
            // lblNama
            // 
            this.lblNama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblNama.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblNama.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.Black;
            this.lblNama.Location = new System.Drawing.Point(25, 261);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(124, 23);
            this.lblNama.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblNama.TabIndex = 23;
            this.lblNama.Text = "Nama Pengguna";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgress1
            // 
            this.circularProgress1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(129, 306);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circularProgress1.ProgressText = "Mohon Tunggu";
            this.circularProgress1.ProgressTextColor = System.Drawing.Color.Black;
            this.circularProgress1.Size = new System.Drawing.Size(56, 58);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 27;
            this.circularProgress1.UseWaitCursor = true;
            // 
            // lblProgressText
            // 
            this.lblProgressText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.lblProgressText.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProgressText.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressText.ForeColor = System.Drawing.Color.Black;
            this.lblProgressText.Location = new System.Drawing.Point(112, 370);
            this.lblProgressText.Name = "lblProgressText";
            this.lblProgressText.Size = new System.Drawing.Size(102, 23);
            this.lblProgressText.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblProgressText.TabIndex = 28;
            this.lblProgressText.Text = "Mohon Tunggu";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 487);
            this.Controls.Add(this.lblProgressText);
            this.Controls.Add(this.circularProgress1);
            this.Controls.Add(this.warningLogin);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.lblKataSandi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.lblIpAddress);
            this.Controls.Add(this.btnSembunyiPass);
            this.Controls.Add(this.btnLihatPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNama);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TitleText = "Login - SIMKAP 1.0.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.Controls.TextBoxX txtNama;
        private DevComponents.DotNetBar.LabelX btnLihatPass;
        private DevComponents.DotNetBar.LabelX btnSembunyiPass;
        private DevComponents.DotNetBar.LabelX lblHostName;
        private DevComponents.DotNetBar.LabelX lblIpAddress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.LabelX lblKataSandi;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.LabelX lblNama;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.Controls.WarningBox warningLogin;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private DevComponents.DotNetBar.LabelX lblProgressText;

        #region Variabel

        private IntLoginServer ls;
        private EntAdministrator et;
        private EventArgs el;
        private object sender;
        private string log;
        private string sendNama;
        private string sendIpServer;
        private string sendHostServer;
        private bool condition;

        #endregion
    }
}