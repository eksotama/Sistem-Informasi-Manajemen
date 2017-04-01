using System.Drawing;
using System.Windows.Forms;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.view
{
    partial class FrmPejabatPenilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPejabatPenilai));
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panelData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvPejabatPenilai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.reflectionImage2 = new DevComponents.DotNetBar.Controls.ReflectionImage();
            this.reflectionLabel1 = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPejabatPenilai)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(44, 397);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdd.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(161, 397);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnAdd.Size = new System.Drawing.Size(96, 37);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.Symbol = "";
            this.btnAdd.TabIndex = 24;
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
            this.panelData.Controls.Add(this.dgvPejabatPenilai);
            this.panelData.Controls.Add(this.richTextBoxEx2);
            this.panelData.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelData.Location = new System.Drawing.Point(44, 105);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(519, 263);
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
            this.panelData.TabIndex = 30;
            // 
            // dgvPejabatPenilai
            // 
            this.dgvPejabatPenilai.AllowUserToAddRows = false;
            this.dgvPejabatPenilai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPejabatPenilai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPejabatPenilai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPejabatPenilai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPejabatPenilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPejabatPenilai.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPejabatPenilai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPejabatPenilai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPejabatPenilai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvPejabatPenilai.Location = new System.Drawing.Point(0, 0);
            this.dgvPejabatPenilai.Name = "dgvPejabatPenilai";
            this.dgvPejabatPenilai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPejabatPenilai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPejabatPenilai.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvPejabatPenilai.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPejabatPenilai.SelectAllSignVisible = false;
            this.dgvPejabatPenilai.Size = new System.Drawing.Size(513, 257);
            this.dgvPejabatPenilai.TabIndex = 1;
            this.dgvPejabatPenilai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPejabatPenilai_CellClick);
            this.dgvPejabatPenilai.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvPejabatPenilai_RowPostPaint);
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
            this.richTextBoxEx2.Size = new System.Drawing.Size(513, 257);
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
            this.reflectionImage2.Location = new System.Drawing.Point(21, 32);
            this.reflectionImage2.Name = "reflectionImage2";
            this.reflectionImage2.Size = new System.Drawing.Size(110, 71);
            this.reflectionImage2.TabIndex = 106;
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
            this.reflectionLabel1.Location = new System.Drawing.Point(111, 32);
            this.reflectionLabel1.Name = "reflectionLabel1";
            this.reflectionLabel1.Size = new System.Drawing.Size(450, 70);
            this.reflectionLabel1.TabIndex = 107;
            this.reflectionLabel1.Text = "<b><font size=\"+12\"><font color=\"#0000\">Data Penilai</font></font></b>";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(395, 397);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 111;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(278, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.TabIndex = 110;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmPejabatPenilai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 456);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.reflectionLabel1);
            this.Controls.Add(this.reflectionImage2);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPejabatPenilai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pejabat Penilai - SIMKAP 1.0.0";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmPejabatPenilai_MouseMove);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPejabatPenilai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPejabatPenilai;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx2;
        private DevComponents.DotNetBar.Controls.ReflectionImage reflectionImage2;
        private DevComponents.DotNetBar.Controls.ReflectionLabel reflectionLabel1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnDelete;

        #region Variabel

        private IntPejabatPenilai ipp;
        private EntPejabatPenilai epp;
        private FrmMenu frmMenu;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private string receiveNama;
        private string receiveIp;
        private string id;
        private string log;
        private string message;
        private bool condition;

        #endregion
    }
}