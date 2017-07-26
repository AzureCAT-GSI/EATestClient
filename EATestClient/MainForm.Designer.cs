namespace EATestClient
{
    partial class MainForm
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.usageListTab = new System.Windows.Forms.TabPage();
            this.exportTypeList = new System.Windows.Forms.ComboBox();
            this.exportFormatLbl = new System.Windows.Forms.Label();
            this.exportView = new System.Windows.Forms.Button();
            this.currentDataLabel = new System.Windows.Forms.Label();
            this.dataTabs = new System.Windows.Forms.TabControl();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.usageReportDataGrid = new System.Windows.Forms.DataGridView();
            this.publicPricingTab = new System.Windows.Forms.TabPage();
            this.getPublicPricingBtn = new System.Windows.Forms.Button();
            this.regionLst = new System.Windows.Forms.ComboBox();
            this.regionLbl = new System.Windows.Forms.Label();
            this.localeLst = new System.Windows.Forms.ComboBox();
            this.localeLbl = new System.Windows.Forms.Label();
            this.currencyLbl = new System.Windows.Forms.Label();
            this.offerDetailsLnk = new System.Windows.Forms.LinkLabel();
            this.currencyLst = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.offerCodeLst = new System.Windows.Forms.ComboBox();
            this.publicPricingDataGrid = new System.Windows.Forms.DataGridView();
            this.combinedTab = new System.Windows.Forms.TabPage();
            this.reconciledDataGrid = new System.Windows.Forms.DataGridView();
            this.rawJsonTab = new System.Windows.Forms.TabPage();
            this.usageListJsonTx = new System.Windows.Forms.TextBox();
            this.availReportTree = new System.Windows.Forms.TreeView();
            this.availUsageReportLbl = new System.Windows.Forms.Label();
            this.dataDislayDateLbl = new System.Windows.Forms.Label();
            this.getReportDataBtn = new System.Windows.Forms.Button();
            this.usageByMonthTab = new System.Windows.Forms.TabPage();
            this.formatCB = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.reportTypeCB = new System.Windows.Forms.ComboBox();
            this.reportTypeLbl = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.jsonResponseLbl = new System.Windows.Forms.Label();
            this.jsonMonthTx = new System.Windows.Forms.TextBox();
            this.streamDownloadBtn = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.enrollmentMonthTx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.configTab = new System.Windows.Forms.TabPage();
            this.saveConifigBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.azureSharedSecretTxt = new System.Windows.Forms.TextBox();
            this.azureSharedSecretLbl = new System.Windows.Forms.Label();
            this.azureSubscriptionIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.azureTenantIdTxt = new System.Windows.Forms.TextBox();
            this.aadTenantIdLbl = new System.Windows.Forms.Label();
            this.azureClientIdTxt = new System.Windows.Forms.TextBox();
            this.azureClientIdLbl = new System.Windows.Forms.Label();
            this.accessKeysGroup = new System.Windows.Forms.GroupBox();
            this.eaSubscriptionIdTxt = new System.Windows.Forms.TextBox();
            this.azureSubscriptionIdLbl = new System.Windows.Forms.Label();
            this.accessKeyPriceBlankLbl = new System.Windows.Forms.Label();
            this.accessKeyUsageTxt = new System.Windows.Forms.TextBox();
            this.eaTestKeyLnk = new System.Windows.Forms.LinkLabel();
            this.accessKeyPriceTxt = new System.Windows.Forms.TextBox();
            this.accessKeyPriceLbl = new System.Windows.Forms.Label();
            this.enrollmentTx = new System.Windows.Forms.TextBox();
            this.accessKeyUsageLbl = new System.Windows.Forms.Label();
            this.enrollmentKeyTxtLbl = new System.Windows.Forms.Label();
            this.enrollmentNumLbl = new System.Windows.Forms.Label();
            this.dataTabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combinedDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBottomLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusBottomStatus1 = new System.Windows.Forms.ToolStripProgressBar();
            this.mainTabs.SuspendLayout();
            this.usageListTab.SuspendLayout();
            this.dataTabs.SuspendLayout();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).BeginInit();
            this.publicPricingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicPricingDataGrid)).BeginInit();
            this.combinedTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconciledDataGrid)).BeginInit();
            this.rawJsonTab.SuspendLayout();
            this.usageByMonthTab.SuspendLayout();
            this.configTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.accessKeysGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.usageListTab);
            this.mainTabs.Controls.Add(this.usageByMonthTab);
            this.mainTabs.Controls.Add(this.configTab);
            this.mainTabs.Location = new System.Drawing.Point(13, 13);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1158, 660);
            this.mainTabs.TabIndex = 0;
            // 
            // usageListTab
            // 
            this.usageListTab.Controls.Add(this.exportTypeList);
            this.usageListTab.Controls.Add(this.exportFormatLbl);
            this.usageListTab.Controls.Add(this.exportView);
            this.usageListTab.Controls.Add(this.currentDataLabel);
            this.usageListTab.Controls.Add(this.dataTabs);
            this.usageListTab.Controls.Add(this.availReportTree);
            this.usageListTab.Controls.Add(this.availUsageReportLbl);
            this.usageListTab.Controls.Add(this.dataDislayDateLbl);
            this.usageListTab.Controls.Add(this.getReportDataBtn);
            this.usageListTab.Location = new System.Drawing.Point(4, 22);
            this.usageListTab.Name = "usageListTab";
            this.usageListTab.Padding = new System.Windows.Forms.Padding(3);
            this.usageListTab.Size = new System.Drawing.Size(1150, 634);
            this.usageListTab.TabIndex = 0;
            this.usageListTab.Text = "Usage List";
            this.usageListTab.UseVisualStyleBackColor = true;
            // 
            // exportTypeList
            // 
            this.exportTypeList.FormattingEnabled = true;
            this.exportTypeList.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.exportTypeList.Location = new System.Drawing.Point(908, 590);
            this.exportTypeList.Name = "exportTypeList";
            this.exportTypeList.Size = new System.Drawing.Size(121, 21);
            this.exportTypeList.TabIndex = 23;
            this.exportTypeList.Text = "CSV";
            // 
            // exportFormatLbl
            // 
            this.exportFormatLbl.AutoSize = true;
            this.exportFormatLbl.Location = new System.Drawing.Point(827, 593);
            this.exportFormatLbl.Name = "exportFormatLbl";
            this.exportFormatLbl.Size = new System.Drawing.Size(75, 13);
            this.exportFormatLbl.TabIndex = 22;
            this.exportFormatLbl.Text = "Export Format:";
            // 
            // exportView
            // 
            this.exportView.Location = new System.Drawing.Point(1046, 588);
            this.exportView.Name = "exportView";
            this.exportView.Size = new System.Drawing.Size(75, 23);
            this.exportView.TabIndex = 18;
            this.exportView.Text = "Export";
            this.exportView.UseVisualStyleBackColor = true;
            this.exportView.Click += new System.EventHandler(this.exportView_Click);
            // 
            // currentDataLabel
            // 
            this.currentDataLabel.AutoSize = true;
            this.currentDataLabel.Location = new System.Drawing.Point(388, 64);
            this.currentDataLabel.Name = "currentDataLabel";
            this.currentDataLabel.Size = new System.Drawing.Size(0, 13);
            this.currentDataLabel.TabIndex = 17;
            // 
            // dataTabs
            // 
            this.dataTabs.CausesValidation = false;
            this.dataTabs.Controls.Add(this.dataTab);
            this.dataTabs.Controls.Add(this.publicPricingTab);
            this.dataTabs.Controls.Add(this.combinedTab);
            this.dataTabs.Controls.Add(this.rawJsonTab);
            this.dataTabs.Location = new System.Drawing.Point(292, 92);
            this.dataTabs.Name = "dataTabs";
            this.dataTabs.SelectedIndex = 0;
            this.dataTabs.Size = new System.Drawing.Size(839, 490);
            this.dataTabs.TabIndex = 16;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.usageReportDataGrid);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(831, 464);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // usageReportDataGrid
            // 
            this.usageReportDataGrid.AllowUserToAddRows = false;
            this.usageReportDataGrid.AllowUserToDeleteRows = false;
            this.usageReportDataGrid.AllowUserToResizeRows = false;
            this.usageReportDataGrid.CausesValidation = false;
            this.usageReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usageReportDataGrid.Location = new System.Drawing.Point(6, 6);
            this.usageReportDataGrid.MultiSelect = false;
            this.usageReportDataGrid.Name = "usageReportDataGrid";
            this.usageReportDataGrid.ReadOnly = true;
            this.usageReportDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usageReportDataGrid.ShowCellErrors = false;
            this.usageReportDataGrid.ShowEditingIcon = false;
            this.usageReportDataGrid.ShowRowErrors = false;
            this.usageReportDataGrid.Size = new System.Drawing.Size(819, 452);
            this.usageReportDataGrid.TabIndex = 0;
            // 
            // publicPricingTab
            // 
            this.publicPricingTab.Controls.Add(this.getPublicPricingBtn);
            this.publicPricingTab.Controls.Add(this.regionLst);
            this.publicPricingTab.Controls.Add(this.regionLbl);
            this.publicPricingTab.Controls.Add(this.localeLst);
            this.publicPricingTab.Controls.Add(this.localeLbl);
            this.publicPricingTab.Controls.Add(this.currencyLbl);
            this.publicPricingTab.Controls.Add(this.offerDetailsLnk);
            this.publicPricingTab.Controls.Add(this.currencyLst);
            this.publicPricingTab.Controls.Add(this.label1);
            this.publicPricingTab.Controls.Add(this.offerCodeLst);
            this.publicPricingTab.Controls.Add(this.publicPricingDataGrid);
            this.publicPricingTab.Location = new System.Drawing.Point(4, 22);
            this.publicPricingTab.Name = "publicPricingTab";
            this.publicPricingTab.Size = new System.Drawing.Size(831, 464);
            this.publicPricingTab.TabIndex = 3;
            this.publicPricingTab.Text = "Public Pricing";
            this.publicPricingTab.UseVisualStyleBackColor = true;
            // 
            // getPublicPricingBtn
            // 
            this.getPublicPricingBtn.Location = new System.Drawing.Point(669, 44);
            this.getPublicPricingBtn.Name = "getPublicPricingBtn";
            this.getPublicPricingBtn.Size = new System.Drawing.Size(112, 23);
            this.getPublicPricingBtn.TabIndex = 11;
            this.getPublicPricingBtn.Text = "Get Pricing";
            this.getPublicPricingBtn.UseVisualStyleBackColor = true;
            this.getPublicPricingBtn.Click += new System.EventHandler(this.getPublicPricingBtn_Click);
            // 
            // regionLst
            // 
            this.regionLst.FormattingEnabled = true;
            this.regionLst.Items.AddRange(new object[] {
            "US"});
            this.regionLst.Location = new System.Drawing.Point(669, 16);
            this.regionLst.Name = "regionLst";
            this.regionLst.Size = new System.Drawing.Size(105, 21);
            this.regionLst.TabIndex = 10;
            // 
            // regionLbl
            // 
            this.regionLbl.AutoSize = true;
            this.regionLbl.Location = new System.Drawing.Point(619, 20);
            this.regionLbl.Name = "regionLbl";
            this.regionLbl.Size = new System.Drawing.Size(44, 13);
            this.regionLbl.TabIndex = 9;
            this.regionLbl.Text = "Region:";
            // 
            // localeLst
            // 
            this.localeLst.FormattingEnabled = true;
            this.localeLst.Items.AddRange(new object[] {
            "en-US"});
            this.localeLst.Location = new System.Drawing.Point(476, 16);
            this.localeLst.Name = "localeLst";
            this.localeLst.Size = new System.Drawing.Size(105, 21);
            this.localeLst.TabIndex = 8;
            // 
            // localeLbl
            // 
            this.localeLbl.AutoSize = true;
            this.localeLbl.Location = new System.Drawing.Point(428, 20);
            this.localeLbl.Name = "localeLbl";
            this.localeLbl.Size = new System.Drawing.Size(42, 13);
            this.localeLbl.TabIndex = 7;
            this.localeLbl.Text = "Locale:";
            // 
            // currencyLbl
            // 
            this.currencyLbl.AutoSize = true;
            this.currencyLbl.Location = new System.Drawing.Point(227, 20);
            this.currencyLbl.Name = "currencyLbl";
            this.currencyLbl.Size = new System.Drawing.Size(52, 13);
            this.currencyLbl.TabIndex = 6;
            this.currencyLbl.Text = "Currency:";
            // 
            // offerDetailsLnk
            // 
            this.offerDetailsLnk.AutoSize = true;
            this.offerDetailsLnk.Location = new System.Drawing.Point(5, 44);
            this.offerDetailsLnk.Name = "offerDetailsLnk";
            this.offerDetailsLnk.Size = new System.Drawing.Size(199, 13);
            this.offerDetailsLnk.TabIndex = 5;
            this.offerDetailsLnk.TabStop = true;
            this.offerDetailsLnk.Text = "Click to see Microsoft Azure Offer Details";
            // 
            // currencyLst
            // 
            this.currencyLst.FormattingEnabled = true;
            this.currencyLst.Items.AddRange(new object[] {
            "USD"});
            this.currencyLst.Location = new System.Drawing.Point(285, 16);
            this.currencyLst.Name = "currencyLst";
            this.currencyLst.Size = new System.Drawing.Size(105, 21);
            this.currencyLst.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Offer Number:";
            // 
            // offerCodeLst
            // 
            this.offerCodeLst.FormattingEnabled = true;
            this.offerCodeLst.Location = new System.Drawing.Point(84, 16);
            this.offerCodeLst.Name = "offerCodeLst";
            this.offerCodeLst.Size = new System.Drawing.Size(105, 21);
            this.offerCodeLst.TabIndex = 2;
            // 
            // publicPricingDataGrid
            // 
            this.publicPricingDataGrid.AllowUserToAddRows = false;
            this.publicPricingDataGrid.AllowUserToDeleteRows = false;
            this.publicPricingDataGrid.AllowUserToOrderColumns = true;
            this.publicPricingDataGrid.AllowUserToResizeRows = false;
            this.publicPricingDataGrid.CausesValidation = false;
            this.publicPricingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.publicPricingDataGrid.Location = new System.Drawing.Point(5, 69);
            this.publicPricingDataGrid.MultiSelect = false;
            this.publicPricingDataGrid.Name = "publicPricingDataGrid";
            this.publicPricingDataGrid.ReadOnly = true;
            this.publicPricingDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.publicPricingDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.publicPricingDataGrid.ShowCellErrors = false;
            this.publicPricingDataGrid.ShowEditingIcon = false;
            this.publicPricingDataGrid.ShowRowErrors = false;
            this.publicPricingDataGrid.Size = new System.Drawing.Size(821, 393);
            this.publicPricingDataGrid.TabIndex = 1;
            // 
            // combinedTab
            // 
            this.combinedTab.Controls.Add(this.reconciledDataGrid);
            this.combinedTab.Location = new System.Drawing.Point(4, 22);
            this.combinedTab.Name = "combinedTab";
            this.combinedTab.Size = new System.Drawing.Size(831, 464);
            this.combinedTab.TabIndex = 2;
            this.combinedTab.Text = "Combined";
            this.combinedTab.UseVisualStyleBackColor = true;
            // 
            // reconciledDataGrid
            // 
            this.reconciledDataGrid.AllowUserToAddRows = false;
            this.reconciledDataGrid.AllowUserToDeleteRows = false;
            this.reconciledDataGrid.AllowUserToOrderColumns = true;
            this.reconciledDataGrid.AllowUserToResizeRows = false;
            this.reconciledDataGrid.CausesValidation = false;
            this.reconciledDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reconciledDataGrid.Location = new System.Drawing.Point(4, 4);
            this.reconciledDataGrid.MultiSelect = false;
            this.reconciledDataGrid.Name = "reconciledDataGrid";
            this.reconciledDataGrid.ReadOnly = true;
            this.reconciledDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.reconciledDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reconciledDataGrid.ShowCellErrors = false;
            this.reconciledDataGrid.ShowEditingIcon = false;
            this.reconciledDataGrid.ShowRowErrors = false;
            this.reconciledDataGrid.Size = new System.Drawing.Size(821, 460);
            this.reconciledDataGrid.TabIndex = 0;
            this.reconciledDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reconciledDataGrid_CellContentClick);
            // 
            // rawJsonTab
            // 
            this.rawJsonTab.Controls.Add(this.usageListJsonTx);
            this.rawJsonTab.Location = new System.Drawing.Point(4, 22);
            this.rawJsonTab.Name = "rawJsonTab";
            this.rawJsonTab.Padding = new System.Windows.Forms.Padding(3);
            this.rawJsonTab.Size = new System.Drawing.Size(831, 464);
            this.rawJsonTab.TabIndex = 1;
            this.rawJsonTab.Text = "Raw response";
            this.rawJsonTab.UseVisualStyleBackColor = true;
            // 
            // usageListJsonTx
            // 
            this.usageListJsonTx.CausesValidation = false;
            this.usageListJsonTx.Location = new System.Drawing.Point(6, 6);
            this.usageListJsonTx.Multiline = true;
            this.usageListJsonTx.Name = "usageListJsonTx";
            this.usageListJsonTx.ReadOnly = true;
            this.usageListJsonTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usageListJsonTx.Size = new System.Drawing.Size(748, 452);
            this.usageListJsonTx.TabIndex = 7;
            // 
            // availReportTree
            // 
            this.availReportTree.CausesValidation = false;
            this.availReportTree.HideSelection = false;
            this.availReportTree.HotTracking = true;
            this.availReportTree.Location = new System.Drawing.Point(24, 92);
            this.availReportTree.Name = "availReportTree";
            this.availReportTree.ShowNodeToolTips = true;
            this.availReportTree.Size = new System.Drawing.Size(242, 480);
            this.availReportTree.TabIndex = 15;
            this.availReportTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.availReportTree_NodeMouseClick);
            // 
            // availUsageReportLbl
            // 
            this.availUsageReportLbl.AutoSize = true;
            this.availUsageReportLbl.Location = new System.Drawing.Point(21, 64);
            this.availUsageReportLbl.Name = "availUsageReportLbl";
            this.availUsageReportLbl.Size = new System.Drawing.Size(120, 13);
            this.availUsageReportLbl.TabIndex = 13;
            this.availUsageReportLbl.Text = "Available usage reports:";
            // 
            // dataDislayDateLbl
            // 
            this.dataDislayDateLbl.AutoSize = true;
            this.dataDislayDateLbl.Location = new System.Drawing.Point(289, 64);
            this.dataDislayDateLbl.Name = "dataDislayDateLbl";
            this.dataDislayDateLbl.Size = new System.Drawing.Size(97, 13);
            this.dataDislayDateLbl.TabIndex = 7;
            this.dataDislayDateLbl.Text = "Displaying data for:";
            // 
            // getReportDataBtn
            // 
            this.getReportDataBtn.Location = new System.Drawing.Point(178, 583);
            this.getReportDataBtn.Name = "getReportDataBtn";
            this.getReportDataBtn.Size = new System.Drawing.Size(88, 23);
            this.getReportDataBtn.TabIndex = 5;
            this.getReportDataBtn.Text = "Get Reports";
            this.getReportDataBtn.UseVisualStyleBackColor = true;
            this.getReportDataBtn.Click += new System.EventHandler(this.getReportDataBtn_Click);
            // 
            // usageByMonthTab
            // 
            this.usageByMonthTab.Controls.Add(this.formatCB);
            this.usageByMonthTab.Controls.Add(this.lblFormat);
            this.usageByMonthTab.Controls.Add(this.btnSaveReport);
            this.usageByMonthTab.Controls.Add(this.reportTypeCB);
            this.usageByMonthTab.Controls.Add(this.reportTypeLbl);
            this.usageByMonthTab.Controls.Add(this.monthCalendar);
            this.usageByMonthTab.Controls.Add(this.label7);
            this.usageByMonthTab.Controls.Add(this.jsonResponseLbl);
            this.usageByMonthTab.Controls.Add(this.jsonMonthTx);
            this.usageByMonthTab.Controls.Add(this.streamDownloadBtn);
            this.usageByMonthTab.Controls.Add(this.btnSendRequest);
            this.usageByMonthTab.Controls.Add(this.enrollmentMonthTx);
            this.usageByMonthTab.Controls.Add(this.label6);
            this.usageByMonthTab.Location = new System.Drawing.Point(4, 22);
            this.usageByMonthTab.Name = "usageByMonthTab";
            this.usageByMonthTab.Padding = new System.Windows.Forms.Padding(3);
            this.usageByMonthTab.Size = new System.Drawing.Size(1150, 634);
            this.usageByMonthTab.TabIndex = 1;
            this.usageByMonthTab.Text = "Usage By Month";
            this.usageByMonthTab.UseVisualStyleBackColor = true;
            // 
            // formatCB
            // 
            this.formatCB.FormattingEnabled = true;
            this.formatCB.Items.AddRange(new object[] {
            "CSV",
            "JSON"});
            this.formatCB.Location = new System.Drawing.Point(96, 247);
            this.formatCB.Name = "formatCB";
            this.formatCB.Size = new System.Drawing.Size(121, 21);
            this.formatCB.TabIndex = 21;
            this.formatCB.Text = "CSV";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(21, 250);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(42, 13);
            this.lblFormat.TabIndex = 20;
            this.lblFormat.Text = "Format:";
            // 
            // btnSaveReport
            // 
            this.btnSaveReport.Location = new System.Drawing.Point(972, 41);
            this.btnSaveReport.Name = "btnSaveReport";
            this.btnSaveReport.Size = new System.Drawing.Size(81, 23);
            this.btnSaveReport.TabIndex = 19;
            this.btnSaveReport.Text = "Save Report";
            this.btnSaveReport.UseVisualStyleBackColor = true;
            this.btnSaveReport.Visible = false;
            this.btnSaveReport.Click += new System.EventHandler(this.btnSaveReport_Click);
            // 
            // reportTypeCB
            // 
            this.reportTypeCB.FormattingEnabled = true;
            this.reportTypeCB.Items.AddRange(new object[] {
            "Summary",
            "Detail",
            "StoreCharge",
            "PriceSheet"});
            this.reportTypeCB.Location = new System.Drawing.Point(96, 220);
            this.reportTypeCB.Name = "reportTypeCB";
            this.reportTypeCB.Size = new System.Drawing.Size(121, 21);
            this.reportTypeCB.TabIndex = 18;
            this.reportTypeCB.Text = "Summary";
            // 
            // reportTypeLbl
            // 
            this.reportTypeLbl.AutoSize = true;
            this.reportTypeLbl.Location = new System.Drawing.Point(21, 223);
            this.reportTypeLbl.Name = "reportTypeLbl";
            this.reportTypeLbl.Size = new System.Drawing.Size(69, 13);
            this.reportTypeLbl.TabIndex = 17;
            this.reportTypeLbl.Text = "Report Type:";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(70, 41);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Month:";
            // 
            // jsonResponseLbl
            // 
            this.jsonResponseLbl.AutoSize = true;
            this.jsonResponseLbl.Location = new System.Drawing.Point(309, 46);
            this.jsonResponseLbl.Name = "jsonResponseLbl";
            this.jsonResponseLbl.Size = new System.Drawing.Size(80, 13);
            this.jsonResponseLbl.TabIndex = 14;
            this.jsonResponseLbl.Text = "Json Response";
            // 
            // jsonMonthTx
            // 
            this.jsonMonthTx.Location = new System.Drawing.Point(312, 76);
            this.jsonMonthTx.Multiline = true;
            this.jsonMonthTx.Name = "jsonMonthTx";
            this.jsonMonthTx.ReadOnly = true;
            this.jsonMonthTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.jsonMonthTx.Size = new System.Drawing.Size(748, 518);
            this.jsonMonthTx.TabIndex = 13;
            // 
            // streamDownloadBtn
            // 
            this.streamDownloadBtn.Location = new System.Drawing.Point(935, 9);
            this.streamDownloadBtn.Name = "streamDownloadBtn";
            this.streamDownloadBtn.Size = new System.Drawing.Size(118, 23);
            this.streamDownloadBtn.TabIndex = 12;
            this.streamDownloadBtn.Text = "Stream Download";
            this.streamDownloadBtn.UseVisualStyleBackColor = true;
            this.streamDownloadBtn.Click += new System.EventHandler(this.btnStreamDownload_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(812, 9);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(117, 23);
            this.btnSendRequest.TabIndex = 12;
            this.btnSendRequest.Text = "Regular Download";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // enrollmentMonthTx
            // 
            this.enrollmentMonthTx.Location = new System.Drawing.Point(123, 9);
            this.enrollmentMonthTx.Name = "enrollmentMonthTx";
            this.enrollmentMonthTx.Size = new System.Drawing.Size(100, 20);
            this.enrollmentMonthTx.TabIndex = 9;
            this.enrollmentMonthTx.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Enrollment Number:";
            // 
            // configTab
            // 
            this.configTab.Controls.Add(this.saveConifigBtn);
            this.configTab.Controls.Add(this.groupBox1);
            this.configTab.Controls.Add(this.accessKeysGroup);
            this.configTab.Location = new System.Drawing.Point(4, 22);
            this.configTab.Name = "configTab";
            this.configTab.Size = new System.Drawing.Size(1150, 634);
            this.configTab.TabIndex = 2;
            this.configTab.Text = "Configuration";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // saveConifigBtn
            // 
            this.saveConifigBtn.Location = new System.Drawing.Point(719, 432);
            this.saveConifigBtn.Name = "saveConifigBtn";
            this.saveConifigBtn.Size = new System.Drawing.Size(75, 23);
            this.saveConifigBtn.TabIndex = 43;
            this.saveConifigBtn.Text = "Save";
            this.saveConifigBtn.UseVisualStyleBackColor = true;
            this.saveConifigBtn.Click += new System.EventHandler(this.saveConifigBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.azureSharedSecretTxt);
            this.groupBox1.Controls.Add(this.azureSharedSecretLbl);
            this.groupBox1.Controls.Add(this.azureSubscriptionIdTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.azureTenantIdTxt);
            this.groupBox1.Controls.Add(this.aadTenantIdLbl);
            this.groupBox1.Controls.Add(this.azureClientIdTxt);
            this.groupBox1.Controls.Add(this.azureClientIdLbl);
            this.groupBox1.Location = new System.Drawing.Point(22, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 159);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Access Keys (Azure Public)";
            // 
            // azureSharedSecretTxt
            // 
            this.azureSharedSecretTxt.Location = new System.Drawing.Point(137, 117);
            this.azureSharedSecretTxt.Name = "azureSharedSecretTxt";
            this.azureSharedSecretTxt.Size = new System.Drawing.Size(605, 20);
            this.azureSharedSecretTxt.TabIndex = 41;
            // 
            // azureSharedSecretLbl
            // 
            this.azureSharedSecretLbl.AutoSize = true;
            this.azureSharedSecretLbl.Location = new System.Drawing.Point(10, 117);
            this.azureSharedSecretLbl.Name = "azureSharedSecretLbl";
            this.azureSharedSecretLbl.Size = new System.Drawing.Size(78, 13);
            this.azureSharedSecretLbl.TabIndex = 40;
            this.azureSharedSecretLbl.Text = "Shared Secret:";
            // 
            // azureSubscriptionIdTxt
            // 
            this.azureSubscriptionIdTxt.Location = new System.Drawing.Point(137, 33);
            this.azureSubscriptionIdTxt.Name = "azureSubscriptionIdTxt";
            this.azureSubscriptionIdTxt.Size = new System.Drawing.Size(605, 20);
            this.azureSubscriptionIdTxt.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Subscription Id:";
            // 
            // azureTenantIdTxt
            // 
            this.azureTenantIdTxt.Location = new System.Drawing.Point(137, 59);
            this.azureTenantIdTxt.Name = "azureTenantIdTxt";
            this.azureTenantIdTxt.Size = new System.Drawing.Size(605, 20);
            this.azureTenantIdTxt.TabIndex = 38;
            // 
            // aadTenantIdLbl
            // 
            this.aadTenantIdLbl.AutoSize = true;
            this.aadTenantIdLbl.Location = new System.Drawing.Point(10, 59);
            this.aadTenantIdLbl.Name = "aadTenantIdLbl";
            this.aadTenantIdLbl.Size = new System.Drawing.Size(56, 13);
            this.aadTenantIdLbl.TabIndex = 35;
            this.aadTenantIdLbl.Text = "Tenant Id:";
            // 
            // azureClientIdTxt
            // 
            this.azureClientIdTxt.Location = new System.Drawing.Point(137, 88);
            this.azureClientIdTxt.Name = "azureClientIdTxt";
            this.azureClientIdTxt.Size = new System.Drawing.Size(605, 20);
            this.azureClientIdTxt.TabIndex = 39;
            // 
            // azureClientIdLbl
            // 
            this.azureClientIdLbl.AutoSize = true;
            this.azureClientIdLbl.Location = new System.Drawing.Point(10, 88);
            this.azureClientIdLbl.Name = "azureClientIdLbl";
            this.azureClientIdLbl.Size = new System.Drawing.Size(48, 13);
            this.azureClientIdLbl.TabIndex = 36;
            this.azureClientIdLbl.Text = "Client Id:";
            // 
            // accessKeysGroup
            // 
            this.accessKeysGroup.Controls.Add(this.eaSubscriptionIdTxt);
            this.accessKeysGroup.Controls.Add(this.azureSubscriptionIdLbl);
            this.accessKeysGroup.Controls.Add(this.accessKeyPriceBlankLbl);
            this.accessKeysGroup.Controls.Add(this.accessKeyUsageTxt);
            this.accessKeysGroup.Controls.Add(this.eaTestKeyLnk);
            this.accessKeysGroup.Controls.Add(this.accessKeyPriceTxt);
            this.accessKeysGroup.Controls.Add(this.accessKeyPriceLbl);
            this.accessKeysGroup.Controls.Add(this.enrollmentTx);
            this.accessKeysGroup.Controls.Add(this.accessKeyUsageLbl);
            this.accessKeysGroup.Controls.Add(this.enrollmentKeyTxtLbl);
            this.accessKeysGroup.Controls.Add(this.enrollmentNumLbl);
            this.accessKeysGroup.Location = new System.Drawing.Point(22, 18);
            this.accessKeysGroup.Name = "accessKeysGroup";
            this.accessKeysGroup.Size = new System.Drawing.Size(772, 223);
            this.accessKeysGroup.TabIndex = 20;
            this.accessKeysGroup.TabStop = false;
            this.accessKeysGroup.Text = "Access Keys (EA Portal)";
            // 
            // eaSubscriptionIdTxt
            // 
            this.eaSubscriptionIdTxt.Location = new System.Drawing.Point(137, 175);
            this.eaSubscriptionIdTxt.Name = "eaSubscriptionIdTxt";
            this.eaSubscriptionIdTxt.Size = new System.Drawing.Size(605, 20);
            this.eaSubscriptionIdTxt.TabIndex = 30;
            // 
            // azureSubscriptionIdLbl
            // 
            this.azureSubscriptionIdLbl.AutoSize = true;
            this.azureSubscriptionIdLbl.Location = new System.Drawing.Point(10, 175);
            this.azureSubscriptionIdLbl.Name = "azureSubscriptionIdLbl";
            this.azureSubscriptionIdLbl.Size = new System.Drawing.Size(80, 13);
            this.azureSubscriptionIdLbl.TabIndex = 29;
            this.azureSubscriptionIdLbl.Text = "Subscription Id:";
            // 
            // accessKeyPriceBlankLbl
            // 
            this.accessKeyPriceBlankLbl.AutoSize = true;
            this.accessKeyPriceBlankLbl.Location = new System.Drawing.Point(137, 153);
            this.accessKeyPriceBlankLbl.Name = "accessKeyPriceBlankLbl";
            this.accessKeyPriceBlankLbl.Size = new System.Drawing.Size(170, 13);
            this.accessKeyPriceBlankLbl.TabIndex = 28;
            this.accessKeyPriceBlankLbl.Text = "Leave blank to use usage API key";
            // 
            // accessKeyUsageTxt
            // 
            this.accessKeyUsageTxt.Location = new System.Drawing.Point(137, 73);
            this.accessKeyUsageTxt.Name = "accessKeyUsageTxt";
            this.accessKeyUsageTxt.Size = new System.Drawing.Size(605, 20);
            this.accessKeyUsageTxt.TabIndex = 27;
            // 
            // eaTestKeyLnk
            // 
            this.eaTestKeyLnk.AutoSize = true;
            this.eaTestKeyLnk.Location = new System.Drawing.Point(137, 102);
            this.eaTestKeyLnk.Name = "eaTestKeyLnk";
            this.eaTestKeyLnk.Size = new System.Drawing.Size(175, 13);
            this.eaTestKeyLnk.TabIndex = 25;
            this.eaTestKeyLnk.TabStop = true;
            this.eaTestKeyLnk.Text = "Get enrollment 100 test Access Key";
            this.eaTestKeyLnk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.eaTestKeyLnk_LinkClicked);
            // 
            // accessKeyPriceTxt
            // 
            this.accessKeyPriceTxt.Location = new System.Drawing.Point(137, 124);
            this.accessKeyPriceTxt.Name = "accessKeyPriceTxt";
            this.accessKeyPriceTxt.Size = new System.Drawing.Size(605, 20);
            this.accessKeyPriceTxt.TabIndex = 23;
            // 
            // accessKeyPriceLbl
            // 
            this.accessKeyPriceLbl.AutoSize = true;
            this.accessKeyPriceLbl.Location = new System.Drawing.Point(10, 124);
            this.accessKeyPriceLbl.Name = "accessKeyPriceLbl";
            this.accessKeyPriceLbl.Size = new System.Drawing.Size(113, 13);
            this.accessKeyPriceLbl.TabIndex = 22;
            this.accessKeyPriceLbl.Text = "Price API Access Key:";
            // 
            // enrollmentTx
            // 
            this.enrollmentTx.Location = new System.Drawing.Point(137, 24);
            this.enrollmentTx.Name = "enrollmentTx";
            this.enrollmentTx.Size = new System.Drawing.Size(140, 20);
            this.enrollmentTx.TabIndex = 21;
            // 
            // accessKeyUsageLbl
            // 
            this.accessKeyUsageLbl.AutoSize = true;
            this.accessKeyUsageLbl.Location = new System.Drawing.Point(10, 73);
            this.accessKeyUsageLbl.Name = "accessKeyUsageLbl";
            this.accessKeyUsageLbl.Size = new System.Drawing.Size(120, 13);
            this.accessKeyUsageLbl.TabIndex = 26;
            this.accessKeyUsageLbl.Text = "Usage API Access Key:";
            // 
            // enrollmentKeyTxtLbl
            // 
            this.enrollmentKeyTxtLbl.AutoSize = true;
            this.enrollmentKeyTxtLbl.Location = new System.Drawing.Point(137, 51);
            this.enrollmentKeyTxtLbl.Name = "enrollmentKeyTxtLbl";
            this.enrollmentKeyTxtLbl.Size = new System.Drawing.Size(143, 13);
            this.enrollmentKeyTxtLbl.TabIndex = 24;
            this.enrollmentKeyTxtLbl.Text = "Enter \'100\' for test enrollment";
            // 
            // enrollmentNumLbl
            // 
            this.enrollmentNumLbl.AutoSize = true;
            this.enrollmentNumLbl.Location = new System.Drawing.Point(10, 24);
            this.enrollmentNumLbl.Name = "enrollmentNumLbl";
            this.enrollmentNumLbl.Size = new System.Drawing.Size(99, 13);
            this.enrollmentNumLbl.TabIndex = 20;
            this.enrollmentNumLbl.Text = "Enrollment Number:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBottomLabel1,
            this.statusBottomStatus1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1183, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBottomLabel1
            // 
            this.statusBottomLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusBottomLabel1.Name = "statusBottomLabel1";
            this.statusBottomLabel1.Size = new System.Drawing.Size(82, 17);
            this.statusBottomLabel1.Text = "Current Status";
            // 
            // statusBottomStatus1
            // 
            this.statusBottomStatus1.Name = "statusBottomStatus1";
            this.statusBottomStatus1.Size = new System.Drawing.Size(100, 16);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 707);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainTabs);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EA Usage and pricing viewer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainTabs.ResumeLayout(false);
            this.usageListTab.ResumeLayout(false);
            this.usageListTab.PerformLayout();
            this.dataTabs.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).EndInit();
            this.publicPricingTab.ResumeLayout(false);
            this.publicPricingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publicPricingDataGrid)).EndInit();
            this.combinedTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reconciledDataGrid)).EndInit();
            this.rawJsonTab.ResumeLayout(false);
            this.rawJsonTab.PerformLayout();
            this.usageByMonthTab.ResumeLayout(false);
            this.usageByMonthTab.PerformLayout();
            this.configTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.accessKeysGroup.ResumeLayout(false);
            this.accessKeysGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combinedDataBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage usageListTab;
        private System.Windows.Forms.Label dataDislayDateLbl;
        private System.Windows.Forms.Button getReportDataBtn;
        private System.Windows.Forms.TabPage usageByMonthTab;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label jsonResponseLbl;
        private System.Windows.Forms.TextBox jsonMonthTx;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox enrollmentMonthTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox reportTypeCB;
        private System.Windows.Forms.Label reportTypeLbl;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.ComboBox formatCB;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Button streamDownloadBtn;
        private System.Windows.Forms.Label availUsageReportLbl;
        private System.Windows.Forms.TreeView availReportTree;
        private System.Windows.Forms.TabControl dataTabs;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.DataGridView usageReportDataGrid;
        private System.Windows.Forms.TabPage rawJsonTab;
        private System.Windows.Forms.TextBox usageListJsonTx;
        private System.Windows.Forms.TabPage combinedTab;
        private System.Windows.Forms.Label currentDataLabel;
        private System.Windows.Forms.DataGridView reconciledDataGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBottomLabel1;
        private System.Windows.Forms.ToolStripProgressBar statusBottomStatus1;
        private System.Windows.Forms.BindingSource dataTabBindingSource;
        private System.Windows.Forms.BindingSource combinedDataBindingSource;
        private System.Windows.Forms.Button exportView;
        private System.Windows.Forms.TabPage publicPricingTab;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.GroupBox accessKeysGroup;
        private System.Windows.Forms.TextBox accessKeyUsageTxt;
        private System.Windows.Forms.LinkLabel eaTestKeyLnk;
        private System.Windows.Forms.TextBox accessKeyPriceTxt;
        private System.Windows.Forms.Label accessKeyPriceLbl;
        private System.Windows.Forms.TextBox enrollmentTx;
        private System.Windows.Forms.Label accessKeyUsageLbl;
        private System.Windows.Forms.Label enrollmentKeyTxtLbl;
        private System.Windows.Forms.Label enrollmentNumLbl;
        private System.Windows.Forms.ComboBox exportTypeList;
        private System.Windows.Forms.Label exportFormatLbl;
        private System.Windows.Forms.Label accessKeyPriceBlankLbl;
        private System.Windows.Forms.DataGridView publicPricingDataGrid;
        private System.Windows.Forms.LinkLabel offerDetailsLnk;
        private System.Windows.Forms.ComboBox currencyLst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox offerCodeLst;
        private System.Windows.Forms.Label currencyLbl;
        private System.Windows.Forms.Button getPublicPricingBtn;
        private System.Windows.Forms.ComboBox regionLst;
        private System.Windows.Forms.Label regionLbl;
        private System.Windows.Forms.ComboBox localeLst;
        private System.Windows.Forms.Label localeLbl;
        private System.Windows.Forms.TextBox eaSubscriptionIdTxt;
        private System.Windows.Forms.Label azureSubscriptionIdLbl;
        private System.Windows.Forms.Button saveConifigBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox azureSharedSecretTxt;
        private System.Windows.Forms.Label azureSharedSecretLbl;
        private System.Windows.Forms.TextBox azureSubscriptionIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox azureTenantIdTxt;
        private System.Windows.Forms.Label aadTenantIdLbl;
        private System.Windows.Forms.TextBox azureClientIdTxt;
        private System.Windows.Forms.Label azureClientIdLbl;
    }
}

