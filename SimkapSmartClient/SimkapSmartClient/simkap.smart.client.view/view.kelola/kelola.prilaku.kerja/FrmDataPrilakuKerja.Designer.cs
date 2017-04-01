using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.prilaku.kerja
{
    partial class FrmDataPrilakuKerja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataPrilakuKerja));
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnSearch = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel7 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDataPrilakuKerja = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dtPeriodeAkhir = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtPeriodeAwal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblakhir = new DevComponents.DotNetBar.LabelX();
            this.lblawal = new DevComponents.DotNetBar.LabelX();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.panelNotifikasi.SuspendLayout();
            this.groupPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPrilakuKerja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(390, 52);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(563, 38);
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
            this.panelNotifikasi.TabIndex = 98;
            // 
            // lblTextNotifikasi
            // 
            this.lblTextNotifikasi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblTextNotifikasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblTextNotifikasi.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextNotifikasi.Location = new System.Drawing.Point(3, 1);
            this.lblTextNotifikasi.Name = "lblTextNotifikasi";
            this.lblTextNotifikasi.Size = new System.Drawing.Size(206, 29);
            this.lblTextNotifikasi.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblTextNotifikasi.Symbol = "";
            this.lblTextNotifikasi.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTextNotifikasi.TabIndex = 45;
            this.lblTextNotifikasi.Text = "Anda berhasil meruba<b></b>h data";
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
            this.reflectionLabel1.Location = new System.Drawing.Point(129, 48);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(252, 69);
            this.reflectionLabel1.TabIndex = 97;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Data Perilaku Kerja</font></font></b>";
            // 
            // btnSearch
            // 
            this.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(905, 96);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSearch.Size = new System.Drawing.Size(45, 27);
            this.btnSearch.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearch.TabIndex = 80;
            this.btnSearch.Text = "Cari";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(63, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(301, 337);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(182, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnEdit.Size = new System.Drawing.Size(96, 37);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.Symbol = "";
            this.btnEdit.TabIndex = 83;
            this.btnEdit.Text = "Ubah";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupPanel7
            // 
            this.groupPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel7.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel7.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel7.Controls.Add(this.splitContainer1);
            this.groupPanel7.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel7.Location = new System.Drawing.Point(63, 130);
            this.groupPanel7.Name = "groupPanel7";
            this.groupPanel7.Size = new System.Drawing.Size(890, 177);
            // 
            // 
            // 
            this.groupPanel7.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel7.Style.BackColorGradientAngle = 90;
            this.groupPanel7.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel7.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel7.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel7.Style.BorderBottomWidth = 1;
            this.groupPanel7.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel7.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel7.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel7.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel7.Style.BorderLeftWidth = 1;
            this.groupPanel7.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel7.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel7.Style.BorderRightWidth = 1;
            this.groupPanel7.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel7.Style.BorderTopWidth = 1;
            this.groupPanel7.Style.CornerDiameter = 4;
            this.groupPanel7.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel7.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel7.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel7.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel7.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel7.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel7.TabIndex = 82;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDataPrilakuKerja);
            this.splitContainer1.Size = new System.Drawing.Size(884, 171);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvDataPrilakuKerja
            // 
            this.dgvDataPrilakuKerja.AllowUserToAddRows = false;
            this.dgvDataPrilakuKerja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDataPrilakuKerja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataPrilakuKerja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPrilakuKerja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataPrilakuKerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPrilakuKerja.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataPrilakuKerja.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataPrilakuKerja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataPrilakuKerja.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDataPrilakuKerja.Location = new System.Drawing.Point(0, 0);
            this.dgvDataPrilakuKerja.Name = "dgvDataPrilakuKerja";
            this.dgvDataPrilakuKerja.ReadOnly = true;
            this.dgvDataPrilakuKerja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDataPrilakuKerja.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataPrilakuKerja.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDataPrilakuKerja.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataPrilakuKerja.SelectAllSignVisible = false;
            this.dgvDataPrilakuKerja.Size = new System.Drawing.Size(884, 171);
            this.dgvDataPrilakuKerja.TabIndex = 2;
            this.dgvDataPrilakuKerja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPrilakuKerja_CellClick);
            this.dgvDataPrilakuKerja.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDataPrilakuKerja_RowPostPaint);
            // 
            // dtPeriodeAkhir
            // 
            this.dtPeriodeAkhir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtPeriodeAkhir.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPeriodeAkhir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhir.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPeriodeAkhir.ButtonDropDown.Visible = true;
            this.dtPeriodeAkhir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPeriodeAkhir.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.dtPeriodeAkhir.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAkhir.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAkhir.IsPopupCalendarOpen = false;
            this.dtPeriodeAkhir.Location = new System.Drawing.Point(677, 96);
            // 
            // 
            // 
            this.dtPeriodeAkhir.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAkhir.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhir.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtPeriodeAkhir.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPeriodeAkhir.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhir.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dtPeriodeAkhir.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPeriodeAkhir.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAkhir.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPeriodeAkhir.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAkhir.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPeriodeAkhir.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhir.MonthCalendar.TodayButtonVisible = true;
            this.dtPeriodeAkhir.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPeriodeAkhir.Name = "dtPeriodeAkhir";
            this.dtPeriodeAkhir.Size = new System.Drawing.Size(224, 27);
            this.dtPeriodeAkhir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAkhir.TabIndex = 102;
            this.dtPeriodeAkhir.ValueChanged += new System.EventHandler(this.dtPeriodeAkhir_ValueChanged);
            // 
            // dtPeriodeAwal
            // 
            this.dtPeriodeAwal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.dtPeriodeAwal.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPeriodeAwal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwal.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPeriodeAwal.ButtonDropDown.Visible = true;
            this.dtPeriodeAwal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPeriodeAwal.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.dtPeriodeAwal.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAwal.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAwal.IsPopupCalendarOpen = false;
            this.dtPeriodeAwal.Location = new System.Drawing.Point(441, 96);
            // 
            // 
            // 
            this.dtPeriodeAwal.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAwal.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwal.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtPeriodeAwal.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPeriodeAwal.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwal.MonthCalendar.DisplayMonth = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.dtPeriodeAwal.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPeriodeAwal.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAwal.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPeriodeAwal.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAwal.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPeriodeAwal.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwal.MonthCalendar.TodayButtonVisible = true;
            this.dtPeriodeAwal.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPeriodeAwal.Name = "dtPeriodeAwal";
            this.dtPeriodeAwal.Size = new System.Drawing.Size(224, 27);
            this.dtPeriodeAwal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAwal.TabIndex = 99;
            // 
            // lblakhir
            // 
            this.lblakhir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblakhir.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblakhir.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblakhir.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblakhir.ForeColor = System.Drawing.Color.Black;
            this.lblakhir.Location = new System.Drawing.Point(677, 67);
            this.lblakhir.Name = "lblakhir";
            this.lblakhir.Size = new System.Drawing.Size(99, 23);
            this.lblakhir.TabIndex = 101;
            this.lblakhir.Text = "Periode Akhir";
            // 
            // lblawal
            // 
            this.lblawal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblawal.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblawal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblawal.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblawal.ForeColor = System.Drawing.Color.Black;
            this.lblawal.Location = new System.Drawing.Point(441, 67);
            this.lblawal.Name = "lblawal";
            this.lblawal.Size = new System.Drawing.Size(88, 23);
            this.lblawal.TabIndex = 100;
            this.lblawal.Text = "Periode Awal";
            // 
            // reflectionImage1
            // 
            this.reflectionImage1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::SimkapSmartClient.Properties.Resources.bg_data;
            this.reflectionImage1.Location = new System.Drawing.Point(40, 48);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(110, 71);
            this.reflectionImage1.TabIndex = 96;
            // 
            // FrmDataPrilakuKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 398);
            this.Controls.Add(this.dtPeriodeAkhir);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtPeriodeAwal);
            this.Controls.Add(this.lblawal);
            this.Controls.Add(this.panelNotifikasi);
            this.Controls.Add(this.lblakhir);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupPanel7);
            this.Controls.Add(this.reflectionImage1);
            this.Controls.Add(this.btnEdit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataPrilakuKerja";
            this.Text = "Data Prilaku Kerja - SIMKAP 1.0.0";
            this.panelNotifikasi.ResumeLayout(false);
            this.groupPanel7.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPrilakuKerja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnSearch;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDataPrilakuKerja;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAkhir;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAwal;
        private DevComponents.DotNetBar.LabelX lblakhir;
        private DevComponents.DotNetBar.LabelX lblawal;

        #region Variabel

        private IntRemotePrilakuKerja ipl;
        private EntPrilakukerja epk;
        private ThreadStart client1;
        private Thread client2;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private Action<Form> viewForm;
        private FrmMenuClient frmmenuclient;
        private FrmMenuKelola frmmenukelola;
        private string sendIpAddress;
        private string sendNama;
        private string sendJabatan;
        private int sendIdPrilaku;
        private double sendOrientasi;
        private double sendIntegritas;
        private double sendKomitmen;
        private double sendDisiplin;
        private double sendKerjasama;
        private double sendKepemimpinan;
        private double sendJumlah;
        private double sendNilaiRata;
        private string process;
        private string obj;
        private string message;
        private bool condition;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion
    }
}