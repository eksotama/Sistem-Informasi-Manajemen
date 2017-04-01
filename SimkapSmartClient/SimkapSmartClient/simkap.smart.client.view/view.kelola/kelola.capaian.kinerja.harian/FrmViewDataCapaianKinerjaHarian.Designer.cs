using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola
{
    partial class FrmViewDataCapaianKinerjaHarian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmViewDataCapaianKinerjaHarian));
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel2 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.panelData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvLCKH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panel2.SuspendLayout();
            this.panelNotifikasi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCKH)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(139, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnEdit.Size = new System.Drawing.Size(96, 37);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.Symbol = "";
            this.btnEdit.TabIndex = 87;
            this.btnEdit.Text = "Ubah";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(373, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 88;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(22, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 89;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(543, 52);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 20);
            this.dtDate.TabIndex = 90;
            this.dtDate.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panelNotifikasi);
            this.panel2.Controls.Add(this.dtDate);
            this.panel2.Controls.Add(this.reflectionLabel2);
            this.panel2.Controls.Add(this.reflectionImage2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 78);
            this.panel2.TabIndex = 98;
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(435, 12);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(722, 38);
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
            this.panelNotifikasi.TabIndex = 99;
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
            this.lblTextNotifikasi.Text = "Anda berhasil meruba<b></b>h data";
            // 
            // reflectionLabel2
            // 
            this.reflectionLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.reflectionLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.reflectionLabel2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionLabel2.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflectionLabel2.ForeColor = System.Drawing.Color.Black;
            this.reflectionLabel2.Location = new System.Drawing.Point(64, 4);
            this.reflectionLabel2.Name = "reflectionLabel2";
            this.reflectionLabel2.Size = new System.Drawing.Size(365, 70);
            this.reflectionLabel2.TabIndex = 98;
            this.reflectionLabel2.Text = "<b><font size=\"+12\"><font color=\"#0000\">Data Capaian Kinerja Harian</font></font>" +
    "</b>";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 432);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 93);
            this.panel1.TabIndex = 99;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(256, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.TabIndex = 120;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelData.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.panelData.Controls.Add(this.dgvLCKH);
            this.panelData.Controls.Add(this.richTextBoxEx2);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelData.Location = new System.Drawing.Point(0, 78);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1169, 354);
            // 
            // 
            // 
            this.panelData.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.Style.BackColorGradientAngle = 90;
            this.panelData.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.panelData.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.panelData.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelData.Style.BorderBottomWidth = 1;
            this.panelData.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.panelData.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.panelData.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.panelData.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.panelData.Style.BorderLeftWidth = 1;
            this.panelData.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.panelData.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.panelData.Style.BorderRightWidth = 1;
            this.panelData.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.panelData.Style.BorderTopWidth = 1;
            this.panelData.Style.CornerDiameter = 4;
            this.panelData.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.panelData.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelData.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.panelData.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelData.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.panelData.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.panelData.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.panelData.TabIndex = 100;
            // 
            // dgvLCKH
            // 
            this.dgvLCKH.AllowUserToAddRows = false;
            this.dgvLCKH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvLCKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLCKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLCKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLCKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLCKH.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLCKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLCKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLCKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvLCKH.Location = new System.Drawing.Point(0, 0);
            this.dgvLCKH.Name = "dgvLCKH";
            this.dgvLCKH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvLCKH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLCKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvLCKH.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLCKH.SelectAllSignVisible = false;
            this.dgvLCKH.Size = new System.Drawing.Size(1163, 348);
            this.dgvLCKH.TabIndex = 1;
            this.dgvLCKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLCKH_CellClick);
            this.dgvLCKH.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvLCKH_RowPostPaint);
            this.dgvLCKH.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvLCKH_MouseMove);
            // 
            // richTextBoxEx2
            // 
            this.richTextBoxEx2.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx2.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx2.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx2.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx2.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx2.Name = "richTextBoxEx2";
            this.richTextBoxEx2.ReadOnly = true;
            this.richTextBoxEx2.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx2.Size = new System.Drawing.Size(1163, 348);
            this.richTextBoxEx2.TabIndex = 0;
            // 
            // reflectionImage2
            // 
            this.reflectionImage2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.reflectionImage2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage2.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage2.Image = global::SimkapSmartClient.Properties.Resources.bg_data;
            this.reflectionImage2.Location = new System.Drawing.Point(-23, 3);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(110, 71);
            this.reflectionImage2.TabIndex = 96;
            // 
            // FrmViewDataCapaianKinerjaHarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 525);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmViewDataCapaianKinerjaHarian";
            this.Text = "Data Capaian Kinerja Harian - SIMKAP 1.0.0";
            this.panel2.ResumeLayout(false);
            this.panelNotifikasi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLCKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DateTimePicker dtDate;
        private Panel panel2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel2;
        private Panel panel1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLCKH;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx2;
        private DevComponents.DotNetBar.ButtonX btnDelete;

        #region Variabel

        private IntRemoteLCKH irl;
        private IntRemoteWriteTransactionClient rwc;
        private EntLoginPegawai elp;
        private EntLCKH elc;
        private EntRemoteTransactionClient etc;
        private ThreadStart client1;
        private Thread client2;
        private Thread mThread;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private Action<Form> viewForm;
        private FrmMenuKelola frmmenukelola;
        private FrmMenuClient frmMenuClient;
        private string sendjabatan;
        private string sendipaddress;
        private string sendnama;
        private string data;
        private string obj;
        private string message;
        private string sendstatuskegiatan;
        private string sendiddetaikegiatan;
        private string sendidcapaian;
        private string sendvolume;
        private string process;
        private bool condition;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion
    }
}