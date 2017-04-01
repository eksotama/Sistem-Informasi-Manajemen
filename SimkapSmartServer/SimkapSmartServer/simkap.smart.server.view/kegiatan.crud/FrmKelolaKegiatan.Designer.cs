using System;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view.kegiatan.crud
{
    partial class FrmKelolaKegiatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKelolaKegiatan));
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.lblKeterangan = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtKegiatan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.cmbSatuan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbJenis = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txtOutput = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbStatus = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKeterangan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelNotifikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(220, 27);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(514, 38);
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
            this.panelNotifikasi.TabIndex = 46;
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
            // lblKeterangan
            // 
            this.lblKeterangan.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblKeterangan.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblKeterangan.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.Black;
            this.lblKeterangan.Location = new System.Drawing.Point(34, 27);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(180, 33);
            this.lblKeterangan.Style = DevComponents.DotNetBar.eDotNetBarStyle.Metro;
            this.lblKeterangan.TabIndex = 45;
            this.lblKeterangan.Text = "Keterangan";
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
            this.labelX4.Location = new System.Drawing.Point(67, 85);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(92, 23);
            this.labelX4.TabIndex = 47;
            this.labelX4.Text = "Kegiatan";
            // 
            // txtKegiatan
            // 
            this.txtKegiatan.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtKegiatan.Border.Class = "TextBoxBorder";
            this.txtKegiatan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKegiatan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtKegiatan.FocusHighlightEnabled = true;
            this.txtKegiatan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKegiatan.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtKegiatan, true);
            this.txtKegiatan.Location = new System.Drawing.Point(267, 84);
            this.txtKegiatan.Multiline = true;
            this.txtKegiatan.Name = "txtKegiatan";
            this.txtKegiatan.Size = new System.Drawing.Size(467, 55);
            this.txtKegiatan.TabIndex = 48;
            this.txtKegiatan.Click += new System.EventHandler(this.txtKegiatan_Click);
            this.txtKegiatan.TextChanged += new System.EventHandler(this.txtKegiatan_TextChanged);
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // cmbSatuan
            // 
            this.cmbSatuan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSatuan.DisplayMember = "Text";
            this.cmbSatuan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSatuan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbSatuan.FocusHighlightEnabled = true;
            this.cmbSatuan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSatuan.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbSatuan, true);
            this.cmbSatuan.ItemHeight = 21;
            this.cmbSatuan.Location = new System.Drawing.Point(267, 204);
            this.cmbSatuan.Name = "cmbSatuan";
            this.cmbSatuan.Size = new System.Drawing.Size(163, 27);
            this.cmbSatuan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbSatuan.TabIndex = 60;
            this.cmbSatuan.WatermarkText = "-- pilih satuan --";
            this.cmbSatuan.SelectedValueChanged += new System.EventHandler(this.cmbSatuan_SelectedValueChanged);
            // 
            // cmbJenis
            // 
            this.cmbJenis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbJenis.DisplayMember = "Text";
            this.cmbJenis.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenis.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbJenis.FocusHighlightEnabled = true;
            this.cmbJenis.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenis.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbJenis, true);
            this.cmbJenis.ItemHeight = 21;
            this.cmbJenis.Location = new System.Drawing.Point(267, 159);
            this.cmbJenis.Name = "cmbJenis";
            this.cmbJenis.Size = new System.Drawing.Size(257, 27);
            this.cmbJenis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbJenis.TabIndex = 58;
            this.cmbJenis.WatermarkText = "-- pilih jenis kegiatan --";
            this.cmbJenis.SelectedValueChanged += new System.EventHandler(this.cmbJenis_SelectedValueChanged);
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtOutput.Border.Class = "TextBoxBorder";
            this.txtOutput.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtOutput.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.txtOutput.FocusHighlightEnabled = true;
            this.txtOutput.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.ForeColor = System.Drawing.Color.Black;
            this.highlighter1.SetHighlightOnFocus(this.txtOutput, true);
            this.txtOutput.Location = new System.Drawing.Point(267, 334);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(318, 27);
            this.txtOutput.TabIndex = 61;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            this.txtOutput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOutput_KeyPress);
            // 
            // cmbStatus
            // 
            this.cmbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStatus.DisplayMember = "Text";
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbStatus.FocusHighlightEnabled = true;
            this.cmbStatus.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbStatus, true);
            this.cmbStatus.ItemHeight = 21;
            this.cmbStatus.Location = new System.Drawing.Point(267, 247);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(132, 27);
            this.cmbStatus.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbStatus.TabIndex = 65;
            this.cmbStatus.WatermarkText = "-- pilih status --";
            this.cmbStatus.SelectedValueChanged += new System.EventHandler(this.cmbStatus_SelectedValueChanged);
            // 
            // cmbKeterangan
            // 
            this.cmbKeterangan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbKeterangan.DisplayMember = "Text";
            this.cmbKeterangan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKeterangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKeterangan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbKeterangan.FocusHighlightEnabled = true;
            this.cmbKeterangan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKeterangan.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbKeterangan, true);
            this.cmbKeterangan.ItemHeight = 21;
            this.cmbKeterangan.Location = new System.Drawing.Point(267, 290);
            this.cmbKeterangan.Name = "cmbKeterangan";
            this.cmbKeterangan.Size = new System.Drawing.Size(145, 27);
            this.cmbKeterangan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbKeterangan.TabIndex = 67;
            this.cmbKeterangan.WatermarkText = "-- pilih keterangan --";
            this.cmbKeterangan.SelectedValueChanged += new System.EventHandler(this.cmbKeterangan_SelectedValueChanged);
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
            this.labelX2.Location = new System.Drawing.Point(67, 160);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(71, 23);
            this.labelX2.TabIndex = 59;
            this.labelX2.Text = "Jenis";
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
            this.labelX3.Location = new System.Drawing.Point(67, 334);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(116, 23);
            this.labelX3.TabIndex = 57;
            this.labelX3.Text = "Output Kegiatan";
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
            this.labelX1.Location = new System.Drawing.Point(67, 204);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(71, 23);
            this.labelX1.TabIndex = 56;
            this.labelX1.Text = "Satuan";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(638, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(522, 389);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 62;
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
            this.labelX5.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.ForeColor = System.Drawing.Color.Black;
            this.labelX5.Location = new System.Drawing.Point(67, 247);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(71, 23);
            this.labelX5.TabIndex = 64;
            this.labelX5.Text = "Status";
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
            this.labelX6.Location = new System.Drawing.Point(67, 290);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(71, 23);
            this.labelX6.TabIndex = 66;
            this.labelX6.Text = "Keterangan";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.Info;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // FrmKelolaKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 469);
            this.Controls.Add(this.cmbKeterangan);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.cmbSatuan);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cmbJenis);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtKegiatan);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.panelNotifikasi);
            this.Controls.Add(this.lblKeterangan);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKelolaKegiatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Kegiatan - SIMKAP 1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKelolaKegiatan_FormClosing);
            this.panelNotifikasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;
        private DevComponents.DotNetBar.LabelX lblKeterangan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKegiatan;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbSatuan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbJenis;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtOutput;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbStatus;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKeterangan;
        private DevComponents.DotNetBar.LabelX labelX6;

        #region Variabel

        private IntJenisKegiatan ijk;
        private IntKegiatan ik;
        private EntKegiatan ek;
        private Action setDataKegiatan;
        private Action setVisibleNotifikasiEditSucces;
        private FrmMenu frmMenu;
        private FrmKegiatan frmKegiatan;
        private EventArgs e;
        private object sender;
        private string receiveIp;
        private string receiveNama;
        private string receiveIdKegiatan;
        private string receiveProcess;
        private string log;
        private string message;
        private bool condition;
        private bool validation;

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
    }
}