using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartClient.simkap.smart.client.setting.app;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartClient.simkap.smart.client.view.view.report.report.input
{
    partial class FrmChoosePeriodeMutasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoosePeriodeMutasi));
            this.dtPeriodeAkhirMutasi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnViewPrint = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dtPeriodeAwalMutasi = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhirMutasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwalMutasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPeriodeAkhirMutasi
            // 
            this.dtPeriodeAkhirMutasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPeriodeAkhirMutasi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtPeriodeAkhirMutasi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPeriodeAkhirMutasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhirMutasi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPeriodeAkhirMutasi.ButtonDropDown.Visible = true;
            this.dtPeriodeAkhirMutasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPeriodeAkhirMutasi.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAkhirMutasi.ForeColor = System.Drawing.Color.Black;
            this.dtPeriodeAkhirMutasi.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAkhirMutasi.IsPopupCalendarOpen = false;
            this.dtPeriodeAkhirMutasi.Location = new System.Drawing.Point(227, 128);
            // 
            // 
            // 
            this.dtPeriodeAkhirMutasi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAkhirMutasi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtPeriodeAkhirMutasi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPeriodeAkhirMutasi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhirMutasi.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.dtPeriodeAkhirMutasi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPeriodeAkhirMutasi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAkhirMutasi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPeriodeAkhirMutasi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAkhirMutasi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPeriodeAkhirMutasi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAkhirMutasi.MonthCalendar.TodayButtonVisible = true;
            this.dtPeriodeAkhirMutasi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPeriodeAkhirMutasi.Name = "dtPeriodeAkhirMutasi";
            this.dtPeriodeAkhirMutasi.Size = new System.Drawing.Size(225, 27);
            this.dtPeriodeAkhirMutasi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAkhirMutasi.TabIndex = 104;
            this.dtPeriodeAkhirMutasi.ValueChanged += new System.EventHandler(this.dtPeriodeAkhir_ValueChanged);
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
            this.labelX1.Location = new System.Drawing.Point(82, 128);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(92, 23);
            this.labelX1.TabIndex = 109;
            this.labelX1.Text = "Periode Akhir";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(356, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 105;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewPrint
            // 
            this.btnViewPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewPrint.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPrint.Location = new System.Drawing.Point(233, 181);
            this.btnViewPrint.Name = "btnViewPrint";
            this.btnViewPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnViewPrint.Size = new System.Drawing.Size(96, 37);
            this.btnViewPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewPrint.Symbol = "";
            this.btnViewPrint.TabIndex = 106;
            this.btnViewPrint.Text = "Lihat";
            this.btnViewPrint.Click += new System.EventHandler(this.btnViewPrint_Click);
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
            this.labelX5.Location = new System.Drawing.Point(49, 30);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(220, 33);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX5.TabIndex = 108;
            this.labelX5.Text = "Pilih Periode Mutasi";
            // 
            // dtPeriodeAwalMutasi
            // 
            this.dtPeriodeAwalMutasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtPeriodeAwalMutasi.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.dtPeriodeAwalMutasi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtPeriodeAwalMutasi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwalMutasi.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtPeriodeAwalMutasi.ButtonDropDown.Visible = true;
            this.dtPeriodeAwalMutasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPeriodeAwalMutasi.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPeriodeAwalMutasi.ForeColor = System.Drawing.Color.Black;
            this.dtPeriodeAwalMutasi.Format = DevComponents.Editors.eDateTimePickerFormat.Long;
            this.dtPeriodeAwalMutasi.IsPopupCalendarOpen = false;
            this.dtPeriodeAwalMutasi.Location = new System.Drawing.Point(227, 84);
            // 
            // 
            // 
            this.dtPeriodeAwalMutasi.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAwalMutasi.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwalMutasi.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtPeriodeAwalMutasi.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtPeriodeAwalMutasi.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwalMutasi.MonthCalendar.DisplayMonth = new System.DateTime(2016, 11, 1, 0, 0, 0, 0);
            this.dtPeriodeAwalMutasi.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtPeriodeAwalMutasi.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtPeriodeAwalMutasi.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtPeriodeAwalMutasi.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtPeriodeAwalMutasi.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtPeriodeAwalMutasi.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtPeriodeAwalMutasi.MonthCalendar.TodayButtonVisible = true;
            this.dtPeriodeAwalMutasi.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dtPeriodeAwalMutasi.Name = "dtPeriodeAwalMutasi";
            this.dtPeriodeAwalMutasi.Size = new System.Drawing.Size(225, 27);
            this.dtPeriodeAwalMutasi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAwalMutasi.TabIndex = 103;
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
            this.labelX4.Location = new System.Drawing.Point(82, 84);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 107;
            this.labelX4.Text = "Periode Awal";
            // 
            // FrmChoosePeriodeMutasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 249);
            this.Controls.Add(this.dtPeriodeAkhirMutasi);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnViewPrint);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dtPeriodeAwalMutasi);
            this.Controls.Add(this.labelX4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChoosePeriodeMutasi";
            this.Text = "Pilih Periode Laporan Mutasi - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmChoosePeriodeMutasi_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhirMutasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwalMutasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAkhirMutasi;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnViewPrint;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAwalMutasi;
        private DevComponents.DotNetBar.LabelX labelX4;

        #region Variabel

        private string periodeakhir;
        private string periodeawal;
        private string procces;
        private string sendJabatan;
        private string status;
        private string tanggal;
        private Action<Form> viewForm;
        private string message;
        private bool condition;
        private SettingIpAddress setting = new SettingIpAddress();
        private IntRemoteValidationReport ir;
        private EntLaporan el;
        private ThreadStart client1;
        private Thread client2;
        private string obj;

        #endregion
    }
}