using System;
using System.Threading;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartClient.simkap.smart.client.view.view.kelola.kelola.get.all
{
    partial class FrmChoosePenilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChoosePenilai));
            this.dtPeriodeAkhir = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtPeriodeAwal = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnNext = new DevComponents.DotNetBar.ButtonX();
            this.cmbAtasanPenilai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbPenilai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).BeginInit();
            this.SuspendLayout();
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
            this.dtPeriodeAkhir.Location = new System.Drawing.Point(295, 132);
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
            this.dtPeriodeAkhir.Size = new System.Drawing.Size(225, 27);
            this.dtPeriodeAkhir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAkhir.TabIndex = 127;
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
            this.dtPeriodeAwal.Location = new System.Drawing.Point(295, 89);
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
            this.dtPeriodeAwal.Size = new System.Drawing.Size(225, 27);
            this.dtPeriodeAwal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtPeriodeAwal.TabIndex = 126;
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
            this.labelX4.Location = new System.Drawing.Point(78, 132);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 125;
            this.labelX4.Text = "Periode Akhir";
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
            this.labelX2.Location = new System.Drawing.Point(78, 93);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(92, 23);
            this.labelX2.TabIndex = 124;
            this.labelX2.Text = "Periode Awal";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(462, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNext.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(324, 274);
            this.btnNext.Name = "btnNext";
            this.btnNext.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnNext.Size = new System.Drawing.Size(112, 37);
            this.btnNext.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnNext.Symbol = "";
            this.btnNext.TabIndex = 122;
            this.btnNext.Text = "Selanjutnya";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cmbAtasanPenilai
            // 
            this.cmbAtasanPenilai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbAtasanPenilai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAtasanPenilai.DisplayMember = "Text";
            this.cmbAtasanPenilai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAtasanPenilai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtasanPenilai.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbAtasanPenilai.FocusHighlightEnabled = true;
            this.cmbAtasanPenilai.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtasanPenilai.FormattingEnabled = true;
            this.cmbAtasanPenilai.ItemHeight = 21;
            this.cmbAtasanPenilai.Location = new System.Drawing.Point(295, 218);
            this.cmbAtasanPenilai.Name = "cmbAtasanPenilai";
            this.cmbAtasanPenilai.Size = new System.Drawing.Size(263, 27);
            this.cmbAtasanPenilai.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.cmbAtasanPenilai.TabIndex = 121;
            this.cmbAtasanPenilai.WatermarkText = "-- pilih atasan pejabat penilai  --";
            this.cmbAtasanPenilai.SelectedValueChanged += new System.EventHandler(this.cmbAtasanPenilai_SelectedValueChanged);
            this.cmbAtasanPenilai.Click += new System.EventHandler(this.cmbAtasanPenilai_Click);
            // 
            // cmbPenilai
            // 
            this.cmbPenilai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbPenilai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPenilai.DisplayMember = "Text";
            this.cmbPenilai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPenilai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenilai.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbPenilai.FocusHighlightEnabled = true;
            this.cmbPenilai.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPenilai.FormattingEnabled = true;
            this.cmbPenilai.ItemHeight = 21;
            this.cmbPenilai.Location = new System.Drawing.Point(295, 176);
            this.cmbPenilai.Name = "cmbPenilai";
            this.cmbPenilai.Size = new System.Drawing.Size(263, 27);
            this.cmbPenilai.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.cmbPenilai.TabIndex = 120;
            this.cmbPenilai.WatermarkText = "-- pilih pejabat penilai  --";
            this.cmbPenilai.SelectedValueChanged += new System.EventHandler(this.cmbPenilai_SelectedValueChanged);
            this.cmbPenilai.Click += new System.EventHandler(this.cmbPenilai_Click);
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
            this.labelX1.Location = new System.Drawing.Point(78, 218);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(138, 23);
            this.labelX1.TabIndex = 119;
            this.labelX1.Text = "Atasan Pejabat Penilai";
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
            this.labelX3.Location = new System.Drawing.Point(78, 176);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(92, 23);
            this.labelX3.TabIndex = 118;
            this.labelX3.Text = "Pejabat Penilai";
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
            this.labelX5.Location = new System.Drawing.Point(40, 35);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(518, 33);
            this.labelX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.labelX5.TabIndex = 117;
            this.labelX5.Text = "Tambah Penilai";
            // 
            // FrmChoosePenilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 347);
            this.Controls.Add(this.dtPeriodeAkhir);
            this.Controls.Add(this.dtPeriodeAwal);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cmbAtasanPenilai);
            this.Controls.Add(this.cmbPenilai);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX5);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChoosePenilai";
            this.Text = "Penilai  - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmChoosePenilai_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAkhir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtPeriodeAwal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAkhir;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtPeriodeAwal;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnNext;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbAtasanPenilai;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbPenilai;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX5;

        #region Variabel

        private IntRemotePenilai ip;
        private Action<Form> viewForm1;
        private ThreadStart client1;
        private Thread client2;
        private FrmMenuClient frmmenuclient;
        private string sendipaddress;
        private string sendnama;
        private string obj;
        private string sendidpenilai;
        private string sendidatasanpenilai;
        private string sendjabatan;
        private string procces;
        private SettingIpAddress setting = new SettingIpAddress();
        private EntValidationPeriode et;
        private string message;
        private bool condition;

        #endregion
    }
}