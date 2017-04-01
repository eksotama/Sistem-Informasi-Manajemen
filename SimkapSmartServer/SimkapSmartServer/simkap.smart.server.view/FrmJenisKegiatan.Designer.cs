using System.Drawing;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view
{
    partial class FrmJenisKegiatan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJenisKegiatan));
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnEdit = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.panelData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvJenisKegiatan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.panelNotifikasi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblTextNotifikasi = new DevComponents.DotNetBar.LabelX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKegiatan)).BeginInit();
            this.panelNotifikasi.SuspendLayout();
            this.SuspendLayout();
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(501, 396);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 41;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(33, 396);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 40;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(267, 396);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnEdit.Size = new System.Drawing.Size(96, 37);
            this.btnEdit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnEdit.Symbol = "";
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Ubah";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(150, 396);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "";
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelData.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.panelData.Controls.Add(this.dgvJenisKegiatan);
            this.panelData.Controls.Add(this.richTextBoxEx2);
            this.panelData.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelData.Location = new System.Drawing.Point(33, 104);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(613, 263);
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
            this.panelData.TabIndex = 44;
            // 
            // dgvJenisKegiatan
            // 
            this.dgvJenisKegiatan.AllowUserToAddRows = false;
            this.dgvJenisKegiatan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvJenisKegiatan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvJenisKegiatan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJenisKegiatan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJenisKegiatan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJenisKegiatan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJenisKegiatan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJenisKegiatan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvJenisKegiatan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvJenisKegiatan.Location = new System.Drawing.Point(0, 0);
            this.dgvJenisKegiatan.Name = "dgvJenisKegiatan";
            this.dgvJenisKegiatan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvJenisKegiatan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvJenisKegiatan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvJenisKegiatan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvJenisKegiatan.SelectAllSignVisible = false;
            this.dgvJenisKegiatan.Size = new System.Drawing.Size(607, 257);
            this.dgvJenisKegiatan.TabIndex = 1;
            this.dgvJenisKegiatan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJenisKegiatan_CellClick);
            this.dgvJenisKegiatan.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvJenisKegiatan_RowPostPaint);
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
            this.richTextBoxEx2.Size = new System.Drawing.Size(607, 257);
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
            this.reflectionImage2.Image = global::SimkapSmartServer.Properties.Resources.bg_data;
            this.reflectionImage2.Location = new System.Drawing.Point(10, 27);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(110, 71);
            this.reflectionImage2.TabIndex = 104;
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
            this.reflectionLabel1.Location = new System.Drawing.Point(100, 28);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(258, 70);
            this.reflectionLabel1.TabIndex = 105;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Data Jenis Kegiatan</font></font></b>";
            // 
            // panelNotifikasi
            // 
            this.panelNotifikasi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelNotifikasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelNotifikasi.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelNotifikasi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelNotifikasi.Controls.Add(this.lblTextNotifikasi);
            this.panelNotifikasi.Location = new System.Drawing.Point(358, 37);
            this.panelNotifikasi.Name = "panelNotifikasi";
            this.panelNotifikasi.Size = new System.Drawing.Size(288, 38);
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
            this.panelNotifikasi.TabIndex = 106;
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
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(384, 396);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.TabIndex = 111;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmJenisKegiatan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 459);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panelNotifikasi);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage2);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJenisKegiatan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jenis Kegiatan - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmJenisKegiatan_MouseMove);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJenisKegiatan)).EndInit();
            this.panelNotifikasi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnEdit;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.GroupPanel panelData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvJenisKegiatan;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx2;
        private DevComponents.DotNetBar.Controls.GroupPanel panelNotifikasi;
        private DevComponents.DotNetBar.LabelX lblTextNotifikasi;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.ButtonX btnDelete;

        #region Variabel

        private IntJenisKegiatan ijk;
        private EntJenisKegiatan ejk;
        private FrmMenu frmMenu;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private string log;
        private string message;
        private string sendProcess;
        private string receiveNama;
        private string receiveIp;
        private string sendIdJnsKegiatan;
        private string sendJenis;
        private bool condition;

        #endregion
    }
}