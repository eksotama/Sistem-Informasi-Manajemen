using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
using SimkapSmartClient.simkap.smart.client.setting.app;

namespace SimkapSmartClient.simkap.smart.client.view.view.lckh.kelola
{
    partial class FrmCreateCapaianKinerjaHarian
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle57 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle58 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle59 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle60 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle61 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle62 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle63 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle71 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle72 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle73 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle74 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle75 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle76 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle77 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle78 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle79 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle80 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle81 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle82 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle83 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle84 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle85 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle86 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle87 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle88 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateCapaianKinerjaHarian));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnSync = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabControlPanel18 = new DevComponents.DotNetBar.TabControlPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtIdJenisKegiatan = new System.Windows.Forms.TextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cmbWorkSheet = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.cmbJenisKegiatan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnViewWorkSheet = new DevComponents.DotNetBar.ButtonX();
            this.tbSelectWorkSheet = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel17 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel15 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetOthers = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanLainnya = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx15 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbOthers = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel22 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel18 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx18 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbSuratKeluar = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel19 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel16 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetHaji = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanHaji = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx16 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbHaji = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel16 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel14 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetCerai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanCerai = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx14 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbCerai = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel15 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel12 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetTalak = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanTalak = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx12 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbTalak = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel14 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel13 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetMasukIslam = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanMasukIslam = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx13 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbMasukIslam = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel13 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel11 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetDuplikat = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanDuplikat = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx11 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbDuplikat = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel12 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel10 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetRekomendasi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanRekomendasi = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx10 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbRekomendasi = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel11 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel9 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetKeuangan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanKeuangan = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx9 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbKeuangan = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel10 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel8 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetWakaf = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanWakaf = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx8 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbWakaf = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelData = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetNikah = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanNikah = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx2 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbNikah = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel20 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel17 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvWorksheetModelNA = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbKegiatanModelNA = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.richTextBoxEx17 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tbModelNA = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncModelNA = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvSyncPernikahan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel21 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvSyncSuratKeluar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.taaa = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel8 = new DevComponents.DotNetBar.TabControlPanel();
            this.dgvSyncHaji = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.tabItem8 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel6 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel5 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncMasukIslam = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx5 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tabItem6 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel5 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncDuplikat = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx4 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tabItem5 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncRekomendasi = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx3 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tabItem4 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncWakaf = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx1 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tabItem3 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel7 = new DevComponents.DotNetBar.TabControlPanel();
            this.groupPanel6 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvSyncCerai = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvSyncTalak = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.richTextBoxEx6 = new DevComponents.DotNetBar.Controls.RichTextBoxEx();
            this.tabItem7 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tbAktaNikah = new DevComponents.DotNetBar.TabItem(this.components);
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel18.SuspendLayout();
            this.panel11.SuspendLayout();
            this.tabControlPanel17.SuspendLayout();
            this.groupPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetOthers)).BeginInit();
            this.tabControlPanel22.SuspendLayout();
            this.groupPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetSuratKeluar)).BeginInit();
            this.tabControlPanel19.SuspendLayout();
            this.groupPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetHaji)).BeginInit();
            this.tabControlPanel16.SuspendLayout();
            this.groupPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetCerai)).BeginInit();
            this.tabControlPanel15.SuspendLayout();
            this.groupPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetTalak)).BeginInit();
            this.tabControlPanel14.SuspendLayout();
            this.groupPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetMasukIslam)).BeginInit();
            this.tabControlPanel13.SuspendLayout();
            this.groupPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetDuplikat)).BeginInit();
            this.tabControlPanel12.SuspendLayout();
            this.groupPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetRekomendasi)).BeginInit();
            this.tabControlPanel11.SuspendLayout();
            this.groupPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetKeuangan)).BeginInit();
            this.tabControlPanel10.SuspendLayout();
            this.groupPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetWakaf)).BeginInit();
            this.tabControlPanel1.SuspendLayout();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetNikah)).BeginInit();
            this.tabControlPanel20.SuspendLayout();
            this.groupPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetModelNA)).BeginInit();
            this.tabControlPanel2.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncModelNA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncPernikahan)).BeginInit();
            this.tabControlPanel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncSuratKeluar)).BeginInit();
            this.tabControlPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncHaji)).BeginInit();
            this.tabControlPanel6.SuspendLayout();
            this.groupPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncMasukIslam)).BeginInit();
            this.tabControlPanel5.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncDuplikat)).BeginInit();
            this.tabControlPanel4.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncRekomendasi)).BeginInit();
            this.tabControlPanel3.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncWakaf)).BeginInit();
            this.tabControlPanel7.SuspendLayout();
            this.groupPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncCerai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncTalak)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSync);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 442);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1171, 82);
            this.panel1.TabIndex = 77;
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnDelete.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(818, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnDelete.Size = new System.Drawing.Size(96, 37);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.Symbol = "";
            this.btnDelete.TabIndex = 109;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSync
            // 
            this.btnSync.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSync.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSync.Location = new System.Drawing.Point(24, 29);
            this.btnSync.Name = "btnSync";
            this.btnSync.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSync.Size = new System.Drawing.Size(151, 37);
            this.btnSync.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSync.Symbol = "";
            this.btnSync.TabIndex = 80;
            this.btnSync.Text = "Sinknronkan Data";
            this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(1050, 29);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnCancel.Size = new System.Drawing.Size(96, 37);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.Symbol = "";
            this.btnCancel.TabIndex = 78;
            this.btnCancel.Text = "Batal";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(935, 29);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.Symbol = "";
            this.btnSave.TabIndex = 75;
            this.btnSave.Text = "Simpan";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.BackColor = System.Drawing.Color.White;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.ColorScheme.TabBackground = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabBackground2 = System.Drawing.Color.White;
            this.tabControl1.ColorScheme.TabItemBackground2 = System.Drawing.Color.RoyalBlue;
            this.tabControl1.ColorScheme.TabItemBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 1F)});
            this.tabControl1.ColorScheme.TabItemBorder = System.Drawing.Color.Black;
            this.tabControl1.ColorScheme.TabItemBorderDark = System.Drawing.Color.RoyalBlue;
            this.tabControl1.ColorScheme.TabItemHotBackground2 = System.Drawing.SystemColors.Menu;
            this.tabControl1.ColorScheme.TabItemHotBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 1F)});
            this.tabControl1.ColorScheme.TabItemHotBorder = System.Drawing.Color.RoyalBlue;
            this.tabControl1.ColorScheme.TabItemHotBorderDark = System.Drawing.Color.RoyalBlue;
            this.tabControl1.ColorScheme.TabItemHotBorderLight = System.Drawing.Color.RoyalBlue;
            this.tabControl1.ColorScheme.TabItemHotText = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabControl1.ColorScheme.TabItemSelectedBackgroundColorBlend.AddRange(new DevComponents.DotNetBar.BackgroundColorBlend[] {
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 0.45F),
            new DevComponents.DotNetBar.BackgroundColorBlend(System.Drawing.Color.Empty, 1F)});
            this.tabControl1.ColorScheme.TabItemSelectedText = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabControl1.Controls.Add(this.tabControlPanel20);
            this.tabControl1.Controls.Add(this.tabControlPanel18);
            this.tabControl1.Controls.Add(this.tabControlPanel17);
            this.tabControl1.Controls.Add(this.tabControlPanel22);
            this.tabControl1.Controls.Add(this.tabControlPanel19);
            this.tabControl1.Controls.Add(this.tabControlPanel16);
            this.tabControl1.Controls.Add(this.tabControlPanel15);
            this.tabControl1.Controls.Add(this.tabControlPanel14);
            this.tabControl1.Controls.Add(this.tabControlPanel13);
            this.tabControl1.Controls.Add(this.tabControlPanel12);
            this.tabControl1.Controls.Add(this.tabControlPanel11);
            this.tabControl1.Controls.Add(this.tabControlPanel10);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel21);
            this.tabControl1.Controls.Add(this.tabControlPanel8);
            this.tabControl1.Controls.Add(this.tabControlPanel6);
            this.tabControl1.Controls.Add(this.tabControlPanel5);
            this.tabControl1.Controls.Add(this.tabControlPanel4);
            this.tabControl1.Controls.Add(this.tabControlPanel3);
            this.tabControl1.Controls.Add(this.tabControlPanel7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ForeColor = System.Drawing.Color.Black;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(1171, 442);
            this.tabControl1.Style = DevComponents.DotNetBar.eTabStripStyle.Metro;
            this.tabControl1.TabIndex = 78;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tbSelectWorkSheet);
            this.tabControl1.Tabs.Add(this.tbModelNA);
            this.tabControl1.Tabs.Add(this.tbNikah);
            this.tabControl1.Tabs.Add(this.tbWakaf);
            this.tabControl1.Tabs.Add(this.tbKeuangan);
            this.tabControl1.Tabs.Add(this.tbRekomendasi);
            this.tabControl1.Tabs.Add(this.tbDuplikat);
            this.tabControl1.Tabs.Add(this.tbMasukIslam);
            this.tabControl1.Tabs.Add(this.tbTalak);
            this.tabControl1.Tabs.Add(this.tbCerai);
            this.tabControl1.Tabs.Add(this.tbHaji);
            this.tabControl1.Tabs.Add(this.tbSuratKeluar);
            this.tabControl1.Tabs.Add(this.tbOthers);
            this.tabControl1.Tabs.Add(this.tabItem7);
            this.tabControl1.Tabs.Add(this.tabItem3);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Tabs.Add(this.tabItem4);
            this.tabControl1.Tabs.Add(this.tabItem5);
            this.tabControl1.Tabs.Add(this.tabItem6);
            this.tabControl1.Tabs.Add(this.tabItem8);
            this.tabControl1.Tabs.Add(this.taaa);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabControlPanel18
            // 
            this.tabControlPanel18.Controls.Add(this.panel11);
            this.tabControlPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel18.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel18.Name = "tabControlPanel18";
            this.tabControlPanel18.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel18.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel18.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.tabControlPanel18.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.tabControlPanel18.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel18.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel18.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel18.Style.GradientAngle = -90;
            this.tabControlPanel18.TabIndex = 18;
            this.tabControlPanel18.TabItem = this.tbSelectWorkSheet;
            this.tabControlPanel18.Visible = false;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Controls.Add(this.dtDate);
            this.panel11.Controls.Add(this.txtIdJenisKegiatan);
            this.panel11.Controls.Add(this.labelX2);
            this.panel11.Controls.Add(this.cmbWorkSheet);
            this.panel11.Controls.Add(this.labelX1);
            this.panel11.Controls.Add(this.btnClose);
            this.panel11.Controls.Add(this.cmbJenisKegiatan);
            this.panel11.Controls.Add(this.btnViewWorkSheet);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(1, 1);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1169, 411);
            this.panel11.TabIndex = 85;
            this.panel11.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel11_MouseMove);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(662, 50);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(200, 25);
            this.dtDate.TabIndex = 90;
            this.dtDate.Visible = false;
            // 
            // txtIdJenisKegiatan
            // 
            this.txtIdJenisKegiatan.Location = new System.Drawing.Point(285, 44);
            this.txtIdJenisKegiatan.Name = "txtIdJenisKegiatan";
            this.txtIdJenisKegiatan.Size = new System.Drawing.Size(95, 25);
            this.txtIdJenisKegiatan.TabIndex = 89;
            this.txtIdJenisKegiatan.Visible = false;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(354, 137);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(107, 23);
            this.labelX2.TabIndex = 88;
            this.labelX2.Text = "Lembar Kerja";
            // 
            // cmbWorkSheet
            // 
            this.cmbWorkSheet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbWorkSheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbWorkSheet.DisplayMember = "Text";
            this.cmbWorkSheet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWorkSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkSheet.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbWorkSheet.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbWorkSheet.FocusHighlightEnabled = true;
            this.cmbWorkSheet.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWorkSheet.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbWorkSheet, true);
            this.cmbWorkSheet.ItemHeight = 21;
            this.cmbWorkSheet.Location = new System.Drawing.Point(519, 136);
            this.cmbWorkSheet.Name = "cmbWorkSheet";
            this.cmbWorkSheet.Size = new System.Drawing.Size(301, 27);
            this.cmbWorkSheet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbWorkSheet.TabIndex = 87;
            this.cmbWorkSheet.WatermarkText = "-- pilih lembar kerja --";
            this.cmbWorkSheet.SelectedValueChanged += new System.EventHandler(this.cmbWorkSheet_SelectedValueChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(354, 176);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 23);
            this.labelX1.TabIndex = 86;
            this.labelX1.Text = "Jenis Kegiatan";
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(724, 231);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(96, 37);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.Symbol = "";
            this.btnClose.TabIndex = 85;
            this.btnClose.Text = "Keluar";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbJenisKegiatan
            // 
            this.cmbJenisKegiatan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbJenisKegiatan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbJenisKegiatan.DisplayMember = "Text";
            this.cmbJenisKegiatan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenisKegiatan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisKegiatan.Enabled = false;
            this.cmbJenisKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbJenisKegiatan.FocusHighlightColor = System.Drawing.SystemColors.Menu;
            this.cmbJenisKegiatan.FocusHighlightEnabled = true;
            this.cmbJenisKegiatan.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJenisKegiatan.FormattingEnabled = true;
            this.highlighter1.SetHighlightOnFocus(this.cmbJenisKegiatan, true);
            this.cmbJenisKegiatan.ItemHeight = 21;
            this.cmbJenisKegiatan.Location = new System.Drawing.Point(519, 175);
            this.cmbJenisKegiatan.Name = "cmbJenisKegiatan";
            this.cmbJenisKegiatan.Size = new System.Drawing.Size(301, 27);
            this.cmbJenisKegiatan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbJenisKegiatan.TabIndex = 83;
            this.cmbJenisKegiatan.WatermarkText = "-- pilih jenis kegiatan --";
            this.cmbJenisKegiatan.SelectedValueChanged += new System.EventHandler(this.cmbJenisKegiatan_SelectedValueChanged);
            this.cmbJenisKegiatan.Click += new System.EventHandler(this.cmbJenisKegiatan_Click);
            // 
            // btnViewWorkSheet
            // 
            this.btnViewWorkSheet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnViewWorkSheet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnViewWorkSheet.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewWorkSheet.Location = new System.Drawing.Point(526, 231);
            this.btnViewWorkSheet.Name = "btnViewWorkSheet";
            this.btnViewWorkSheet.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnViewWorkSheet.Size = new System.Drawing.Size(178, 37);
            this.btnViewWorkSheet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnViewWorkSheet.Symbol = "";
            this.btnViewWorkSheet.TabIndex = 82;
            this.btnViewWorkSheet.Text = "Tampilkan Lembar Kerja";
            this.btnViewWorkSheet.Click += new System.EventHandler(this.btnViewWorkSheet_Click);
            // 
            // tbSelectWorkSheet
            // 
            this.tbSelectWorkSheet.AttachedControl = this.tabControlPanel18;
            this.tbSelectWorkSheet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(240)))), ((int)(((byte)(226)))));
            this.tbSelectWorkSheet.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(201)))), ((int)(((byte)(151)))));
            this.tbSelectWorkSheet.Name = "tbSelectWorkSheet";
            this.tbSelectWorkSheet.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Green;
            this.tbSelectWorkSheet.Text = "Pilih Lembar Kerja";
            this.tbSelectWorkSheet.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel17
            // 
            this.tabControlPanel17.Controls.Add(this.groupPanel15);
            this.tabControlPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel17.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel17.Name = "tabControlPanel17";
            this.tabControlPanel17.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel17.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel17.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel17.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel17.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel17.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel17.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel17.Style.GradientAngle = -90;
            this.tabControlPanel17.TabIndex = 17;
            this.tabControlPanel17.TabItem = this.tbOthers;
            // 
            // groupPanel15
            // 
            this.groupPanel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel15.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel15.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel15.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel15.Controls.Add(this.dgvWorksheetOthers);
            this.groupPanel15.Controls.Add(this.richTextBoxEx15);
            this.groupPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel15.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel15.Location = new System.Drawing.Point(1, 1);
            this.groupPanel15.Name = "groupPanel15";
            this.groupPanel15.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel15.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel15.Style.BackColorGradientAngle = 90;
            this.groupPanel15.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel15.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel15.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel15.Style.BorderBottomWidth = 1;
            this.groupPanel15.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel15.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel15.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel15.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel15.Style.BorderLeftWidth = 1;
            this.groupPanel15.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel15.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel15.Style.BorderRightWidth = 1;
            this.groupPanel15.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel15.Style.BorderTopWidth = 1;
            this.groupPanel15.Style.CornerDiameter = 4;
            this.groupPanel15.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel15.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel15.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel15.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel15.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel15.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel15.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel15.TabIndex = 82;
            // 
            // dgvWorksheetOthers
            // 
            this.dgvWorksheetOthers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetOthers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetOthers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetOthers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorksheetOthers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetOthers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanLainnya});
            this.dgvWorksheetOthers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetOthers.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvWorksheetOthers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetOthers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetOthers.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetOthers.Name = "dgvWorksheetOthers";
            this.dgvWorksheetOthers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetOthers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetOthers.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetOthers.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvWorksheetOthers.SelectAllSignVisible = false;
            this.dgvWorksheetOthers.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetOthers.TabIndex = 1;
            this.dgvWorksheetOthers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetOthers_CellClick);
            this.dgvWorksheetOthers.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetOthers_DataError);
            this.dgvWorksheetOthers.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetOthers_MouseMove);
            // 
            // cmbKegiatanLainnya
            // 
            this.cmbKegiatanLainnya.DisplayMember = "Text";
            this.cmbKegiatanLainnya.DropDownHeight = 106;
            this.cmbKegiatanLainnya.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanLainnya.DropDownWidth = 121;
            this.cmbKegiatanLainnya.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanLainnya.HeaderText = "Kegiatan";
            this.cmbKegiatanLainnya.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanLainnya.IntegralHeight = false;
            this.cmbKegiatanLainnya.ItemHeight = 15;
            this.cmbKegiatanLainnya.Name = "cmbKegiatanLainnya";
            this.cmbKegiatanLainnya.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx15
            // 
            this.richTextBoxEx15.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx15.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx15.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx15.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx15.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx15.Name = "richTextBoxEx15";
            this.richTextBoxEx15.ReadOnly = true;
            this.richTextBoxEx15.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx15.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx15.TabIndex = 0;
            // 
            // tbOthers
            // 
            this.tbOthers.AttachedControl = this.tabControlPanel17;
            this.tbOthers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbOthers.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbOthers.Name = "tbOthers";
            this.tbOthers.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbOthers.Text = "Lainnya";
            this.tbOthers.TextColor = System.Drawing.Color.Black;
            this.tbOthers.Visible = false;
            // 
            // tabControlPanel22
            // 
            this.tabControlPanel22.Controls.Add(this.groupPanel18);
            this.tabControlPanel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel22.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel22.Name = "tabControlPanel22";
            this.tabControlPanel22.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel22.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel22.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel22.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel22.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel22.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel22.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel22.Style.GradientAngle = -90;
            this.tabControlPanel22.TabIndex = 22;
            this.tabControlPanel22.TabItem = this.tbSuratKeluar;
            // 
            // groupPanel18
            // 
            this.groupPanel18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel18.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel18.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel18.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel18.Controls.Add(this.dgvWorksheetSuratKeluar);
            this.groupPanel18.Controls.Add(this.richTextBoxEx18);
            this.groupPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel18.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel18.Location = new System.Drawing.Point(1, 1);
            this.groupPanel18.Name = "groupPanel18";
            this.groupPanel18.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel18.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel18.Style.BackColorGradientAngle = 90;
            this.groupPanel18.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel18.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel18.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel18.Style.BorderBottomWidth = 1;
            this.groupPanel18.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel18.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel18.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel18.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel18.Style.BorderLeftWidth = 1;
            this.groupPanel18.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel18.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel18.Style.BorderRightWidth = 1;
            this.groupPanel18.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel18.Style.BorderTopWidth = 1;
            this.groupPanel18.Style.CornerDiameter = 4;
            this.groupPanel18.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel18.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel18.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel18.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel18.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel18.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel18.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel18.TabIndex = 40;
            // 
            // dgvWorksheetSuratKeluar
            // 
            this.dgvWorksheetSuratKeluar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetSuratKeluar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetSuratKeluar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetSuratKeluar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWorksheetSuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetSuratKeluar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanSuratKeluar});
            this.dgvWorksheetSuratKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetSuratKeluar.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvWorksheetSuratKeluar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetSuratKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetSuratKeluar.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetSuratKeluar.Name = "dgvWorksheetSuratKeluar";
            this.dgvWorksheetSuratKeluar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetSuratKeluar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetSuratKeluar.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetSuratKeluar.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvWorksheetSuratKeluar.SelectAllSignVisible = false;
            this.dgvWorksheetSuratKeluar.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetSuratKeluar.TabIndex = 1;
            this.dgvWorksheetSuratKeluar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetSuratKeluar_CellClick);
            this.dgvWorksheetSuratKeluar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetSuratKeluar_CellEndEdit);
            this.dgvWorksheetSuratKeluar.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetSuratKeluar_DataError);
            this.dgvWorksheetSuratKeluar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetSuratKeluar_MouseMove);
            // 
            // cmbKegiatanSuratKeluar
            // 
            this.cmbKegiatanSuratKeluar.DisplayMember = "Text";
            this.cmbKegiatanSuratKeluar.DropDownHeight = 106;
            this.cmbKegiatanSuratKeluar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanSuratKeluar.DropDownWidth = 121;
            this.cmbKegiatanSuratKeluar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanSuratKeluar.HeaderText = "Kegiatan";
            this.cmbKegiatanSuratKeluar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanSuratKeluar.IntegralHeight = false;
            this.cmbKegiatanSuratKeluar.ItemHeight = 15;
            this.cmbKegiatanSuratKeluar.Name = "cmbKegiatanSuratKeluar";
            this.cmbKegiatanSuratKeluar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx18
            // 
            this.richTextBoxEx18.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx18.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx18.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx18.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx18.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx18.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx18.Name = "richTextBoxEx18";
            this.richTextBoxEx18.ReadOnly = true;
            this.richTextBoxEx18.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx18.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx18.TabIndex = 0;
            // 
            // tbSuratKeluar
            // 
            this.tbSuratKeluar.AttachedControl = this.tabControlPanel22;
            this.tbSuratKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbSuratKeluar.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbSuratKeluar.Name = "tbSuratKeluar";
            this.tbSuratKeluar.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbSuratKeluar.Text = "Surat Keluar";
            this.tbSuratKeluar.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel19
            // 
            this.tabControlPanel19.Controls.Add(this.groupPanel16);
            this.tabControlPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel19.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel19.Name = "tabControlPanel19";
            this.tabControlPanel19.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel19.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel19.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel19.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel19.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel19.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel19.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel19.Style.GradientAngle = -90;
            this.tabControlPanel19.TabIndex = 19;
            this.tabControlPanel19.TabItem = this.tbHaji;
            // 
            // groupPanel16
            // 
            this.groupPanel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel16.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel16.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel16.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel16.Controls.Add(this.dgvWorksheetHaji);
            this.groupPanel16.Controls.Add(this.richTextBoxEx16);
            this.groupPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel16.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel16.Location = new System.Drawing.Point(1, 1);
            this.groupPanel16.Name = "groupPanel16";
            this.groupPanel16.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel16.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel16.Style.BackColorGradientAngle = 90;
            this.groupPanel16.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel16.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel16.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel16.Style.BorderBottomWidth = 1;
            this.groupPanel16.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel16.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel16.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel16.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel16.Style.BorderLeftWidth = 1;
            this.groupPanel16.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel16.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel16.Style.BorderRightWidth = 1;
            this.groupPanel16.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel16.Style.BorderTopWidth = 1;
            this.groupPanel16.Style.CornerDiameter = 4;
            this.groupPanel16.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel16.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel16.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel16.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel16.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel16.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel16.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel16.TabIndex = 40;
            // 
            // dgvWorksheetHaji
            // 
            this.dgvWorksheetHaji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetHaji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetHaji.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetHaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvWorksheetHaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetHaji.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanHaji});
            this.dgvWorksheetHaji.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetHaji.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvWorksheetHaji.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetHaji.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetHaji.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetHaji.Name = "dgvWorksheetHaji";
            this.dgvWorksheetHaji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetHaji.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetHaji.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetHaji.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvWorksheetHaji.SelectAllSignVisible = false;
            this.dgvWorksheetHaji.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetHaji.TabIndex = 1;
            this.dgvWorksheetHaji.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetHaji_CellClick);
            this.dgvWorksheetHaji.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetHaji_CellEndEdit);
            this.dgvWorksheetHaji.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetHaji_DataError);
            this.dgvWorksheetHaji.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetHaji_MouseMove);
            // 
            // cmbKegiatanHaji
            // 
            this.cmbKegiatanHaji.DisplayMember = "Text";
            this.cmbKegiatanHaji.DropDownHeight = 106;
            this.cmbKegiatanHaji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanHaji.DropDownWidth = 121;
            this.cmbKegiatanHaji.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanHaji.HeaderText = "Kegiatan";
            this.cmbKegiatanHaji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanHaji.IntegralHeight = false;
            this.cmbKegiatanHaji.ItemHeight = 15;
            this.cmbKegiatanHaji.Name = "cmbKegiatanHaji";
            this.cmbKegiatanHaji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx16
            // 
            this.richTextBoxEx16.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx16.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx16.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx16.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx16.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx16.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx16.Name = "richTextBoxEx16";
            this.richTextBoxEx16.ReadOnly = true;
            this.richTextBoxEx16.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx16.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx16.TabIndex = 0;
            // 
            // tbHaji
            // 
            this.tbHaji.AttachedControl = this.tabControlPanel19;
            this.tbHaji.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbHaji.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbHaji.Name = "tbHaji";
            this.tbHaji.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbHaji.Text = "Haji";
            this.tbHaji.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel16
            // 
            this.tabControlPanel16.Controls.Add(this.groupPanel14);
            this.tabControlPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel16.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel16.Name = "tabControlPanel16";
            this.tabControlPanel16.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel16.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel16.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel16.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel16.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel16.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel16.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel16.Style.GradientAngle = -90;
            this.tabControlPanel16.TabIndex = 16;
            this.tabControlPanel16.TabItem = this.tbCerai;
            // 
            // groupPanel14
            // 
            this.groupPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel14.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel14.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel14.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel14.Controls.Add(this.dgvWorksheetCerai);
            this.groupPanel14.Controls.Add(this.richTextBoxEx14);
            this.groupPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel14.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel14.Location = new System.Drawing.Point(1, 1);
            this.groupPanel14.Name = "groupPanel14";
            this.groupPanel14.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel14.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel14.Style.BackColorGradientAngle = 90;
            this.groupPanel14.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel14.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel14.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel14.Style.BorderBottomWidth = 1;
            this.groupPanel14.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel14.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel14.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel14.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel14.Style.BorderLeftWidth = 1;
            this.groupPanel14.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel14.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel14.Style.BorderRightWidth = 1;
            this.groupPanel14.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel14.Style.BorderTopWidth = 1;
            this.groupPanel14.Style.CornerDiameter = 4;
            this.groupPanel14.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel14.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel14.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel14.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel14.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel14.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel14.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel14.TabIndex = 82;
            // 
            // dgvWorksheetCerai
            // 
            this.dgvWorksheetCerai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetCerai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetCerai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetCerai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvWorksheetCerai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetCerai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanCerai});
            this.dgvWorksheetCerai.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetCerai.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvWorksheetCerai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetCerai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetCerai.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetCerai.Name = "dgvWorksheetCerai";
            this.dgvWorksheetCerai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetCerai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetCerai.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetCerai.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvWorksheetCerai.SelectAllSignVisible = false;
            this.dgvWorksheetCerai.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetCerai.TabIndex = 1;
            this.dgvWorksheetCerai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetCerai_CellClick);
            this.dgvWorksheetCerai.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetCerai_CellEndEdit);
            this.dgvWorksheetCerai.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetCerai_DataError);
            this.dgvWorksheetCerai.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetCerai_MouseMove);
            // 
            // cmbKegiatanCerai
            // 
            this.cmbKegiatanCerai.DisplayMember = "Text";
            this.cmbKegiatanCerai.DropDownHeight = 106;
            this.cmbKegiatanCerai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanCerai.DropDownWidth = 121;
            this.cmbKegiatanCerai.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanCerai.HeaderText = "Kegiatan";
            this.cmbKegiatanCerai.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanCerai.IntegralHeight = false;
            this.cmbKegiatanCerai.ItemHeight = 15;
            this.cmbKegiatanCerai.Name = "cmbKegiatanCerai";
            this.cmbKegiatanCerai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx14
            // 
            this.richTextBoxEx14.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx14.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx14.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx14.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx14.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx14.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx14.Name = "richTextBoxEx14";
            this.richTextBoxEx14.ReadOnly = true;
            this.richTextBoxEx14.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx14.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx14.TabIndex = 0;
            // 
            // tbCerai
            // 
            this.tbCerai.AttachedControl = this.tabControlPanel16;
            this.tbCerai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbCerai.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbCerai.Name = "tbCerai";
            this.tbCerai.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbCerai.Text = "Cerai";
            this.tbCerai.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel15
            // 
            this.tabControlPanel15.Controls.Add(this.groupPanel12);
            this.tabControlPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel15.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel15.Name = "tabControlPanel15";
            this.tabControlPanel15.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel15.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel15.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel15.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel15.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel15.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel15.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel15.Style.GradientAngle = -90;
            this.tabControlPanel15.TabIndex = 15;
            this.tabControlPanel15.TabItem = this.tbTalak;
            // 
            // groupPanel12
            // 
            this.groupPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel12.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel12.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel12.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel12.Controls.Add(this.dgvWorksheetTalak);
            this.groupPanel12.Controls.Add(this.richTextBoxEx12);
            this.groupPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel12.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel12.Location = new System.Drawing.Point(1, 1);
            this.groupPanel12.Name = "groupPanel12";
            this.groupPanel12.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel12.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel12.Style.BackColorGradientAngle = 90;
            this.groupPanel12.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel12.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel12.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel12.Style.BorderBottomWidth = 1;
            this.groupPanel12.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel12.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel12.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel12.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel12.Style.BorderLeftWidth = 1;
            this.groupPanel12.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel12.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel12.Style.BorderRightWidth = 1;
            this.groupPanel12.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel12.Style.BorderTopWidth = 1;
            this.groupPanel12.Style.CornerDiameter = 4;
            this.groupPanel12.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel12.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel12.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel12.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel12.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel12.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel12.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel12.TabIndex = 82;
            // 
            // dgvWorksheetTalak
            // 
            this.dgvWorksheetTalak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetTalak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetTalak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetTalak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvWorksheetTalak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetTalak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanTalak});
            this.dgvWorksheetTalak.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetTalak.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgvWorksheetTalak.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetTalak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetTalak.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetTalak.Name = "dgvWorksheetTalak";
            this.dgvWorksheetTalak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetTalak.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetTalak.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetTalak.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvWorksheetTalak.SelectAllSignVisible = false;
            this.dgvWorksheetTalak.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetTalak.TabIndex = 1;
            this.dgvWorksheetTalak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetTalak_CellClick);
            this.dgvWorksheetTalak.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetTalak_CellEndEdit);
            this.dgvWorksheetTalak.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetTalak_DataError);
            this.dgvWorksheetTalak.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetTalak_MouseMove);
            // 
            // cmbKegiatanTalak
            // 
            this.cmbKegiatanTalak.DisplayMember = "Text";
            this.cmbKegiatanTalak.DropDownHeight = 106;
            this.cmbKegiatanTalak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanTalak.DropDownWidth = 121;
            this.cmbKegiatanTalak.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanTalak.HeaderText = "Kegiatan";
            this.cmbKegiatanTalak.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanTalak.IntegralHeight = false;
            this.cmbKegiatanTalak.ItemHeight = 15;
            this.cmbKegiatanTalak.Name = "cmbKegiatanTalak";
            this.cmbKegiatanTalak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx12
            // 
            this.richTextBoxEx12.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx12.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx12.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx12.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx12.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx12.Name = "richTextBoxEx12";
            this.richTextBoxEx12.ReadOnly = true;
            this.richTextBoxEx12.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx12.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx12.TabIndex = 0;
            // 
            // tbTalak
            // 
            this.tbTalak.AttachedControl = this.tabControlPanel15;
            this.tbTalak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbTalak.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbTalak.Name = "tbTalak";
            this.tbTalak.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbTalak.Text = "Talak";
            this.tbTalak.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel14
            // 
            this.tabControlPanel14.Controls.Add(this.groupPanel13);
            this.tabControlPanel14.Controls.Add(this.panel8);
            this.tabControlPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel14.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel14.Name = "tabControlPanel14";
            this.tabControlPanel14.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel14.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel14.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel14.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel14.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel14.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel14.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel14.Style.GradientAngle = -90;
            this.tabControlPanel14.TabIndex = 14;
            this.tabControlPanel14.TabItem = this.tbMasukIslam;
            // 
            // groupPanel13
            // 
            this.groupPanel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel13.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel13.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel13.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel13.Controls.Add(this.dgvWorksheetMasukIslam);
            this.groupPanel13.Controls.Add(this.richTextBoxEx13);
            this.groupPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel13.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel13.Location = new System.Drawing.Point(1, 1);
            this.groupPanel13.Name = "groupPanel13";
            this.groupPanel13.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel13.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel13.Style.BackColorGradientAngle = 90;
            this.groupPanel13.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel13.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel13.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel13.Style.BorderBottomWidth = 1;
            this.groupPanel13.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel13.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel13.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel13.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel13.Style.BorderLeftWidth = 1;
            this.groupPanel13.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel13.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel13.Style.BorderRightWidth = 1;
            this.groupPanel13.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel13.Style.BorderTopWidth = 1;
            this.groupPanel13.Style.CornerDiameter = 4;
            this.groupPanel13.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel13.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel13.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel13.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel13.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel13.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel13.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel13.TabIndex = 82;
            // 
            // dgvWorksheetMasukIslam
            // 
            this.dgvWorksheetMasukIslam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetMasukIslam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetMasukIslam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetMasukIslam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvWorksheetMasukIslam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetMasukIslam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanMasukIslam});
            this.dgvWorksheetMasukIslam.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetMasukIslam.DefaultCellStyle = dataGridViewCellStyle26;
            this.dgvWorksheetMasukIslam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetMasukIslam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetMasukIslam.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetMasukIslam.Name = "dgvWorksheetMasukIslam";
            this.dgvWorksheetMasukIslam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetMasukIslam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetMasukIslam.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetMasukIslam.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dgvWorksheetMasukIslam.SelectAllSignVisible = false;
            this.dgvWorksheetMasukIslam.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetMasukIslam.TabIndex = 1;
            this.dgvWorksheetMasukIslam.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetMasukIslam_CellClick);
            this.dgvWorksheetMasukIslam.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetMasukIslam_CellEndEdit);
            this.dgvWorksheetMasukIslam.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetMasukIslam_DataError);
            this.dgvWorksheetMasukIslam.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetMasukIslam_MouseMove);
            // 
            // cmbKegiatanMasukIslam
            // 
            this.cmbKegiatanMasukIslam.DisplayMember = "Text";
            this.cmbKegiatanMasukIslam.DropDownHeight = 106;
            this.cmbKegiatanMasukIslam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanMasukIslam.DropDownWidth = 121;
            this.cmbKegiatanMasukIslam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanMasukIslam.HeaderText = "Kegiatan";
            this.cmbKegiatanMasukIslam.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanMasukIslam.IntegralHeight = false;
            this.cmbKegiatanMasukIslam.ItemHeight = 15;
            this.cmbKegiatanMasukIslam.Name = "cmbKegiatanMasukIslam";
            this.cmbKegiatanMasukIslam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx13
            // 
            this.richTextBoxEx13.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx13.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx13.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx13.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx13.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx13.Name = "richTextBoxEx13";
            this.richTextBoxEx13.ReadOnly = true;
            this.richTextBoxEx13.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx13.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx13.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(1, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1169, 411);
            this.panel8.TabIndex = 81;
            // 
            // tbMasukIslam
            // 
            this.tbMasukIslam.AttachedControl = this.tabControlPanel14;
            this.tbMasukIslam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbMasukIslam.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbMasukIslam.Name = "tbMasukIslam";
            this.tbMasukIslam.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbMasukIslam.Text = "Masuk Islam";
            this.tbMasukIslam.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel13
            // 
            this.tabControlPanel13.Controls.Add(this.groupPanel11);
            this.tabControlPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel13.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel13.Name = "tabControlPanel13";
            this.tabControlPanel13.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel13.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel13.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel13.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel13.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel13.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel13.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel13.Style.GradientAngle = -90;
            this.tabControlPanel13.TabIndex = 13;
            this.tabControlPanel13.TabItem = this.tbDuplikat;
            // 
            // groupPanel11
            // 
            this.groupPanel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel11.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel11.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel11.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel11.Controls.Add(this.dgvWorksheetDuplikat);
            this.groupPanel11.Controls.Add(this.richTextBoxEx11);
            this.groupPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel11.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel11.Location = new System.Drawing.Point(1, 1);
            this.groupPanel11.Name = "groupPanel11";
            this.groupPanel11.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel11.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel11.Style.BackColorGradientAngle = 90;
            this.groupPanel11.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel11.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel11.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel11.Style.BorderBottomWidth = 1;
            this.groupPanel11.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel11.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel11.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel11.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel11.Style.BorderLeftWidth = 1;
            this.groupPanel11.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel11.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel11.Style.BorderRightWidth = 1;
            this.groupPanel11.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel11.Style.BorderTopWidth = 1;
            this.groupPanel11.Style.CornerDiameter = 4;
            this.groupPanel11.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel11.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel11.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel11.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel11.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel11.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel11.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel11.TabIndex = 82;
            // 
            // dgvWorksheetDuplikat
            // 
            this.dgvWorksheetDuplikat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetDuplikat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetDuplikat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetDuplikat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dgvWorksheetDuplikat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetDuplikat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanDuplikat});
            this.dgvWorksheetDuplikat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetDuplikat.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgvWorksheetDuplikat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetDuplikat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetDuplikat.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetDuplikat.Name = "dgvWorksheetDuplikat";
            this.dgvWorksheetDuplikat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetDuplikat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetDuplikat.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetDuplikat.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dgvWorksheetDuplikat.SelectAllSignVisible = false;
            this.dgvWorksheetDuplikat.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetDuplikat.TabIndex = 1;
            this.dgvWorksheetDuplikat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetDuplikat_CellClick);
            this.dgvWorksheetDuplikat.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetDuplikat_CellEndEdit);
            this.dgvWorksheetDuplikat.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetDuplikat_DataError);
            this.dgvWorksheetDuplikat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetDuplikat_MouseMove);
            // 
            // cmbKegiatanDuplikat
            // 
            this.cmbKegiatanDuplikat.DisplayMember = "Text";
            this.cmbKegiatanDuplikat.DropDownHeight = 106;
            this.cmbKegiatanDuplikat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanDuplikat.DropDownWidth = 121;
            this.cmbKegiatanDuplikat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanDuplikat.HeaderText = "Kegiatan";
            this.cmbKegiatanDuplikat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanDuplikat.IntegralHeight = false;
            this.cmbKegiatanDuplikat.ItemHeight = 15;
            this.cmbKegiatanDuplikat.Name = "cmbKegiatanDuplikat";
            this.cmbKegiatanDuplikat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx11
            // 
            this.richTextBoxEx11.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx11.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx11.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx11.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx11.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx11.Name = "richTextBoxEx11";
            this.richTextBoxEx11.ReadOnly = true;
            this.richTextBoxEx11.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx11.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx11.TabIndex = 0;
            // 
            // tbDuplikat
            // 
            this.tbDuplikat.AttachedControl = this.tabControlPanel13;
            this.tbDuplikat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbDuplikat.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbDuplikat.Name = "tbDuplikat";
            this.tbDuplikat.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbDuplikat.Text = "Duplikat Nikah";
            this.tbDuplikat.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel12
            // 
            this.tabControlPanel12.Controls.Add(this.groupPanel10);
            this.tabControlPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel12.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel12.Name = "tabControlPanel12";
            this.tabControlPanel12.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel12.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel12.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel12.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel12.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel12.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel12.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel12.Style.GradientAngle = -90;
            this.tabControlPanel12.TabIndex = 12;
            this.tabControlPanel12.TabItem = this.tbRekomendasi;
            // 
            // groupPanel10
            // 
            this.groupPanel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel10.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel10.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel10.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel10.Controls.Add(this.dgvWorksheetRekomendasi);
            this.groupPanel10.Controls.Add(this.richTextBoxEx10);
            this.groupPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel10.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel10.Location = new System.Drawing.Point(1, 1);
            this.groupPanel10.Name = "groupPanel10";
            this.groupPanel10.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel10.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel10.Style.BackColorGradientAngle = 90;
            this.groupPanel10.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel10.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel10.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel10.Style.BorderBottomWidth = 1;
            this.groupPanel10.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel10.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel10.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel10.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel10.Style.BorderLeftWidth = 1;
            this.groupPanel10.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel10.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel10.Style.BorderRightWidth = 1;
            this.groupPanel10.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel10.Style.BorderTopWidth = 1;
            this.groupPanel10.Style.CornerDiameter = 4;
            this.groupPanel10.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel10.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel10.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel10.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel10.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel10.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel10.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel10.TabIndex = 81;
            // 
            // dgvWorksheetRekomendasi
            // 
            this.dgvWorksheetRekomendasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetRekomendasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetRekomendasi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetRekomendasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvWorksheetRekomendasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetRekomendasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanRekomendasi});
            this.dgvWorksheetRekomendasi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetRekomendasi.DefaultCellStyle = dataGridViewCellStyle34;
            this.dgvWorksheetRekomendasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetRekomendasi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetRekomendasi.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetRekomendasi.Name = "dgvWorksheetRekomendasi";
            this.dgvWorksheetRekomendasi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetRekomendasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetRekomendasi.RowHeadersDefaultCellStyle = dataGridViewCellStyle35;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetRekomendasi.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvWorksheetRekomendasi.SelectAllSignVisible = false;
            this.dgvWorksheetRekomendasi.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetRekomendasi.TabIndex = 1;
            this.dgvWorksheetRekomendasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetRekomendasi_CellClick);
            this.dgvWorksheetRekomendasi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetRekomendasi_CellEndEdit);
            this.dgvWorksheetRekomendasi.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetRekomendasi_DataError);
            this.dgvWorksheetRekomendasi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetRekomendasi_MouseMove);
            // 
            // cmbKegiatanRekomendasi
            // 
            this.cmbKegiatanRekomendasi.DisplayMember = "Text";
            this.cmbKegiatanRekomendasi.DropDownHeight = 106;
            this.cmbKegiatanRekomendasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanRekomendasi.DropDownWidth = 121;
            this.cmbKegiatanRekomendasi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanRekomendasi.HeaderText = "Kegiatan";
            this.cmbKegiatanRekomendasi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanRekomendasi.IntegralHeight = false;
            this.cmbKegiatanRekomendasi.ItemHeight = 15;
            this.cmbKegiatanRekomendasi.Name = "cmbKegiatanRekomendasi";
            this.cmbKegiatanRekomendasi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx10
            // 
            this.richTextBoxEx10.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx10.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx10.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx10.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx10.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx10.Name = "richTextBoxEx10";
            this.richTextBoxEx10.ReadOnly = true;
            this.richTextBoxEx10.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx10.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx10.TabIndex = 0;
            // 
            // tbRekomendasi
            // 
            this.tbRekomendasi.AttachedControl = this.tabControlPanel12;
            this.tbRekomendasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbRekomendasi.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbRekomendasi.Name = "tbRekomendasi";
            this.tbRekomendasi.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbRekomendasi.Text = "Rekomendasi Nikah";
            this.tbRekomendasi.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel11
            // 
            this.tabControlPanel11.Controls.Add(this.groupPanel9);
            this.tabControlPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel11.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel11.Name = "tabControlPanel11";
            this.tabControlPanel11.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel11.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel11.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel11.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel11.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel11.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel11.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel11.Style.GradientAngle = -90;
            this.tabControlPanel11.TabIndex = 11;
            this.tabControlPanel11.TabItem = this.tbKeuangan;
            // 
            // groupPanel9
            // 
            this.groupPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel9.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel9.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel9.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel9.Controls.Add(this.dgvWorksheetKeuangan);
            this.groupPanel9.Controls.Add(this.richTextBoxEx9);
            this.groupPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel9.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel9.Location = new System.Drawing.Point(1, 1);
            this.groupPanel9.Name = "groupPanel9";
            this.groupPanel9.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel9.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel9.Style.BackColorGradientAngle = 90;
            this.groupPanel9.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel9.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel9.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel9.Style.BorderBottomWidth = 1;
            this.groupPanel9.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel9.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel9.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel9.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel9.Style.BorderLeftWidth = 1;
            this.groupPanel9.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel9.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel9.Style.BorderRightWidth = 1;
            this.groupPanel9.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel9.Style.BorderTopWidth = 1;
            this.groupPanel9.Style.CornerDiameter = 4;
            this.groupPanel9.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel9.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel9.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel9.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel9.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel9.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel9.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel9.TabIndex = 80;
            // 
            // dgvWorksheetKeuangan
            // 
            this.dgvWorksheetKeuangan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetKeuangan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetKeuangan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetKeuangan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dgvWorksheetKeuangan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetKeuangan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanKeuangan});
            this.dgvWorksheetKeuangan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetKeuangan.DefaultCellStyle = dataGridViewCellStyle38;
            this.dgvWorksheetKeuangan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetKeuangan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetKeuangan.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetKeuangan.Name = "dgvWorksheetKeuangan";
            this.dgvWorksheetKeuangan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetKeuangan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetKeuangan.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            dataGridViewCellStyle40.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetKeuangan.RowsDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvWorksheetKeuangan.SelectAllSignVisible = false;
            this.dgvWorksheetKeuangan.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetKeuangan.TabIndex = 1;
            this.dgvWorksheetKeuangan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetKeuangan_CellClick);
            this.dgvWorksheetKeuangan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetKeuangan_DataError);
            this.dgvWorksheetKeuangan.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetKeuangan_MouseMove);
            // 
            // cmbKegiatanKeuangan
            // 
            this.cmbKegiatanKeuangan.DisplayMember = "Text";
            this.cmbKegiatanKeuangan.DropDownHeight = 106;
            this.cmbKegiatanKeuangan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanKeuangan.DropDownWidth = 121;
            this.cmbKegiatanKeuangan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanKeuangan.HeaderText = "Kegiatan";
            this.cmbKegiatanKeuangan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanKeuangan.IntegralHeight = false;
            this.cmbKegiatanKeuangan.ItemHeight = 15;
            this.cmbKegiatanKeuangan.Name = "cmbKegiatanKeuangan";
            this.cmbKegiatanKeuangan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx9
            // 
            this.richTextBoxEx9.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx9.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx9.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx9.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx9.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx9.Name = "richTextBoxEx9";
            this.richTextBoxEx9.ReadOnly = true;
            this.richTextBoxEx9.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx9.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx9.TabIndex = 0;
            // 
            // tbKeuangan
            // 
            this.tbKeuangan.AttachedControl = this.tabControlPanel11;
            this.tbKeuangan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbKeuangan.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbKeuangan.Name = "tbKeuangan";
            this.tbKeuangan.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbKeuangan.Text = "Keuangan";
            this.tbKeuangan.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel10
            // 
            this.tabControlPanel10.Controls.Add(this.groupPanel8);
            this.tabControlPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel10.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel10.Name = "tabControlPanel10";
            this.tabControlPanel10.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel10.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel10.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel10.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel10.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel10.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel10.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel10.Style.GradientAngle = -90;
            this.tabControlPanel10.TabIndex = 10;
            this.tabControlPanel10.TabItem = this.tbWakaf;
            // 
            // groupPanel8
            // 
            this.groupPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel8.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel8.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel8.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel8.Controls.Add(this.dgvWorksheetWakaf);
            this.groupPanel8.Controls.Add(this.richTextBoxEx8);
            this.groupPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel8.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel8.Location = new System.Drawing.Point(1, 1);
            this.groupPanel8.Name = "groupPanel8";
            this.groupPanel8.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel8.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel8.Style.BackColorGradientAngle = 90;
            this.groupPanel8.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel8.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel8.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel8.Style.BorderBottomWidth = 1;
            this.groupPanel8.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel8.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel8.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel8.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel8.Style.BorderLeftWidth = 1;
            this.groupPanel8.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel8.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel8.Style.BorderRightWidth = 1;
            this.groupPanel8.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel8.Style.BorderTopWidth = 1;
            this.groupPanel8.Style.CornerDiameter = 4;
            this.groupPanel8.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel8.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel8.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel8.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel8.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel8.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel8.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel8.TabIndex = 79;
            // 
            // dgvWorksheetWakaf
            // 
            this.dgvWorksheetWakaf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetWakaf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetWakaf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetWakaf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dgvWorksheetWakaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetWakaf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanWakaf});
            this.dgvWorksheetWakaf.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetWakaf.DefaultCellStyle = dataGridViewCellStyle42;
            this.dgvWorksheetWakaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetWakaf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetWakaf.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetWakaf.Name = "dgvWorksheetWakaf";
            this.dgvWorksheetWakaf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetWakaf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetWakaf.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle44.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle44.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetWakaf.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dgvWorksheetWakaf.SelectAllSignVisible = false;
            this.dgvWorksheetWakaf.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetWakaf.TabIndex = 1;
            this.dgvWorksheetWakaf.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetWakaf_CellClick);
            this.dgvWorksheetWakaf.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetWakaf_CellEndEdit);
            this.dgvWorksheetWakaf.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetWakaf_DataError);
            this.dgvWorksheetWakaf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetWakaf_MouseMove);
            // 
            // cmbKegiatanWakaf
            // 
            this.cmbKegiatanWakaf.DisplayMember = "Text";
            this.cmbKegiatanWakaf.DropDownHeight = 106;
            this.cmbKegiatanWakaf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanWakaf.DropDownWidth = 121;
            this.cmbKegiatanWakaf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanWakaf.HeaderText = "Kegiatan";
            this.cmbKegiatanWakaf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanWakaf.IntegralHeight = false;
            this.cmbKegiatanWakaf.ItemHeight = 15;
            this.cmbKegiatanWakaf.Name = "cmbKegiatanWakaf";
            this.cmbKegiatanWakaf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx8
            // 
            this.richTextBoxEx8.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx8.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx8.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx8.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx8.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx8.Name = "richTextBoxEx8";
            this.richTextBoxEx8.ReadOnly = true;
            this.richTextBoxEx8.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx8.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx8.TabIndex = 0;
            // 
            // tbWakaf
            // 
            this.tbWakaf.AttachedControl = this.tabControlPanel10;
            this.tbWakaf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbWakaf.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbWakaf.Name = "tbWakaf";
            this.tbWakaf.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbWakaf.Text = "Wakaf";
            this.tbWakaf.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Controls.Add(this.panelData);
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = -90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tbNikah;
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelData.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelData.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelData.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.panelData.Controls.Add(this.dgvWorksheetNikah);
            this.panelData.Controls.Add(this.richTextBoxEx2);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelData.Location = new System.Drawing.Point(1, 1);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1169, 411);
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
            this.panelData.TabIndex = 39;
            // 
            // dgvWorksheetNikah
            // 
            this.dgvWorksheetNikah.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetNikah.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetNikah.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle45.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle45.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle45.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle45.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle45.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetNikah.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle45;
            this.dgvWorksheetNikah.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetNikah.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanNikah});
            this.dgvWorksheetNikah.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetNikah.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgvWorksheetNikah.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetNikah.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetNikah.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetNikah.Name = "dgvWorksheetNikah";
            this.dgvWorksheetNikah.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetNikah.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetNikah.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetNikah.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvWorksheetNikah.SelectAllSignVisible = false;
            this.dgvWorksheetNikah.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetNikah.TabIndex = 1;
            this.dgvWorksheetNikah.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetNikah_CellClick);
            this.dgvWorksheetNikah.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetNikah_CellEndEdit);
            this.dgvWorksheetNikah.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetNikah_DataError);
            this.dgvWorksheetNikah.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetNikah_MouseMove);
            // 
            // cmbKegiatanNikah
            // 
            this.cmbKegiatanNikah.DisplayMember = "Text";
            this.cmbKegiatanNikah.DropDownHeight = 106;
            this.cmbKegiatanNikah.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanNikah.DropDownWidth = 121;
            this.cmbKegiatanNikah.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanNikah.HeaderText = "Kegiatan";
            this.cmbKegiatanNikah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanNikah.IntegralHeight = false;
            this.cmbKegiatanNikah.ItemHeight = 15;
            this.cmbKegiatanNikah.Name = "cmbKegiatanNikah";
            this.cmbKegiatanNikah.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.richTextBoxEx2.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx2.TabIndex = 0;
            // 
            // tbNikah
            // 
            this.tbNikah.AttachedControl = this.tabControlPanel1;
            this.tbNikah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbNikah.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbNikah.Name = "tbNikah";
            this.tbNikah.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbNikah.Text = "Pernikahan";
            this.tbNikah.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel20
            // 
            this.tabControlPanel20.Controls.Add(this.groupPanel17);
            this.tabControlPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel20.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel20.Name = "tabControlPanel20";
            this.tabControlPanel20.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel20.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel20.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tabControlPanel20.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tabControlPanel20.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel20.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel20.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel20.Style.GradientAngle = -90;
            this.tabControlPanel20.TabIndex = 20;
            this.tabControlPanel20.TabItem = this.tbModelNA;
            // 
            // groupPanel17
            // 
            this.groupPanel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel17.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel17.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel17.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel17.Controls.Add(this.dgvWorksheetModelNA);
            this.groupPanel17.Controls.Add(this.richTextBoxEx17);
            this.groupPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel17.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel17.Location = new System.Drawing.Point(1, 1);
            this.groupPanel17.Name = "groupPanel17";
            this.groupPanel17.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel17.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel17.Style.BackColorGradientAngle = 90;
            this.groupPanel17.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel17.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel17.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel17.Style.BorderBottomWidth = 1;
            this.groupPanel17.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel17.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel17.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel17.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel17.Style.BorderLeftWidth = 1;
            this.groupPanel17.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel17.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel17.Style.BorderRightWidth = 1;
            this.groupPanel17.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel17.Style.BorderTopWidth = 1;
            this.groupPanel17.Style.CornerDiameter = 4;
            this.groupPanel17.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel17.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel17.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel17.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel17.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel17.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel17.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel17.TabIndex = 40;
            // 
            // dgvWorksheetModelNA
            // 
            this.dgvWorksheetModelNA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvWorksheetModelNA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvWorksheetModelNA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetModelNA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWorksheetModelNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorksheetModelNA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmbKegiatanModelNA});
            this.dgvWorksheetModelNA.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorksheetModelNA.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorksheetModelNA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWorksheetModelNA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvWorksheetModelNA.Location = new System.Drawing.Point(0, 0);
            this.dgvWorksheetModelNA.Name = "dgvWorksheetModelNA";
            this.dgvWorksheetModelNA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorksheetModelNA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorksheetModelNA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvWorksheetModelNA.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorksheetModelNA.SelectAllSignVisible = false;
            this.dgvWorksheetModelNA.Size = new System.Drawing.Size(1163, 405);
            this.dgvWorksheetModelNA.TabIndex = 1;
            this.dgvWorksheetModelNA.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetModelNA_CellClick);
            this.dgvWorksheetModelNA.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorksheetModelNA_CellEndEdit);
            this.dgvWorksheetModelNA.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvWorksheetModelNA_DataError);
            this.dgvWorksheetModelNA.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvWorksheetModelNA_MouseMove);
            // 
            // cmbKegiatanModelNA
            // 
            this.cmbKegiatanModelNA.DisplayMember = "Text";
            this.cmbKegiatanModelNA.DropDownHeight = 106;
            this.cmbKegiatanModelNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKegiatanModelNA.DropDownWidth = 121;
            this.cmbKegiatanModelNA.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbKegiatanModelNA.HeaderText = "Kegiatan";
            this.cmbKegiatanModelNA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbKegiatanModelNA.IntegralHeight = false;
            this.cmbKegiatanModelNA.ItemHeight = 15;
            this.cmbKegiatanModelNA.Name = "cmbKegiatanModelNA";
            this.cmbKegiatanModelNA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // richTextBoxEx17
            // 
            this.richTextBoxEx17.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx17.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx17.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx17.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx17.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx17.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx17.Name = "richTextBoxEx17";
            this.richTextBoxEx17.ReadOnly = true;
            this.richTextBoxEx17.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx17.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx17.TabIndex = 0;
            // 
            // tbModelNA
            // 
            this.tbModelNA.AttachedControl = this.tabControlPanel20;
            this.tbModelNA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbModelNA.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbModelNA.Name = "tbModelNA";
            this.tbModelNA.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbModelNA.Text = "Model NA.[Pernikahan]";
            this.tbModelNA.TextColor = System.Drawing.Color.Black;
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.groupPanel1);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel1.Controls.Add(this.dgvSyncModelNA);
            this.groupPanel1.Controls.Add(this.dgvSyncPernikahan);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(1, 1);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel1.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel1.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel1.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel1.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 40;
            // 
            // dgvSyncModelNA
            // 
            this.dgvSyncModelNA.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncModelNA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncModelNA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle49.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle49.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle49.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle49.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle49.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle49.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncModelNA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvSyncModelNA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncModelNA.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncModelNA.DefaultCellStyle = dataGridViewCellStyle50;
            this.dgvSyncModelNA.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncModelNA.Location = new System.Drawing.Point(22, 170);
            this.dgvSyncModelNA.Name = "dgvSyncModelNA";
            this.dgvSyncModelNA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncModelNA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncModelNA.RowHeadersDefaultCellStyle = dataGridViewCellStyle51;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncModelNA.RowsDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvSyncModelNA.SelectAllSignVisible = false;
            this.dgvSyncModelNA.Size = new System.Drawing.Size(898, 104);
            this.dgvSyncModelNA.TabIndex = 5;
            // 
            // dgvSyncPernikahan
            // 
            this.dgvSyncPernikahan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncPernikahan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncPernikahan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle53.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle53.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle53.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle53.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle53.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle53.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncPernikahan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle53;
            this.dgvSyncPernikahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncPernikahan.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncPernikahan.DefaultCellStyle = dataGridViewCellStyle54;
            this.dgvSyncPernikahan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncPernikahan.Location = new System.Drawing.Point(22, 24);
            this.dgvSyncPernikahan.Name = "dgvSyncPernikahan";
            this.dgvSyncPernikahan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncPernikahan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncPernikahan.RowHeadersDefaultCellStyle = dataGridViewCellStyle55;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncPernikahan.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvSyncPernikahan.SelectAllSignVisible = false;
            this.dgvSyncPernikahan.Size = new System.Drawing.Size(898, 104);
            this.dgvSyncPernikahan.TabIndex = 2;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = " Sync Pernikahaan";
            this.tabItem2.Visible = false;
            // 
            // tabControlPanel21
            // 
            this.tabControlPanel21.Controls.Add(this.dgvSyncSuratKeluar);
            this.tabControlPanel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel21.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel21.Name = "tabControlPanel21";
            this.tabControlPanel21.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel21.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel21.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel21.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel21.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel21.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel21.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel21.Style.GradientAngle = 90;
            this.tabControlPanel21.TabIndex = 21;
            this.tabControlPanel21.TabItem = this.taaa;
            this.tabControlPanel21.Visible = false;
            // 
            // dgvSyncSuratKeluar
            // 
            this.dgvSyncSuratKeluar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncSuratKeluar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncSuratKeluar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle57.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle57.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle57.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle57.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle57.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle57.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncSuratKeluar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle57;
            this.dgvSyncSuratKeluar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncSuratKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle58.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle58.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle58.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle58.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle58.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncSuratKeluar.DefaultCellStyle = dataGridViewCellStyle58;
            this.dgvSyncSuratKeluar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncSuratKeluar.Location = new System.Drawing.Point(129, 144);
            this.dgvSyncSuratKeluar.Name = "dgvSyncSuratKeluar";
            this.dgvSyncSuratKeluar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncSuratKeluar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle59.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle59.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle59.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle59.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle59.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle59.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncSuratKeluar.RowHeadersDefaultCellStyle = dataGridViewCellStyle59;
            dataGridViewCellStyle60.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle60.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncSuratKeluar.RowsDefaultCellStyle = dataGridViewCellStyle60;
            this.dgvSyncSuratKeluar.SelectAllSignVisible = false;
            this.dgvSyncSuratKeluar.Size = new System.Drawing.Size(913, 152);
            this.dgvSyncSuratKeluar.TabIndex = 3;
            // 
            // taaa
            // 
            this.taaa.AttachedControl = this.tabControlPanel21;
            this.taaa.Name = "taaa";
            this.taaa.Text = "Sync Surat Keluar";
            this.taaa.Visible = false;
            // 
            // tabControlPanel8
            // 
            this.tabControlPanel8.Controls.Add(this.dgvSyncHaji);
            this.tabControlPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel8.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel8.Name = "tabControlPanel8";
            this.tabControlPanel8.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel8.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel8.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel8.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel8.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel8.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel8.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel8.Style.GradientAngle = 90;
            this.tabControlPanel8.TabIndex = 8;
            this.tabControlPanel8.TabItem = this.tabItem8;
            // 
            // dgvSyncHaji
            // 
            this.dgvSyncHaji.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncHaji.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncHaji.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle61.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle61.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle61.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle61.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle61.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle61.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle61.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncHaji.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle61;
            this.dgvSyncHaji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncHaji.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle62.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle62.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle62.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle62.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle62.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle62.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncHaji.DefaultCellStyle = dataGridViewCellStyle62;
            this.dgvSyncHaji.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncHaji.Location = new System.Drawing.Point(145, 48);
            this.dgvSyncHaji.Name = "dgvSyncHaji";
            this.dgvSyncHaji.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncHaji.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle63.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle63.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle63.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle63.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle63.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle63.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncHaji.RowHeadersDefaultCellStyle = dataGridViewCellStyle63;
            dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle64.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncHaji.RowsDefaultCellStyle = dataGridViewCellStyle64;
            this.dgvSyncHaji.SelectAllSignVisible = false;
            this.dgvSyncHaji.Size = new System.Drawing.Size(913, 152);
            this.dgvSyncHaji.TabIndex = 2;
            // 
            // tabItem8
            // 
            this.tabItem8.AttachedControl = this.tabControlPanel8;
            this.tabItem8.Name = "tabItem8";
            this.tabItem8.Text = "Sync Haji";
            this.tabItem8.Visible = false;
            // 
            // tabControlPanel6
            // 
            this.tabControlPanel6.Controls.Add(this.groupPanel5);
            this.tabControlPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel6.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel6.Name = "tabControlPanel6";
            this.tabControlPanel6.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel6.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel6.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel6.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel6.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel6.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel6.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel6.Style.GradientAngle = 90;
            this.tabControlPanel6.TabIndex = 6;
            this.tabControlPanel6.TabItem = this.tabItem6;
            // 
            // groupPanel5
            // 
            this.groupPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel5.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel5.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel5.Controls.Add(this.dgvSyncMasukIslam);
            this.groupPanel5.Controls.Add(this.richTextBoxEx5);
            this.groupPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel5.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel5.Location = new System.Drawing.Point(1, 1);
            this.groupPanel5.Name = "groupPanel5";
            this.groupPanel5.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel5.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel5.Style.BackColorGradientAngle = 90;
            this.groupPanel5.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel5.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel5.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel5.Style.BorderBottomWidth = 1;
            this.groupPanel5.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel5.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel5.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel5.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel5.Style.BorderLeftWidth = 1;
            this.groupPanel5.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel5.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel5.Style.BorderRightWidth = 1;
            this.groupPanel5.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel5.Style.BorderTopWidth = 1;
            this.groupPanel5.Style.CornerDiameter = 4;
            this.groupPanel5.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel5.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel5.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel5.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel5.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel5.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel5.TabIndex = 78;
            // 
            // dgvSyncMasukIslam
            // 
            this.dgvSyncMasukIslam.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncMasukIslam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncMasukIslam.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle65.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle65.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle65.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle65.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncMasukIslam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
            this.dgvSyncMasukIslam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncMasukIslam.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle66.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle66.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle66.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle66.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle66.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle66.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncMasukIslam.DefaultCellStyle = dataGridViewCellStyle66;
            this.dgvSyncMasukIslam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSyncMasukIslam.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncMasukIslam.Location = new System.Drawing.Point(0, 0);
            this.dgvSyncMasukIslam.Name = "dgvSyncMasukIslam";
            this.dgvSyncMasukIslam.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncMasukIslam.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle67.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle67.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle67.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle67.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle67.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle67.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncMasukIslam.RowHeadersDefaultCellStyle = dataGridViewCellStyle67;
            dataGridViewCellStyle68.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle68.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncMasukIslam.RowsDefaultCellStyle = dataGridViewCellStyle68;
            this.dgvSyncMasukIslam.SelectAllSignVisible = false;
            this.dgvSyncMasukIslam.Size = new System.Drawing.Size(1163, 405);
            this.dgvSyncMasukIslam.TabIndex = 1;
            // 
            // richTextBoxEx5
            // 
            this.richTextBoxEx5.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx5.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx5.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx5.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx5.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx5.Name = "richTextBoxEx5";
            this.richTextBoxEx5.ReadOnly = true;
            this.richTextBoxEx5.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx5.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx5.TabIndex = 0;
            // 
            // tabItem6
            // 
            this.tabItem6.AttachedControl = this.tabControlPanel6;
            this.tabItem6.Name = "tabItem6";
            this.tabItem6.Text = "Sync Masuk Islam";
            this.tabItem6.Visible = false;
            // 
            // tabControlPanel5
            // 
            this.tabControlPanel5.Controls.Add(this.groupPanel4);
            this.tabControlPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel5.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel5.Name = "tabControlPanel5";
            this.tabControlPanel5.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel5.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel5.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel5.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel5.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel5.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel5.Style.GradientAngle = 90;
            this.tabControlPanel5.TabIndex = 5;
            this.tabControlPanel5.TabItem = this.tabItem5;
            // 
            // groupPanel4
            // 
            this.groupPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel4.Controls.Add(this.dgvSyncDuplikat);
            this.groupPanel4.Controls.Add(this.richTextBoxEx4);
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel4.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel4.Location = new System.Drawing.Point(1, 1);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel4.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel4.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel4.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel4.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 78;
            // 
            // dgvSyncDuplikat
            // 
            this.dgvSyncDuplikat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncDuplikat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncDuplikat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle69.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle69.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle69.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle69.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncDuplikat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle69;
            this.dgvSyncDuplikat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncDuplikat.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle70.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle70.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle70.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle70.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncDuplikat.DefaultCellStyle = dataGridViewCellStyle70;
            this.dgvSyncDuplikat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSyncDuplikat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncDuplikat.Location = new System.Drawing.Point(0, 0);
            this.dgvSyncDuplikat.Name = "dgvSyncDuplikat";
            this.dgvSyncDuplikat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncDuplikat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle71.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle71.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle71.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle71.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle71.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle71.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncDuplikat.RowHeadersDefaultCellStyle = dataGridViewCellStyle71;
            dataGridViewCellStyle72.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle72.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle72.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncDuplikat.RowsDefaultCellStyle = dataGridViewCellStyle72;
            this.dgvSyncDuplikat.SelectAllSignVisible = false;
            this.dgvSyncDuplikat.Size = new System.Drawing.Size(1163, 405);
            this.dgvSyncDuplikat.TabIndex = 1;
            // 
            // richTextBoxEx4
            // 
            this.richTextBoxEx4.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx4.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx4.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx4.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx4.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx4.Name = "richTextBoxEx4";
            this.richTextBoxEx4.ReadOnly = true;
            this.richTextBoxEx4.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx4.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx4.TabIndex = 0;
            // 
            // tabItem5
            // 
            this.tabItem5.AttachedControl = this.tabControlPanel5;
            this.tabItem5.Name = "tabItem5";
            this.tabItem5.Text = "Sync Duplikat Nikah";
            this.tabItem5.Visible = false;
            // 
            // tabControlPanel4
            // 
            this.tabControlPanel4.Controls.Add(this.groupPanel3);
            this.tabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel4.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel4.Name = "tabControlPanel4";
            this.tabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel4.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel4.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel4.Style.GradientAngle = 90;
            this.tabControlPanel4.TabIndex = 4;
            this.tabControlPanel4.TabItem = this.tabItem4;
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel3.Controls.Add(this.dgvSyncRekomendasi);
            this.groupPanel3.Controls.Add(this.richTextBoxEx3);
            this.groupPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel3.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.Location = new System.Drawing.Point(1, 1);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel3.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel3.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel3.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel3.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 78;
            // 
            // dgvSyncRekomendasi
            // 
            this.dgvSyncRekomendasi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncRekomendasi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncRekomendasi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle73.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle73.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle73.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle73.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle73.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle73.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle73.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncRekomendasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle73;
            this.dgvSyncRekomendasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncRekomendasi.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle74.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle74.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle74.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle74.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle74.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle74.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle74.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncRekomendasi.DefaultCellStyle = dataGridViewCellStyle74;
            this.dgvSyncRekomendasi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSyncRekomendasi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncRekomendasi.Location = new System.Drawing.Point(0, 0);
            this.dgvSyncRekomendasi.Name = "dgvSyncRekomendasi";
            this.dgvSyncRekomendasi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncRekomendasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle75.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle75.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle75.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle75.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle75.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle75.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncRekomendasi.RowHeadersDefaultCellStyle = dataGridViewCellStyle75;
            dataGridViewCellStyle76.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle76.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle76.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncRekomendasi.RowsDefaultCellStyle = dataGridViewCellStyle76;
            this.dgvSyncRekomendasi.SelectAllSignVisible = false;
            this.dgvSyncRekomendasi.Size = new System.Drawing.Size(1163, 405);
            this.dgvSyncRekomendasi.TabIndex = 1;
            // 
            // richTextBoxEx3
            // 
            this.richTextBoxEx3.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx3.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx3.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx3.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx3.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx3.Name = "richTextBoxEx3";
            this.richTextBoxEx3.ReadOnly = true;
            this.richTextBoxEx3.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx3.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx3.TabIndex = 0;
            // 
            // tabItem4
            // 
            this.tabItem4.AttachedControl = this.tabControlPanel4;
            this.tabItem4.Name = "tabItem4";
            this.tabItem4.Text = "Sync Rekomendasi Nikah";
            this.tabItem4.Visible = false;
            // 
            // tabControlPanel3
            // 
            this.tabControlPanel3.Controls.Add(this.groupPanel2);
            this.tabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel3.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel3.Name = "tabControlPanel3";
            this.tabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel3.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel3.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel3.Style.GradientAngle = 90;
            this.tabControlPanel3.TabIndex = 3;
            this.tabControlPanel3.TabItem = this.tabItem3;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel2.Controls.Add(this.dgvSyncWakaf);
            this.groupPanel2.Controls.Add(this.richTextBoxEx1);
            this.groupPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel2.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(1, 1);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel2.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel2.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel2.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel2.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 78;
            // 
            // dgvSyncWakaf
            // 
            this.dgvSyncWakaf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncWakaf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncWakaf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle77.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle77.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle77.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle77.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle77.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle77.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle77.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncWakaf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle77;
            this.dgvSyncWakaf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncWakaf.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle78.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle78.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle78.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle78.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle78.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle78.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle78.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncWakaf.DefaultCellStyle = dataGridViewCellStyle78;
            this.dgvSyncWakaf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSyncWakaf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncWakaf.Location = new System.Drawing.Point(0, 0);
            this.dgvSyncWakaf.Name = "dgvSyncWakaf";
            this.dgvSyncWakaf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncWakaf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle79.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle79.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle79.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle79.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle79.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle79.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle79.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncWakaf.RowHeadersDefaultCellStyle = dataGridViewCellStyle79;
            dataGridViewCellStyle80.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle80.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle80.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncWakaf.RowsDefaultCellStyle = dataGridViewCellStyle80;
            this.dgvSyncWakaf.SelectAllSignVisible = false;
            this.dgvSyncWakaf.Size = new System.Drawing.Size(1163, 405);
            this.dgvSyncWakaf.TabIndex = 1;
            // 
            // richTextBoxEx1
            // 
            this.richTextBoxEx1.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx1.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx1.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx1.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx1.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx1.Name = "richTextBoxEx1";
            this.richTextBoxEx1.ReadOnly = true;
            this.richTextBoxEx1.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx1.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx1.TabIndex = 0;
            // 
            // tabItem3
            // 
            this.tabItem3.AttachedControl = this.tabControlPanel3;
            this.tabItem3.Name = "tabItem3";
            this.tabItem3.Text = "Sync Wakaf";
            this.tabItem3.Visible = false;
            // 
            // tabControlPanel7
            // 
            this.tabControlPanel7.Controls.Add(this.groupPanel6);
            this.tabControlPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel7.Location = new System.Drawing.Point(0, 29);
            this.tabControlPanel7.Name = "tabControlPanel7";
            this.tabControlPanel7.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel7.Size = new System.Drawing.Size(1171, 413);
            this.tabControlPanel7.Style.BackColor1.Color = System.Drawing.Color.White;
            this.tabControlPanel7.Style.BackColor2.Color = System.Drawing.Color.White;
            this.tabControlPanel7.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel7.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.tabControlPanel7.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel7.Style.GradientAngle = 90;
            this.tabControlPanel7.TabIndex = 7;
            this.tabControlPanel7.TabItem = this.tabItem7;
            // 
            // groupPanel6
            // 
            this.groupPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel6.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel6.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel6.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Green;
            this.groupPanel6.Controls.Add(this.dgvSyncCerai);
            this.groupPanel6.Controls.Add(this.dgvSyncTalak);
            this.groupPanel6.Controls.Add(this.richTextBoxEx6);
            this.groupPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel6.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel6.Location = new System.Drawing.Point(1, 1);
            this.groupPanel6.Name = "groupPanel6";
            this.groupPanel6.Size = new System.Drawing.Size(1169, 411);
            // 
            // 
            // 
            this.groupPanel6.Style.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupPanel6.Style.BackColorGradientAngle = 90;
            this.groupPanel6.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarPopupBorder;
            this.groupPanel6.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel6.Style.BorderBottomColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel6.Style.BorderBottomWidth = 1;
            this.groupPanel6.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.groupPanel6.Style.BorderColor2 = System.Drawing.Color.Blue;
            this.groupPanel6.Style.BorderColorLight = System.Drawing.SystemColors.Highlight;
            this.groupPanel6.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel6.Style.BorderLeftWidth = 1;
            this.groupPanel6.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel6.Style.BorderRightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionText;
            this.groupPanel6.Style.BorderRightWidth = 1;
            this.groupPanel6.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Etched;
            this.groupPanel6.Style.BorderTopWidth = 1;
            this.groupPanel6.Style.CornerDiameter = 4;
            this.groupPanel6.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel6.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel6.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel6.Style.TextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupPanel6.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel6.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel6.TabIndex = 78;
            // 
            // dgvSyncCerai
            // 
            this.dgvSyncCerai.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncCerai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncCerai.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle81.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle81.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle81.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle81.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle81.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle81.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle81.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncCerai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle81;
            this.dgvSyncCerai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncCerai.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle82.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle82.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle82.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle82.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle82.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle82.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle82.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncCerai.DefaultCellStyle = dataGridViewCellStyle82;
            this.dgvSyncCerai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncCerai.Location = new System.Drawing.Point(8, 202);
            this.dgvSyncCerai.Name = "dgvSyncCerai";
            this.dgvSyncCerai.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncCerai.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle83.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle83.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle83.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle83.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle83.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle83.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle83.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncCerai.RowHeadersDefaultCellStyle = dataGridViewCellStyle83;
            dataGridViewCellStyle84.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle84.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle84.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncCerai.RowsDefaultCellStyle = dataGridViewCellStyle84;
            this.dgvSyncCerai.SelectAllSignVisible = false;
            this.dgvSyncCerai.Size = new System.Drawing.Size(913, 177);
            this.dgvSyncCerai.TabIndex = 2;
            // 
            // dgvSyncTalak
            // 
            this.dgvSyncTalak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSyncTalak.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSyncTalak.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle85.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle85.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle85.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle85.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle85.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle85.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle85.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncTalak.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle85;
            this.dgvSyncTalak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSyncTalak.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle86.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle86.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle86.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle86.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle86.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle86.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle86.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSyncTalak.DefaultCellStyle = dataGridViewCellStyle86;
            this.dgvSyncTalak.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvSyncTalak.Location = new System.Drawing.Point(8, 12);
            this.dgvSyncTalak.Name = "dgvSyncTalak";
            this.dgvSyncTalak.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvSyncTalak.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle87.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle87.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle87.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle87.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle87.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle87.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle87.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSyncTalak.RowHeadersDefaultCellStyle = dataGridViewCellStyle87;
            dataGridViewCellStyle88.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle88.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle88.ForeColor = System.Drawing.Color.Black;
            this.dgvSyncTalak.RowsDefaultCellStyle = dataGridViewCellStyle88;
            this.dgvSyncTalak.SelectAllSignVisible = false;
            this.dgvSyncTalak.Size = new System.Drawing.Size(913, 152);
            this.dgvSyncTalak.TabIndex = 1;
            // 
            // richTextBoxEx6
            // 
            this.richTextBoxEx6.BackColor = System.Drawing.Color.White;
            this.richTextBoxEx6.BackColorRichTextBox = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.richTextBoxEx6.BackgroundStyle.Class = "RichTextBoxBorder";
            this.richTextBoxEx6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.richTextBoxEx6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxEx6.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxEx6.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxEx6.Name = "richTextBoxEx6";
            this.richTextBoxEx6.ReadOnly = true;
            this.richTextBoxEx6.Rtf = "{\\rtf1\\ansi\\ansicpg1252\\deff0\\deflang1057{\\fonttbl{\\f0\\fnil\\fcharset0 Roboto Cond" +
    "ensed;}}\r\n\\viewkind4\\uc1\\pard\\f0\\fs17\\par\r\n}\r\n";
            this.richTextBoxEx6.Size = new System.Drawing.Size(1163, 405);
            this.richTextBoxEx6.TabIndex = 0;
            // 
            // tabItem7
            // 
            this.tabItem7.AttachedControl = this.tabControlPanel7;
            this.tabItem7.Name = "tabItem7";
            this.tabItem7.Text = "Sync Talak dan Cerai";
            this.tabItem7.Visible = false;
            // 
            // tbAktaNikah
            // 
            this.tbAktaNikah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.tbAktaNikah.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.tbAktaNikah.Name = "tbAktaNikah";
            this.tbAktaNikah.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.tbAktaNikah.Text = "Akta Nikah.[Pernikahan]";
            this.tbAktaNikah.TextColor = System.Drawing.Color.Black;
            // 
            // highlighter1
            // 
            this.highlighter1.ContainerControl = this;
            // 
            // FrmCreateCapaianKinerjaHarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 524);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCreateCapaianKinerjaHarian";
            this.Text = "Lembar Capaian Kinerja harian - SIMKAP 1.0.0";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel18.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.tabControlPanel17.ResumeLayout(false);
            this.groupPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetOthers)).EndInit();
            this.tabControlPanel22.ResumeLayout(false);
            this.groupPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetSuratKeluar)).EndInit();
            this.tabControlPanel19.ResumeLayout(false);
            this.groupPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetHaji)).EndInit();
            this.tabControlPanel16.ResumeLayout(false);
            this.groupPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetCerai)).EndInit();
            this.tabControlPanel15.ResumeLayout(false);
            this.groupPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetTalak)).EndInit();
            this.tabControlPanel14.ResumeLayout(false);
            this.groupPanel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetMasukIslam)).EndInit();
            this.tabControlPanel13.ResumeLayout(false);
            this.groupPanel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetDuplikat)).EndInit();
            this.tabControlPanel12.ResumeLayout(false);
            this.groupPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetRekomendasi)).EndInit();
            this.tabControlPanel11.ResumeLayout(false);
            this.groupPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetKeuangan)).EndInit();
            this.tabControlPanel10.ResumeLayout(false);
            this.groupPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetWakaf)).EndInit();
            this.tabControlPanel1.ResumeLayout(false);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetNikah)).EndInit();
            this.tabControlPanel20.ResumeLayout(false);
            this.groupPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorksheetModelNA)).EndInit();
            this.tabControlPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncModelNA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncPernikahan)).EndInit();
            this.tabControlPanel21.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncSuratKeluar)).EndInit();
            this.tabControlPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncHaji)).EndInit();
            this.tabControlPanel6.ResumeLayout(false);
            this.groupPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncMasukIslam)).EndInit();
            this.tabControlPanel5.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncDuplikat)).EndInit();
            this.tabControlPanel4.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncRekomendasi)).EndInit();
            this.tabControlPanel3.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncWakaf)).EndInit();
            this.tabControlPanel7.ResumeLayout(false);
            this.groupPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncCerai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSyncTalak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel18;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtIdJenisKegiatan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbWorkSheet;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnClose;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbJenisKegiatan;
        private DevComponents.DotNetBar.ButtonX btnViewWorkSheet;
        private DevComponents.DotNetBar.TabItem tbSelectWorkSheet;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel22;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel18;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetSuratKeluar;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx18;
        private DevComponents.DotNetBar.TabItem tbSuratKeluar;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel16;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel14;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetCerai;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx14;
        private DevComponents.DotNetBar.TabItem tbCerai;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel19;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel16;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetHaji;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx16;
        private DevComponents.DotNetBar.TabItem tbHaji;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel panelData;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetNikah;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx2;
        private DevComponents.DotNetBar.TabItem tbNikah;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel20;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel17;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetModelNA;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx17;
        private DevComponents.DotNetBar.TabItem tbModelNA;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel21;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncSuratKeluar;
        private DevComponents.DotNetBar.TabItem taaa;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncHaji;
        private DevComponents.DotNetBar.TabItem tabItem8;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel6;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncMasukIslam;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx5;
        private DevComponents.DotNetBar.TabItem tabItem6;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel5;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncDuplikat;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx4;
        private DevComponents.DotNetBar.TabItem tabItem5;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncRekomendasi;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx3;
        private DevComponents.DotNetBar.TabItem tabItem4;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncPernikahan;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncWakaf;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx1;
        private DevComponents.DotNetBar.TabItem tabItem3;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel17;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel15;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetOthers;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx15;
        private DevComponents.DotNetBar.TabItem tbOthers;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel11;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel9;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetKeuangan;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx9;
        private DevComponents.DotNetBar.TabItem tbKeuangan;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel15;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel12;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetTalak;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx12;
        private DevComponents.DotNetBar.TabItem tbTalak;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel14;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel13;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetMasukIslam;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx13;
        private System.Windows.Forms.Panel panel8;
        private DevComponents.DotNetBar.TabItem tbMasukIslam;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel12;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel10;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetRekomendasi;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx10;
        private DevComponents.DotNetBar.TabItem tbRekomendasi;
        private DevComponents.DotNetBar.TabItem tbAktaNikah;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel13;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel11;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetDuplikat;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx11;
        private DevComponents.DotNetBar.TabItem tbDuplikat;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel10;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel8;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvWorksheetWakaf;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx8;
        private DevComponents.DotNetBar.TabItem tbWakaf;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel7;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel6;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncCerai;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvSyncTalak;
        private DevComponents.DotNetBar.Controls.RichTextBoxEx richTextBoxEx6;
        private DevComponents.DotNetBar.TabItem tabItem7;
        private DataGridViewX dgvSyncModelNA;
        private DevComponents.DotNetBar.ButtonX btnSync;
        private DateTimePicker dtDate;
        private DataGridViewComboBoxExColumn cmbKegiatanLainnya;
        private DataGridViewComboBoxExColumn cmbKegiatanSuratKeluar;
        private DataGridViewComboBoxExColumn cmbKegiatanHaji;
        private DataGridViewComboBoxExColumn cmbKegiatanCerai;
        private DataGridViewComboBoxExColumn cmbKegiatanTalak;
        private DataGridViewComboBoxExColumn cmbKegiatanMasukIslam;
        private DataGridViewComboBoxExColumn cmbKegiatanDuplikat;
        private DataGridViewComboBoxExColumn cmbKegiatanRekomendasi;
        private DataGridViewComboBoxExColumn cmbKegiatanKeuangan;
        private DataGridViewComboBoxExColumn cmbKegiatanWakaf;
        private DataGridViewComboBoxExColumn cmbKegiatanNikah;
        private DataGridViewComboBoxExColumn cmbKegiatanModelNA;
        private DevComponents.DotNetBar.ButtonX btnDelete;


        #region Variabel

        private IntRemoteLCKH irl;
        private IntRemoteWriteTransactionClient rwc;
        private string status;
        private Action<Form> viewForm;
        private EntLCKH elc;
        private EntRemoteTransactionClient etc;
        private EntLoginPegawai elp;
        private DataTable dt;
        private ThreadStart client1;
        private Thread client2;
        private Thread mThread;
        private DataGridView dg;
        private SizeF size;
        private Brush b;
        private EventArgs e;
        private object sender;
        private string receiveipaddress;
        private string receivenama;
        private string receiveperiodeawal;
        private string receiveperiodeakhir;
        private string receivejabatan;
        private string obj;
        private string message;
        private string data;
        private string procces;
        private string statuskegiatan;
        private string keterangan;
        private bool condition;
        private int rowDgv;
        private SettingIpAddress setting = new SettingIpAddress();

        #endregion

        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    }
}