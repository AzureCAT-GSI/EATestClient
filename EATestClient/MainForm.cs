using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using EATestClient.Models;
using EATestClient.Common;
using EATestClient.Properties;

namespace EATestClient
{
    public partial class MainForm : Form
    {
        string downloadUsageByMonthUrlTemplate = string.Format(@"{0}?month={{1}}&type={{2}}&fmt={{3}}", ConfigurationManager.AppSettings["UsageReportAPIUrl"]);
        string getUsageListUrlTemplate = ConfigurationManager.AppSettings["UsageReportListAPIUrl"];
        static HttpClient client = new HttpClient();
        EAAvailableUsageReports availableMonths = new EAAvailableUsageReports();
        string currentEnrollment = string.Empty;
        BearerToken currentToken = null;
        byte[] reportBytes;

        public MainForm()
        {
            InitializeComponent();
            initSettings();
            initValidators();
        }

        private void initValidators()
        {
            accessKeyTx.Validating += AccessKeyTx_Validating;
            enrollmentMonthTx.Validating += EnrollmentMonthTx_Validating;
        }

        private void EnrollmentMonthTx_Validating(object sender, CancelEventArgs e)
        {
            enrollmentMonthTx.ForeColor = Color.White;
            if (string.IsNullOrEmpty(enrollmentMonthTx.Text))
            {
                enrollmentMonthTx.ForeColor = Color.Yellow;
                enrollmentMonthTx.Focus();
                e.Cancel = true;
            }
        }

        private void AccessKeyTx_Validating(object sender, CancelEventArgs e)
        {
            accessKeyTx.ForeColor = Color.White;
            if (string.IsNullOrEmpty(accessKeyTx.Text))
            {
                accessKeyTx.ForeColor = Color.Yellow;
                accessKeyTx.Focus();
                e.Cancel = true;
            }
        }

        private void initSettings()
        {
            Settings curSettings = Settings.Default;
            string jwt = curSettings["AccessKey"]?.ToString();
            if (!string.IsNullOrEmpty(jwt))
            {
                currentToken = BearerToken.FromJwt(jwt);
                accessKeyTx.Text = currentToken.Token;
            }

            currentEnrollment = curSettings["EnrollmentNumber"]?.ToString();
            if (!string.IsNullOrEmpty(currentEnrollment))
            {
                enrollmentTx.Text = currentEnrollment;
            }
        }

        private async void validateKey_Click(object sender, EventArgs e)
        {
            ValidateInputForUsageList();

            using (var wcur = new WaitCursor())
            {
                string availReportsJson = await GetEnrollmentUsageList(enrollmentTx.Text, accessKeyTx.Text);
                usageListJsonTx.Text = availReportsJson;

                try
                {
                    EAAvailableUsageReports availReports = JsonConvert.DeserializeObject<EAAvailableUsageReports>(availReportsJson);

                    //Parse the response and fill the usage list
                    fillUsageList(availReports);
                }
                catch
                {
                    //Could not parse the JSON
                }
            }
        }

        private void fillUsageList(EAAvailableUsageReports reports)
        {
            availReportTree.Nodes.Clear();
            TreeNode rootNode = availReportTree.Nodes.Add($"Available reports ({reports.AvailableMonths.Count})");
            TreeNode yearNode = null;
            int prevYear = 0;
            foreach (EAUsageAvailableMonth month in reports.AvailableMonths)
            {
                //Parse the month and year. Add the years
                DateTime curMonthReports = DateTime.Parse(month.Month);
                int curYear = curMonthReports.Year;

                if (curYear != prevYear)
                {
                    //If the year changes, add a new node
                    yearNode = rootNode.Nodes.Add(curYear.ToString());
                }
                //Add a new month node for this item
                TreeNode monthNode = yearNode.Nodes.Add(month.Month, curMonthReports.ToString("MMMM"));

                if (!string.IsNullOrEmpty(month.LinkToDownloadDetailReport))
                {
                    TreeNode detRpt = monthNode.Nodes.Add(month.LinkToDownloadDetailReport, UsageReportType.Detail.ToString()); 
                    detRpt.ToolTipText = month.LinkToDownloadDetailReport;
                }
                if (!string.IsNullOrEmpty(month.LinkToDownloadPriceSheetReport))
                {
                    TreeNode dRpt = monthNode.Nodes.Add(month.LinkToDownloadPriceSheetReport, UsageReportType.PriceSheet.ToString()); 
                    dRpt.ToolTipText = month.LinkToDownloadPriceSheetReport;
                }
                if (!string.IsNullOrEmpty(month.LinkToDownloadStoreChargeReport))
                {
                    TreeNode scRpt = monthNode.Nodes.Add(month.LinkToDownloadStoreChargeReport, UsageReportType.StoreCharge.ToString());
                    scRpt.ToolTipText = month.LinkToDownloadStoreChargeReport;
                }
                if (!string.IsNullOrEmpty(month.LinkToDownloadSummaryReport))
                {
                    TreeNode sumRpt = monthNode.Nodes.Add(month.LinkToDownloadSummaryReport, UsageReportType.Summary.ToString());
                    sumRpt.ToolTipText = month.LinkToDownloadSummaryReport;
                }
                prevYear = curYear;
            }
        }


       private void btnSendRequest_Click(object sender, EventArgs e)
        {
            using (var wcur = new WaitCursor())
            {
                ValidateInputForUsageMonth();
                UsageReportType type = (UsageReportType)reportTypeCB.SelectedIndex;
                string json = GetEnrollmentUsageByMonth(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyMonthTx.Text, formatCB.Text).Result;
                reportBytes = Encoding.Default.GetBytes(json);
                jsonMonthTx.Text = json;
            }
        }

        private void btnStreamDownload_Click(object sender, EventArgs e)
       {
            using (var wcur = new WaitCursor())
            {
                ValidateInputForUsageMonth();
                UsageReportType type = (UsageReportType)reportTypeCB.SelectedIndex;
                string json = GetEnrollmentUsageByMonthStream(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyMonthTx.Text, formatCB.Text).Result;
                reportBytes = Encoding.Default.GetBytes(json);
                jsonMonthTx.Text = json;
            }
       }

       private void btnSaveReport_Click(object sender, EventArgs e)
        {
            
            string json = jsonMonthTx.Text;
            
            //UsageReportApiResponse response = JsonConvert.DeserializeObject<UsageReportApiResponse>(json);
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = string.Format("Report files (*.{0})|*.{0}", "csv");

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(dialog.FileName, reportBytes);
            }
        }

       
        private void ValidateInputForUsageList()
        {
            Validate();
        }

        private void ValidateInputForUsageMonth()
        {

        }

        public async Task<string> GetEnrollmentUsageByMonth(DateTime month, UsageReportType type, string enrollmentNumber, string jwt, string format)
        {
            string url = string.Format(downloadUsageByMonthUrlTemplate, enrollmentNumber, month.ToString("yyyy-MM"), type, format);
            HttpResponseMessage response = await GetResponseStream(url, jwt);
            string responseMsg = string.Empty;
            responseMsg = await response.Content.ReadAsStringAsync();
            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                MessageBox.Show("An error occured getting data GetEnrollmentUsageByMonth::" + responseMsg);
            }
            return responseMsg;
        }

        public async Task<string> GetEnrollmentUsageList(string enrollmentNumber, string jwt)
        {
            string url = string.Format(getUsageListUrlTemplate, enrollmentNumber);
            string respData = string.Empty;

            HttpResponseMessage response = await GetResponseStream(url, jwt);
            
            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                MessageBox.Show("An error occured getting data GetEnrollmentUsageList::" + response.StatusCode);
            }
            else
            {
                string responseMsg = await response.Content.ReadAsStringAsync();
                respData = responseMsg;
            }

            return respData;
        }

        [Obsolete]
        private string GetResponse(string url, string jwt)
        {
            WebRequest request = WebRequest.Create(url);
            if (!string.IsNullOrEmpty(jwt))
            {
                //AddHeaders(request, jwt);
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse)ex.Response;
            }
            
            StreamReader reader = new StreamReader(response.GetResponseStream());

            var contentType = response.Headers["Content-Type"];

            string s = (int)response.StatusCode + "\t" + response.StatusDescription + "\r\n" 
                + response.Headers + "\r\n" 
                + reader.ReadToEnd();
            return s;
        }

        public async Task<string> GetEnrollmentUsageByMonthStream(DateTime month, UsageReportType type, string enrollmentNumber, string jwt, string format)
        {
            string url = string.Format(downloadUsageByMonthUrlTemplate, enrollmentNumber, month, type, format);
            HttpResponseMessage response = await GetResponseStream(url, jwt);
            string responseMsg = string.Empty;
            responseMsg = await response.Content.ReadAsStringAsync();
            if (!response.StatusCode.Equals(HttpStatusCode.OK))
            {
                MessageBox.Show("An error occured getting data GetEnrollmentUsageByMonthStream::" + responseMsg);
            }
            return responseMsg;
        }

        private async Task<HttpResponseMessage> GetResponseStream(string url, string jwt)
        {

            string ret = string.Empty;
            HttpResponseMessage msg = new HttpResponseMessage();
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                //keep request openning for 5 minutes. the socket will close either file is downloaded or socket opening for longer than 5 minutes
                client.Timeout = new TimeSpan(0,5,0);
                if (!string.IsNullOrEmpty(jwt))
                {
                    AddHeaders(client, jwt);
                }
                try
                {
                    HttpResponseMessage response = null;
                    try
                    {
                        //response = (HttpWebResponse)request.GetResponse();
                        msg = await client.GetAsync(url);
                    }
                    catch (HttpRequestException ex)
                    {
                        response.StatusCode = HttpStatusCode.BadRequest;
                        msg.Content = new StringContent(ex.ToString());
                        response = msg;
                    }

                    //var localfile = "c:/temp/output.txt";

                    //FileStream writeStream = new FileStream("c:/temp/output.txt", FileMode.Create, FileAccess.Write);
                    //// write to the stream
                    //ReadWriteStream(response.GetResponseStream(), writeStream);

                    //using (StreamReader sr = new StreamReader(localfile))
                    //{
                    //    StringBuilder sb = new StringBuilder();
                    //    char[] c = null;
                    //    int i = 0;

                    //    while (sr.Peek() >= 0 && i < 10)
                    //    {
                    //        c = new char[1024];
                    //        sr.Read(c, 0, c.Length);
                    //        sb.Append(c);
                    //        i++;
                    //    }
                    //    string s = (int)response.StatusCode + "\t" + response.StatusDescription + "\r\n"
                    //               + response.Headers + "\r\n";
                    //    ret = string.Concat(s, sb.ToString());
                    //}
                }
                catch (Exception ex)
                {
                    msg.StatusCode = HttpStatusCode.BadRequest;
                    msg.Content = new StringContent(ex.ToString());
                }
            }
            return msg;
        }

        private void ReadWriteStream(Stream readStream, Stream writeStream)
        {
            int Length = 4096;
            Byte[] buffer = new Byte[Length];
            int bytesRead = readStream.Read(buffer, 0, Length);
            // write the required bytes
            while (bytesRead > 0)
            {
                writeStream.Write(buffer, 0, bytesRead);
                bytesRead = readStream.Read(buffer, 0, Length);
                writeStream.Flush();
            }
            readStream.Close();
            writeStream.Close();
        }

        private void AddHeaders(HttpClient requestClient, string jwt)
        {
            AddHeaders(requestClient, jwt, false);
        }

        private void AddHeaders(HttpClient requestClient, string jwt, bool IsCsv)
        {
            string bearerTokenHeader = BearerToken.FromJwt(jwt).BearerTokenHeader;
            requestClient.DefaultRequestHeaders.Clear();
            if (IsCsv)
            {
                requestClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/plaintext"));
            }
            else
            {
                requestClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
            requestClient.DefaultRequestHeaders.Add("authorization", bearerTokenHeader);
            requestClient.DefaultRequestHeaders.Add("api-version", "1.0");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GetTestKey();
        }

        private void GetTestKey()
        {
            Process.Start(ConfigurationManager.AppSettings["TestKey"]);
        }

        private void availReportTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode clickedNode = e.Node;
            if (e.Node.Level == 0)
            {
                //At the root, collapse all and expand years
                //if (!e.Node.IsExpanded)
                //{
                //}
            }
            //Years
            if (e.Node.Level == 1)
            {
                //At the years
                //if (!e.Node.IsExpanded)
                //{
                //    //e.Node.Parent.Collapse(false);
                //    e.Node.Expand();
                //}
            }

            //At the months
            if (e.Node.Level == 2)
            {
                //if (!e.Node.IsExpanded)
                //{
                //  //e.Node.Parent.Collapse(false);
                //  e.Node.Expand();
                //}
            }
            //At the reports
            if (e.Node.Level == 3)
            {
                //if (!e.Node.IsExpanded)
                //{
                //    //e.Node.Parent.Collapse(false);
                //    e.Node.Expand();
                //}
                //Do work    
                displayReportData(e.Node.Parent.Name, e.Node.Text, e.Node.Name);
            }

            e.Node.EnsureVisible();
        }

        private async void displayReportData(string currentMonthReport, string reportType, string UrlToReport)
        {
            using (new WaitCursor())
            {
                string urlToFetch = UrlToReport;
                DateTime currentMonth = DateTime.Parse(currentMonthReport);
                UsageReportType curType = (UsageReportType)Enum.Parse(typeof(UsageReportType), reportType);

                string usageDataJson = await GetEnrollmentUsageByMonth(currentMonth, curType, currentEnrollment, currentToken.Token, "json");
                usageReportDataGrid.DataSource = null;
                usageReportDataGrid.AutoGenerateColumns = true;
                usageListJsonTx.Text = usageDataJson;
                BindingSource dataToBind = new BindingSource();

                switch (curType)
                {
                    case UsageReportType.Detail:
                        {
                            try
                            {
                                dataToBind.DataSource = JsonConvert.DeserializeObject<List<EAUsageDetailItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case UsageReportType.PriceSheet:
                        {
                            try
                            {
                                dataToBind.DataSource = JsonConvert.DeserializeObject<List<EAPriceSheetItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case UsageReportType.StoreCharge:
                        {
                            dataToBind.DataSource = JsonConvert.DeserializeObject<List<EAStoreChargeItem>>(usageDataJson);
                            break;
                        }
                    case UsageReportType.Summary:
                        {
                            try
                            {
                                dataToBind.DataSource = JsonConvert.DeserializeObject<List<EAUsageSummaryItem>>(usageDataJson);
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                }
                if (dataToBind != null)
                {
                    usageReportDataGrid.DataSource = dataToBind;
                    usageReportDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
        }
    }
}
