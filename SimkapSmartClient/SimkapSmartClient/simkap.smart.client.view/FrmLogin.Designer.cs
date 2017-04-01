using System;
using System.Threading;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view
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
            this.lblIpAddress = new System.Windows.Forms.Label();
            this.lblHostName = new System.Windows.Forms.Label();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbJabatan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnSembunyiPass = new DevComponents.DotNetBar.LabelX();
            this.btnLihatPass = new DevComponents.DotNetBar.LabelX();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtUser = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnLogin = new DevComponents.DotNetBar.ButtonX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.warningLogin = new DevComponents.DotNetBar.Controls.WarningBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIpAddress
            // 
            this.lblIpAddress.AutoSize = true;
            this.lblIpAddress.Location = new System.Drawing.Point(12, 99);
            this.lblIpAddress.Name = "lblIpAddress";
            this.lblIpAddress.Size = new System.Drawing.Size(57, 13);
            this.lblIpAddress.TabIndex = 3;
            this.lblIpAddress.Text = "Ip Address";
            this.lblIpAddress.Visible = false;
            // 
            // lblHostName
            // 
            this.lblHostName.AutoSize = true;
            this.lblHostName.Location = new System.Drawing.Point(418, 99);
            this.lblHostName.Name = "lblHostName";
            this.lblHostName.Size = new System.Drawing.Size(60, 13);
            this.lblHostName.TabIndex = 4;
            this.lblHostName.Text = "Host Name";
            this.lblHostName.Visible = false;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel1.Controls.Add(this.cmbJabatan);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.btnSembunyiPass);
            this.groupPanel1.Controls.Add(this.btnLihatPass);
            this.groupPanel1.Controls.Add(this.circularProgress1);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.txtPass);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.txtUser);
            this.highlighter1.SetHighlightOnFocus(this.groupPanel1, true);
            this.groupPanel1.Location = new System.Drawing.Point(39, 128);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(413, 213);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(217)))), ((int)(((byte)(185)))));
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(191)))), ((int)(((byte)(139)))));
            this.groupPanel1.Style.BackColorGradientAngle = 20;
            this.groupPanel1.Style.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupPanel1.Style.BackgroundImage")));
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(164)))), ((int)(((byte)(90)))));
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(74)))), ((int)(((byte)(31)))));
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 6;
            // 
            // cmbJabatan
            // 
            this.cmbJabatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbJabatan.DisplayMember = "Text";
            this.cmbJabatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJabatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJabatan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbJabatan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJabatan.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbJabatan, true);
            this.cmbJabatan.ItemHeight = 21;
            this.cmbJabatan.Location = new System.Drawing.Point(86, 54);
            this.cmbJabatan.Name = "cmbJabatan";
            this.cmbJabatan.Size = new System.Drawing.Size(288, 27);
            this.cmbJabatan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbJabatan.TabIndex = 20;
            this.cmbJabatan.WatermarkFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJabatan.WatermarkText = "-- pilih jabatan --";
            this.cmbJabatan.SelectedValueChanged += new System.EventHandler(this.cmbJabatan_SelectedValueChanged);
            this.cmbJabatan.Click += new System.EventHandler(this.cmbJabatan_Click);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(54, 54);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(26, 27);
            this.labelX3.Symbol = "";
            this.labelX3.SymbolColor = System.Drawing.Color.White;
            this.labelX3.TabIndex = 19;
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
            this.btnSembunyiPass.Location = new System.Drawing.Point(346, 148);
            this.btnSembunyiPass.Name = "btnSembunyiPass";
            this.btnSembunyiPass.SingleLineColor = System.Drawing.Color.Transparent;
            this.btnSembunyiPass.Size = new System.Drawing.Size(25, 23);
            this.btnSembunyiPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnSembunyiPass.Symbol = "";
            this.btnSembunyiPass.SymbolColor = System.Drawing.SystemColors.Desktop;
            this.btnSembunyiPass.TabIndex = 18;
            this.btnSembunyiPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSembunyiPass.Click += new System.EventHandler(this.btnSembunyiPass_Click);
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
            this.btnLihatPass.Location = new System.Drawing.Point(346, 148);
            this.btnLihatPass.Name = "btnLihatPass";
            this.btnLihatPass.SingleLineColor = System.Drawing.Color.Transparent;
            this.btnLihatPass.Size = new System.Drawing.Size(25, 23);
            this.btnLihatPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.btnLihatPass.Symbol = "";
            this.btnLihatPass.SymbolColor = System.Drawing.SystemColors.Desktop;
            this.btnLihatPass.TabIndex = 17;
            this.btnLihatPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLihatPass.Click += new System.EventHandler(this.btnLihatPass_Click);
            // 
            // circularProgress1
            // 
            this.circularProgress1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.Location = new System.Drawing.Point(17, 11);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress1.ProgressColor = System.Drawing.Color.AliceBlue;
            this.circularProgress1.Size = new System.Drawing.Size(28, 23);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Menghubungkan ke server...";
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
            this.txtPass.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtPass, true);
            this.txtPass.Location = new System.Drawing.Point(86, 145);
            this.txtPass.MaxLength = 15;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(288, 29);
            this.txtPass.TabIndex = 4;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.WatermarkFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.WatermarkText = "Masukkan kata sandi";
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(54, 145);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(26, 29);
            this.labelX2.Symbol = "";
            this.labelX2.SymbolColor = System.Drawing.Color.White;
            this.labelX2.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(54, 98);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(26, 29);
            this.labelX1.Symbol = "";
            this.labelX1.SymbolColor = System.Drawing.Color.White;
            this.labelX1.TabIndex = 2;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtUser.Border.Class = "TextBoxBorder";
            this.txtUser.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtUser.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtUser.FocusHighlightEnabled = true;
            this.txtUser.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtUser, true);
            this.txtUser.Location = new System.Drawing.Point(86, 98);
            this.txtUser.MaxLength = 10;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(288, 29);
            this.txtUser.TabIndex = 0;
            this.txtUser.WatermarkFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.WatermarkText = "Masukkan nama pengguna";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLogin.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(39, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(413, 41);
            this.btnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLogin.Symbol = "";
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Masuk";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // warningLogin
            // 
            this.warningLogin.BackColor = System.Drawing.Color.White;
            this.warningLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warningLogin.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warningLogin.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.warningLogin, true);
            this.warningLogin.Image = ((System.Drawing.Image)(resources.GetObject("warningLogin.Image")));
            this.warningLogin.Location = new System.Drawing.Point(91, 72);
            this.warningLogin.Name = "warningLogin";
            this.warningLogin.OptionsButtonVisible = false;
            this.warningLogin.OptionsText = "";
            this.warningLogin.Size = new System.Drawing.Size(314, 40);
            this.warningLogin.TabIndex = 27;
            this.warningLogin.Text = "<b>Peringatan</b> Nama pengguna atau kata sandi tidak valid.";
            this.warningLogin.CloseClick += new System.EventHandler(this.warningLogin_CloseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SimkapSmartClient.Properties.Resources.bg_login_fix;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 72);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 423);
            this.Controls.Add(this.warningLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHostName);
            this.Controls.Add(this.lblIpAddress);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Klien - SIMKAP 1.0.0";
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIpAddress;
        private System.Windows.Forms.Label lblHostName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPass;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUser;
        private DevComponents.DotNetBar.ButtonX btnLogin;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private System.Windows.Forms.Timer timer1;
        private DevComponents.DotNetBar.LabelX btnSembunyiPass;
        private DevComponents.DotNetBar.LabelX btnLihatPass;
        private DevComponents.DotNetBar.Controls.WarningBox warningLogin;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbJabatan;
        private DevComponents.DotNetBar.LabelX labelX3;

        #region Variabel

        private IntRemoteWriteTransactionClient rwc;
        private string obj;
        private SettingIpAddress setting = new SettingIpAddress();
        private IntRemoteLoginClient rlc;
        private EntLoginPegawai elp;
        private EntRemoteTransactionClient rc;
        private EventArgs el;
        private ThreadStart client1;
        private Thread client2;
        private Thread mThread;
        private object sender;
        private string data;
        private string sendIpServer;
        private string sendHostServer;
        private string sendNama;
        private string jabatan;
        private bool condition;

        #endregion
    }
}