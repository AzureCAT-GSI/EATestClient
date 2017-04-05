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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.currentDataLabel = new System.Windows.Forms.Label();
            this.dataTabs = new System.Windows.Forms.TabControl();
            this.dataTab = new System.Windows.Forms.TabPage();
            this.usageReportDataGrid = new System.Windows.Forms.DataGridView();
            this.rawJsonTab = new System.Windows.Forms.TabPage();
            this.usageListJsonTx = new System.Windows.Forms.TextBox();
            this.combinedTab = new System.Windows.Forms.TabPage();
            this.availReportTree = new System.Windows.Forms.TreeView();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getReportDataBtn = new System.Windows.Forms.Button();
            this.accessKeyTx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enrollmentTx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.formatCB = new System.Windows.Forms.ComboBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.btnSaveReport = new System.Windows.Forms.Button();
            this.reportTypeCB = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.jsonMonthTx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.accessKeyMonthTx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.enrollmentMonthTx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.reconciledDataGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.dataTabs.SuspendLayout();
            this.dataTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).BeginInit();
            this.rawJsonTab.SuspendLayout();
            this.combinedTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconciledDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.currentDataLabel);
            this.tabPage1.Controls.Add(this.dataTabs);
            this.tabPage1.Controls.Add(this.availReportTree);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.getReportDataBtn);
            this.tabPage1.Controls.Add(this.accessKeyTx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.enrollmentTx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1078, 600);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "UsageList";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.dataTabs.Controls.Add(this.dataTab);
            this.dataTabs.Controls.Add(this.rawJsonTab);
            this.dataTabs.Controls.Add(this.combinedTab);
            this.dataTabs.Location = new System.Drawing.Point(289, 92);
            this.dataTabs.Name = "dataTabs";
            this.dataTabs.SelectedIndex = 0;
            this.dataTabs.Size = new System.Drawing.Size(768, 490);
            this.dataTabs.TabIndex = 16;
            // 
            // dataTab
            // 
            this.dataTab.Controls.Add(this.usageReportDataGrid);
            this.dataTab.Location = new System.Drawing.Point(4, 22);
            this.dataTab.Name = "dataTab";
            this.dataTab.Padding = new System.Windows.Forms.Padding(3);
            this.dataTab.Size = new System.Drawing.Size(760, 464);
            this.dataTab.TabIndex = 0;
            this.dataTab.Text = "Data";
            this.dataTab.UseVisualStyleBackColor = true;
            // 
            // usageReportDataGrid
            // 
            this.usageReportDataGrid.AllowUserToAddRows = false;
            this.usageReportDataGrid.AllowUserToDeleteRows = false;
            this.usageReportDataGrid.AllowUserToResizeRows = false;
            this.usageReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usageReportDataGrid.Location = new System.Drawing.Point(6, 6);
            this.usageReportDataGrid.MultiSelect = false;
            this.usageReportDataGrid.Name = "usageReportDataGrid";
            this.usageReportDataGrid.ReadOnly = true;
            this.usageReportDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usageReportDataGrid.ShowEditingIcon = false;
            this.usageReportDataGrid.Size = new System.Drawing.Size(748, 452);
            this.usageReportDataGrid.TabIndex = 0;
            // 
            // rawJsonTab
            // 
            this.rawJsonTab.Controls.Add(this.usageListJsonTx);
            this.rawJsonTab.Location = new System.Drawing.Point(4, 22);
            this.rawJsonTab.Name = "rawJsonTab";
            this.rawJsonTab.Padding = new System.Windows.Forms.Padding(3);
            this.rawJsonTab.Size = new System.Drawing.Size(760, 464);
            this.rawJsonTab.TabIndex = 1;
            this.rawJsonTab.Text = "Raw response";
            this.rawJsonTab.UseVisualStyleBackColor = true;
            // 
            // usageListJsonTx
            // 
            this.usageListJsonTx.Location = new System.Drawing.Point(6, 6);
            this.usageListJsonTx.Multiline = true;
            this.usageListJsonTx.Name = "usageListJsonTx";
            this.usageListJsonTx.ReadOnly = true;
            this.usageListJsonTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usageListJsonTx.Size = new System.Drawing.Size(748, 452);
            this.usageListJsonTx.TabIndex = 7;
            // 
            // combinedTab
            // 
            this.combinedTab.Controls.Add(this.reconciledDataGrid);
            this.combinedTab.Location = new System.Drawing.Point(4, 22);
            this.combinedTab.Name = "combinedTab";
            this.combinedTab.Size = new System.Drawing.Size(760, 464);
            this.combinedTab.TabIndex = 2;
            this.combinedTab.Text = "Combined";
            this.combinedTab.UseVisualStyleBackColor = true;
            // 
            // availReportTree
            // 
            this.availReportTree.Location = new System.Drawing.Point(24, 92);
            this.availReportTree.Name = "availReportTree";
            this.availReportTree.Size = new System.Drawing.Size(242, 490);
            this.availReportTree.TabIndex = 15;
            this.availReportTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.availReportTree_NodeMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Available usage reports:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(289, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(175, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Get enrollment 100 test Access Key";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(123, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter \'100\' for test enrollment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Displaying data for:";
            // 
            // getReportDataBtn
            // 
            this.getReportDataBtn.Location = new System.Drawing.Point(972, 7);
            this.getReportDataBtn.Name = "getReportDataBtn";
            this.getReportDataBtn.Size = new System.Drawing.Size(88, 23);
            this.getReportDataBtn.TabIndex = 5;
            this.getReportDataBtn.Text = "Get Reports";
            this.getReportDataBtn.UseVisualStyleBackColor = true;
            this.getReportDataBtn.Click += new System.EventHandler(this.getReportDataBtn_Click);
            // 
            // accessKeyTx
            // 
            this.accessKeyTx.Location = new System.Drawing.Point(361, 9);
            this.accessKeyTx.Name = "accessKeyTx";
            this.accessKeyTx.Size = new System.Drawing.Size(605, 20);
            this.accessKeyTx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access Key:";
            // 
            // enrollmentTx
            // 
            this.enrollmentTx.Location = new System.Drawing.Point(126, 9);
            this.enrollmentTx.Name = "enrollmentTx";
            this.enrollmentTx.Size = new System.Drawing.Size(140, 20);
            this.enrollmentTx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enrollment Number:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.formatCB);
            this.tabPage2.Controls.Add(this.lblFormat);
            this.tabPage2.Controls.Add(this.btnSaveReport);
            this.tabPage2.Controls.Add(this.reportTypeCB);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.monthCalendar);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.jsonMonthTx);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnSendRequest);
            this.tabPage2.Controls.Add(this.accessKeyMonthTx);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.enrollmentMonthTx);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1078, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UsageByMonth";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Report Type:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Json Response";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Stream Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnStreamDownload_Click);
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
            // accessKeyMonthTx
            // 
            this.accessKeyMonthTx.Location = new System.Drawing.Point(375, 9);
            this.accessKeyMonthTx.Name = "accessKeyMonthTx";
            this.accessKeyMonthTx.Size = new System.Drawing.Size(431, 20);
            this.accessKeyMonthTx.TabIndex = 11;
            this.accessKeyMonthTx.Text = this.accessKeyTx.Text;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Access Key:";
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
            // reconciledDataGrid
            // 
            this.reconciledDataGrid.AllowUserToAddRows = false;
            this.reconciledDataGrid.AllowUserToDeleteRows = false;
            this.reconciledDataGrid.AllowUserToOrderColumns = true;
            this.reconciledDataGrid.AllowUserToResizeRows = false;
            this.reconciledDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reconciledDataGrid.Location = new System.Drawing.Point(4, 4);
            this.reconciledDataGrid.Name = "reconciledDataGrid";
            this.reconciledDataGrid.ReadOnly = true;
            this.reconciledDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reconciledDataGrid.ShowEditingIcon = false;
            this.reconciledDataGrid.ShowRowErrors = false;
            this.reconciledDataGrid.Size = new System.Drawing.Size(753, 460);
            this.reconciledDataGrid.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 651);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "EA Usage and pricing viewer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.dataTabs.ResumeLayout(false);
            this.dataTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).EndInit();
            this.rawJsonTab.ResumeLayout(false);
            this.rawJsonTab.PerformLayout();
            this.combinedTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconciledDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getReportDataBtn;
        private System.Windows.Forms.TextBox accessKeyTx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox enrollmentTx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jsonMonthTx;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.TextBox accessKeyMonthTx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox enrollmentMonthTx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox reportTypeCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSaveReport;
        private System.Windows.Forms.ComboBox formatCB;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TreeView availReportTree;
        private System.Windows.Forms.TabControl dataTabs;
        private System.Windows.Forms.TabPage dataTab;
        private System.Windows.Forms.DataGridView usageReportDataGrid;
        private System.Windows.Forms.TabPage rawJsonTab;
        private System.Windows.Forms.TextBox usageListJsonTx;
        private System.Windows.Forms.TabPage combinedTab;
        private System.Windows.Forms.Label currentDataLabel;
        private System.Windows.Forms.DataGridView reconciledDataGrid;
    }
}

