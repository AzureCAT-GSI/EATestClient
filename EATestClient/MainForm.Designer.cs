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
            this.dataTabs = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.usageReportDataGrid = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.usageListJsonTx = new System.Windows.Forms.TextBox();
            this.availReportTree = new System.Windows.Forms.TreeView();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validateKey = new System.Windows.Forms.Button();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.dataTabs.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataTabs);
            this.tabPage1.Controls.Add(this.availReportTree);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.validateKey);
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
            // dataTabs
            // 
            this.dataTabs.Controls.Add(this.tabPage3);
            this.dataTabs.Controls.Add(this.tabPage4);
            this.dataTabs.Controls.Add(this.tabPage5);
            this.dataTabs.Location = new System.Drawing.Point(307, 92);
            this.dataTabs.Name = "dataTabs";
            this.dataTabs.SelectedIndex = 0;
            this.dataTabs.Size = new System.Drawing.Size(753, 458);
            this.dataTabs.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.usageReportDataGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(745, 432);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Data";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // usageReportDataGrid
            // 
            this.usageReportDataGrid.AllowUserToAddRows = false;
            this.usageReportDataGrid.AllowUserToDeleteRows = false;
            this.usageReportDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usageReportDataGrid.Location = new System.Drawing.Point(6, 6);
            this.usageReportDataGrid.Name = "usageReportDataGrid";
            this.usageReportDataGrid.ReadOnly = true;
            this.usageReportDataGrid.Size = new System.Drawing.Size(733, 420);
            this.usageReportDataGrid.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.usageListJsonTx);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(745, 432);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Raw response";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // usageListJsonTx
            // 
            this.usageListJsonTx.Location = new System.Drawing.Point(6, 6);
            this.usageListJsonTx.Multiline = true;
            this.usageListJsonTx.Name = "usageListJsonTx";
            this.usageListJsonTx.ReadOnly = true;
            this.usageListJsonTx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.usageListJsonTx.Size = new System.Drawing.Size(733, 420);
            this.usageListJsonTx.TabIndex = 7;
            // 
            // availReportTree
            // 
            this.availReportTree.Location = new System.Drawing.Point(21, 108);
            this.availReportTree.Name = "availReportTree";
            this.availReportTree.Size = new System.Drawing.Size(242, 442);
            this.availReportTree.TabIndex = 15;
            this.availReportTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.availReportTree_NodeMouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Available usage reports:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(338, 32);
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
            this.label9.Location = new System.Drawing.Point(120, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter \'100\' for test enrollment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Json Response";
            // 
            // validateKey
            // 
            this.validateKey.Location = new System.Drawing.Point(972, 7);
            this.validateKey.Name = "validateKey";
            this.validateKey.Size = new System.Drawing.Size(88, 23);
            this.validateKey.TabIndex = 5;
            this.validateKey.Text = "Send Request";
            this.validateKey.UseVisualStyleBackColor = true;
            this.validateKey.Click += new System.EventHandler(this.validateKey_Click);
            // 
            // accessKeyTx
            // 
            this.accessKeyTx.Location = new System.Drawing.Point(341, 9);
            this.accessKeyTx.Name = "accessKeyTx";
            this.accessKeyTx.Size = new System.Drawing.Size(609, 20);
            this.accessKeyTx.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access Key:";
            // 
            // enrollmentTx
            // 
            this.enrollmentTx.Location = new System.Drawing.Point(123, 9);
            this.enrollmentTx.Name = "enrollmentTx";
            this.enrollmentTx.Size = new System.Drawing.Size(100, 20);
            this.enrollmentTx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 12);
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
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(745, 432);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Reconciled";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usageReportDataGrid)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button validateKey;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView usageReportDataGrid;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox usageListJsonTx;
        private System.Windows.Forms.TabPage tabPage5;
    }
}

