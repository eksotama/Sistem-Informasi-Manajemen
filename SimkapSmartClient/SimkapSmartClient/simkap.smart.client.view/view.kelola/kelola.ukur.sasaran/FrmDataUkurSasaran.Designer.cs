using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.ukur.sasaran
{
    partial class FrmDataUkurSasaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDataUkurSasaran));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtPeriodeAkhir = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblakhir = new DevComponents.DotNetBar.LabelX();
            this.dtPeriodeAwal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.lblawal = new DevComponents.DotNetBar.LabelX();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.reflectionImage1 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.btnSearchData = new DevComponents.DotNetBar.ButtonX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel7 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvDataUkurSasaran = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUkurSasaran)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.dtPeriodeAkhir);
            this.panel2.Controls.Add(this.lblakhir);
            this.panel2.Controls.Add(this.dtPeriodeAwal);
            this.panel2.Controls.Add(this.lblawal);
            this.panel2.Controls.Add(this.reflectionLabel1);
            this.panel2.Controls.Add(this.reflectionImage1);
            this.panel2.Controls.Add(this.btnSearchData);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1175, 78);
            this.panel2.TabIndex = 82;
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
            this.dtPeriodeAkhir.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAkhir.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAkhir.IsPopupCalendarOpen = false;
            this.dtPeriodeAkhir.Location = new System.Drawing.Point(882, 43);
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
            this.dtPeriodeAkhir.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
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
            this.dtPeriodeAkhir.TabIndex = 105;
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
            this.lblakhir.Location = new System.Drawing.Point(882, 14);
            this.lblakhir.Name = "lblakhir";
            this.lblakhir.Size = new System.Drawing.Size(174, 23);
            this.lblakhir.TabIndex = 104;
            this.lblakhir.Text = "Periode Akhir";
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
            this.dtPeriodeAwal.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAwal.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAwal.IsPopupCalendarOpen = false;
            this.dtPeriodeAwal.Location = new System.Drawing.Point(630, 43);
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
            this.dtPeriodeAwal.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
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
            this.dtPeriodeAwal.TabIndex = 103;
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
            this.lblawal.Location = new System.Drawing.Point(630, 14);
            this.lblawal.Name = "lblawal";
            this.lblawal.Size = new System.Drawing.Size(162, 23);
            this.lblawal.TabIndex = 102;
            this.lblawal.Text = "Periode Awal";
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
            this.reflectionLabel1.Location = new System.Drawing.Point(69, 4);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(313, 70);
            this.reflectionLabel1.TabIndex = 95;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Data Ukur Sasaran</font></font></b>";
            // 
            // reflectionImage1
            // 
            // 
            // 
            // 
            this.reflectionImage1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.reflectionImage1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.reflectionImage1.Image = global::SimkapSmartClient.Properties.Resources.bg_data;
            this.reflectionImage1.Location = new System.Drawing.Point(-20, 3);
            this.reflectionImage1.Name = "reflectionImage1";
            this.reflectionImage1.Size = new System.Drawing.Size(110, 71);
            this.reflectionImage1.TabIndex = 94;
            // 
            // btnSearchData
            // 
            this.btnSearchData.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSearchData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearchData.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchData.Location = new System.Drawing.Point(1112, 42);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSearchData.Size = new System.Drawing.Size(45, 27);
            this.btnSearchData.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSearchData.TabIndex = 80;
            this.btnSearchData.Text = "Cari";
            this.btnSearchData.Click += new System.EventHandler(this.btnSearchData_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 93);
            this.panel1.TabIndex = 85;
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
            this.btnClose.TabIndex = 78;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupPanel7
            // 
            this.groupPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel7.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel7.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel7.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel7.Controls.Add(this.splitContainer1);
            this.groupPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel7.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel7.Location = new System.Drawing.Point(0, 78);
            this.groupPanel7.Name = "groupPanel7";
            this.groupPanel7.Size = new System.Drawing.Size(1175, 357);
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
            this.groupPanel7.TabIndex = 86;
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
            this.splitContainer1.Panel2.Controls.Add(this.dgvDataUkurSasaran);
            this.splitContainer1.Size = new System.Drawing.Size(1169, 351);
            this.splitContainer1.SplitterDistance = 260;
            this.splitContainer1.TabIndex = 6;
            // 
            // dgvDataUkurSasaran
            // 
            this.dgvDataUkurSasaran.AllowUserToAddRows = false;
            this.dgvDataUkurSasaran.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDataUkurSasaran.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDataUkurSasaran.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataUkurSasaran.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataUkurSasaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataUkurSasaran.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataUkurSasaran.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDataUkurSasaran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataUkurSasaran.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDataUkurSasaran.Location = new System.Drawing.Point(0, 0);
            this.dgvDataUkurSasaran.Name = "dgvDataUkurSasaran";
            this.dgvDataUkurSasaran.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvDataUkurSasaran.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataUkurSasaran.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDataUkurSasaran.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDataUkurSasaran.SelectAllSignVisible = false;
            this.dgvDataUkurSasaran.Size = new System.Drawing.Size(1169, 351);
            this.dgvDataUkurSasaran.TabIndex = 2;
            // 
            // FrmDataUkurSasaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 528);
            this.Controls.Add(this.groupPanel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataUkurSasaran";
            this.Text = "Data Ukur Sasaran - SIMKAP 1.0.0";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupPanel7.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataUkurSasaran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage1;
        private DevComponents.DotNetBar.ButtonX btnSearchData;
        private Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel7;
        private SplitContainer splitContainer1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDataUkurSasaran;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAkhir;
        private DevComponents.DotNetBar.LabelX lblakhir;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAwal;
        private DevComponents.DotNetBar.LabelX lblawal;

        #region Variabel

        private IntRemoteUkurSasaran iuk;
        private EntUkurSasaran euk;
        private Action<Form> viewForm;
        private FrmMenuClient frmmenuclient;
        private DataTable dt;
        private ThreadStart client1;
        private Thread client2;
        private Thread mThread;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private string sendJabatan;
        private string sendIpAddress;
        private string sendNama;
        private string message;
        private string obj;
        private string process;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion
    }
}