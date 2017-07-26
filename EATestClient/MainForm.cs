using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
using EATestClient.ViewModels;
using System.Net.Http.Headers;

namespace EATestClient
{
    public partial class MainForm : Form
    {
        string downloadUsageByMonthUrlTemplate = string.Format(@"{0}?month={{1}}&type={{2}}&fmt={{3}}", ConfigurationManager.AppSettings["UsageReportAPIUrl"]);
        string getUsageListUrlTemplate = ConfigurationManager.AppSettings["UsageReportListAPIUrl"];
        string getAzureOfferDetailsUrl = ConfigurationManager.AppSettings["AzureOfferDetailsUrl"];
        static HttpClient client = new HttpClient();
        EAAvailableUsageReports availableMonths = new EAAvailableUsageReports();
        BearerToken currentToken = null;
        byte[] reportBytes;
        RuntimeConfig currentConfig = new RuntimeConfig();

        public MainForm()
        {
            InitializeComponent();
        }

        

        private void initValidators()
        {
            accessKeyPriceTxt.Validating += AccessKeyTx_Validating;
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
            accessKeyPriceTxt.ForeColor = Color.White;
            if (string.IsNullOrEmpty(accessKeyPriceTxt.Text))
            {
                accessKeyPriceTxt.ForeColor = Color.Yellow;
                accessKeyPriceTxt.Focus();
                e.Cancel = true;
            }
        }

        private void initSettings()
        {
            updateStatus("Initializing settings ...", true);
            Settings curAppSettings = Settings.Default;
            
            eaTestKeyLnk.Links.Add(new LinkLabel.Link() { LinkData = curAppSettings.TestEnrollmentKeyUrl });
            
            string ujwt = curAppSettings["AccessKeyUsage"]?.ToString();
            if (!string.IsNullOrEmpty(ujwt))
            {
                currentToken = BearerToken.FromJwt(ujwt);
                accessKeyUsageTxt.Text = currentToken.Token;
                currentConfig.UsageAccessKey = currentToken.Token;
            }

            string pjwt = curAppSettings["AccessKeyPricing"]?.ToString();
            if (!string.IsNullOrEmpty(pjwt))
            {
                currentToken = BearerToken.FromJwt(pjwt);
                accessKeyPriceTxt.Text = currentToken.Token;
                currentConfig.PricingAccessKey = currentToken.Token;
            }
            else
            {
                currentConfig.PricingAccessKey = currentConfig.UsageAccessKey;
            }

            currentConfig.EnrollmentNumber = curAppSettings["EnrollmentNumber"]?.ToString();
            if (!string.IsNullOrEmpty(currentConfig.EnrollmentNumber))
            {
                enrollmentTx.Text = currentConfig.EnrollmentNumber;
            }

            currentConfig.SubscriptionId = curAppSettings["SubscriptionId"]?.ToString();
            azureSubscriptionIdTxt.Text = currentConfig.SubscriptionId;

            currentConfig.TenantId = curAppSettings["AADtenantId"]?.ToString();
            aadTenantIdTxt.Text = currentConfig.TenantId;

            currentConfig.ClientId = curAppSettings["AADClientId"]?.ToString();
            azureClientIdTxt.Text = currentConfig.ClientId;

            currentConfig.SharedSecret = curAppSettings["AADClientSecret"]?.ToString();
            azureSharedSecretTxt.Text = currentConfig.SharedSecret;

            bindOfferCodes();
            updateStatus("Settings initialized ...");
        }

        private void bindOfferCodes()
        {
            List<AzureOfferCode> offerCodes = Utils.GetOfferCodes();
            offerCodeLst.DataSource = offerCodes;
            offerCodeLst.DisplayMember = "OfferName";
            offerCodeLst.ValueMember = "OfferNumber";
            offerCodeLst.SelectedIndex = 0;
        }

        private void updateStatus(string statusMsg)
        {
            updateStatus(statusMsg, false);
        }
        private void updateStatus(string statusMsg, bool showProgress)
        {
            if (showProgress)
            {
                statusBottomStatus1.Style = ProgressBarStyle.Marquee;
                statusBottomStatus1.MarqueeAnimationSpeed = 30;
            }
            else
            {
                statusBottomStatus1.Style = ProgressBarStyle.Continuous;
                statusBottomStatus1.MarqueeAnimationSpeed = 0;
            }
            statusBottomLabel1.Text = statusMsg;
        }

        private async void getReportDataBtn_Click(object sender, EventArgs e)
        {
            ValidateInputForUsageList();

            using (new WaitCursor())
            {
                updateStatus("Fetching usage report list ...", true);
                string availReportsJson = await GetEnrollmentUsageList(enrollmentTx.Text, accessKeyPriceTxt.Text);
                usageListJsonTx.Text = availReportsJson;

                try
                {
                    EAAvailableUsageReports availReports = JsonConvert.DeserializeObject<EAAvailableUsageReports>(availReportsJson);

                    //Parse the response and fill the usage list
                    fillUsageList(availReports);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"An error occured getting report data::{ex.ToString()}");
                }
                updateStatus("Report list populated");
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

                //Add the reconciliation nodes to the tree
                TreeNode reconcileU2PNode = monthNode.Nodes.Add(UsageReportType.ReconcileUsageToPriceSheet.ToString(), UsageReportType.ReconcileUsageToPriceSheet.ToString());
                reconcileU2PNode.ToolTipText = "Reconcile Usage to Price Sheet";

                TreeNode reconcileS2PNode = monthNode.Nodes.Add(UsageReportType.ReconcileStoreChargeToPriceSheet.ToString(), UsageReportType.ReconcileStoreChargeToPriceSheet.ToString());
                reconcileS2PNode.ToolTipText = "Reconcile Store to Price Sheet";

                prevYear = curYear;
            }
        }


       private void btnSendRequest_Click(object sender, EventArgs e)
        {
            using (var wcur = new WaitCursor())
            {
                ValidateInputForUsageMonth();
                UsageReportType type = (UsageReportType)reportTypeCB.SelectedIndex;
                string json = GetEnrollmentUsageByMonth(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyUsageTxt.Text, formatCB.Text).Result;
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
                string json = GetEnrollmentUsageByMonthStream(monthCalendar.SelectionEnd, type, enrollmentMonthTx.Text, accessKeyUsageTxt.Text, formatCB.Text).Result;
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
                if (e.Node.Name == UsageReportType.ReconcileStoreChargeToPriceSheet.ToString() ||
                    e.Node.Name == UsageReportType.ReconcileUsageToPriceSheet.ToString())
                {
                    //Find the detail link
                    //TODO: Fix this lookup
                    TreeNode detailNode = e.Node.Parent.Nodes[0];

                    //find the price sheet link
                    TreeNode priceNode = e.Node.Parent.Nodes[1];
                    //Pass the MM, the detaill URL and the pricelist URL
                    displayCombinedReportData(e.Node.Parent.Name, detailNode.Name, priceNode.Name);
                }
                else
                {
                    displayReportData(e.Node.Parent.Name, e.Node.Text, e.Node.Name);
                }
            }

            e.Node.EnsureVisible();
        }

        private async void displayCombinedReportData(string reportDate, string usageUrl, string priceListUrl)
        {
            using (new WaitCursor())
            {
                string urlToFetch = usageUrl;
                DateTime currentReportDate = DateTime.Parse(reportDate);

                //Clear the old data
                reconciledDataGrid.DataSource = null;

                updateStatus("Fetching usage data ...", true);
                //Get the detail JSON
                string usageDataJson = await GetEnrollmentUsageByMonth(currentReportDate, UsageReportType.Detail, currentConfig.EnrollmentNumber, currentToken.Token, "json");
                List<EAUsageDetailItem> detailItems = JsonConvert.DeserializeObject<List<EAUsageDetailItem>>(usageDataJson);

                //Get the Pricing JSON
                updateStatus("Fetching price sheet ...", true);
                string pricingDataJson = await GetEnrollmentUsageByMonth(currentReportDate, UsageReportType.PriceSheet, currentConfig.EnrollmentNumber, currentToken.Token, "json");
                List<EAPriceSheetItem> priceListItems = JsonConvert.DeserializeObject<List<EAPriceSheetItem>>(pricingDataJson);

                //TODO
                //Get Azure Prices
                BearerToken bears = Utils.GetAccessTokenFromAAD(currentConfig.TenantId, currentConfig.ClientId, currentConfig.SharedSecret, currentConfig.TenantId ).Result;

                string azurePricingJson = await GetAzureRateCard(bears, currentConfig.SubscriptionId, currentConfig.AzureOfferCode, currentConfig.Currency, currentConfig.Locale, currentConfig.Region);
                List<AzureRateCard> azurePrices = JsonConvert.DeserializeObject<List<AzureRateCard>>(azurePricingJson);


                updateStatus("Data recieved, combining datasets ...", true);
                List<EAPriceToActualReconcileVMItem> reconciledData = null;
                reconciledDataGrid.DataSource = null;
                if (currentReportDate.Year < 2016 && currentReportDate.Month < 12)
                {
                    reconciledData = combineUsageAndPricingPreDec2015(detailItems, priceListItems);
                }
                else
                {
                    reconciledData = combineUsageAndPricing(detailItems, priceListItems);
                }

                updateStatus("Binding to views ...");
                currentDataLabel.Text = $"Reconciling {currentReportDate.ToString("MMMM")}-{currentReportDate.Year}";
                dataTabs.SelectedTab = dataTabs.TabPages["combinedTab"];
                reconciledDataGrid.DataSource = reconciledData;
                reconciledDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                updateStatus("Ready");

            }
        }

        private async Task<string> GetAzureRateCard(BearerToken bears, string subscriptionId, string offerCode, string currency, string locale, string region)
        {
            string rateCardApiVersion = "2015-06-01-preview";
            string rateCardUrl = $@"https://management.azure.com//subscriptions//{subscriptionId}//providers//Microsoft.Commerce//RateCard?api-version={rateCardApiVersion}&$filter=OfferDurableId eq '{offerCode}' and Currency eq '{currency}' and Locale eq '{locale}' and RegionInfo eq '{region}'";

            HttpResponseMessage response = null;
            string responseMsg = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", bears.BearerTokenHeader);
                try
                {
                    response = await client.GetAsync(rateCardUrl);
                    if (response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        responseMsg = await response.Content.ReadAsStringAsync();
                    }
                }
                catch (HttpRequestException ex)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                }
                catch (Exception ex2)
                {
                    //TODO: Show a meessage
                }
            }
            return responseMsg;
        }


        private List<EAPriceToActualReconcileVMItem> combineUsageAndPricing(List<EAUsageDetailItem> detailItems, List<EAPriceSheetItem> priceListItems)
        {
            List<EAPriceToActualReconcileVMItem> recItems = new List<EAPriceToActualReconcileVMItem>();
           //For queries starting Dec-2015, this is valid 
            var joinedData =
                from priceSheetItem in priceListItems
                join usageDetail in detailItems on priceSheetItem.Service equals usageDetail.Product into recItemsJoined
                from usageItem in recItemsJoined.DefaultIfEmpty(new EAUsageDetailItem { Product = "NO USAGE" })
                select new EAPriceToActualReconcileVMItem
                {
                    PriceListPartNumber = priceSheetItem.PartNumber,
                    UsageMeterCategory = usageItem.MeterCategory,
                    UsageMeterId = usageItem.MeterId,
                    UsageMeterName = usageItem.MeterName,
                    UsageMeterRegion = usageItem.MeterRegion,
                    UsageMeterSubCategory = usageItem.MeterSubCategory,
                    UsageProduct = usageItem.Product,
                    PriceListService = priceSheetItem.Service,
                    UsageConsumedService = usageItem.ConsumedService,
                    PriceListUnitOfMeasureAsNumber = priceSheetItem.UnitOfMeasureAsNumber,
                    PriceListUnitOfMeasureAsString = priceSheetItem.UnitOfMeasureAsString,
                    UsageUnitOfMeasure = usageItem.UnitOfMeasure,
                    PriceListUnitPrice = priceSheetItem.UnitPrice,
                    UsageExtendedCost = usageItem.ExtendedCost,
                    UsageConsumedQuantity = usageItem.ConsumedQuantity,
                    CalculatedCost = (usageItem.ConsumedQuantity / priceSheetItem.UnitOfMeasureAsNumber) * priceSheetItem.UnitPrice,
                };

            //foreach (EAUsageDetailItem detail in detailItems)
            //{
            //    EAPriceToActualReconcileVMItem recItem = new EAPriceToActualReconcileVMItem();
            //    recItem.PriceListUnitOfMeasureAsNumber = detail.ConsumedQuantity;
            //    recItem.UsageExtendedCost = detail.ExtendedCost;
            //    recItem.UsageMeterCategory = detail.MeterCategory;
            //    recItem.UsageMeterSubCategory = detail.MeterSubCategory;
            //    recItem.UsageMeterId = detail.MeterId;
            //    recItem.UsageMeterName = detail.MeterName;
            //    recItem.UsageMeterRegion = detail.MeterRegion;
            //    recItem.UsageProduct = detail.Product;
            //    recItem.UsageUnitOfMeasure = detail.UnitOfMeasure;
            //    //Loop though the usage and find the matching product SKU, unit of measure and price
            //    EAPriceSheetItem matchingPrice = priceListItems.FirstOrDefault(p => p.Service == detail.Product);

            //    if (matchingPrice == null)
            //    {
            //        //No matching price found, flag the row
            //        recItem.FoundOnPriceSheet = false;
            //    }
            //    else
            //    {
            //        recItem.FoundOnPriceSheet = true;
            //        recItem.PriceListUnitOfMeasureAsNumber = matchingPrice.UnitOfMeasureAsNumber;
            //        recItem.PriceListUnitOfMeasureAsString = matchingPrice.UnitOfMeasureAsString;
            //        recItem.PriceListUnitPrice = matchingPrice.UnitPrice;
            //        recItem.PriceListPartNumber = matchingPrice.PartNumber;
            //        recItem.PriceListService = matchingPrice.Service;
            //    }
            //    recItems.Add(recItem);
            //}

            //Now check to see if we have items not used this month
            //foreach(EAPriceSheetItem priceItem in priceListItems)
            //{

            //}
            return joinedData.ToList();
            //return recItems;
        }

        private List<EAPriceToActualReconcileVMItem> combineUsageAndPricingPreDec2015(List<EAUsageDetailItem> detailItems, List<EAPriceSheetItem> priceListItems)
        {
            List<EAPriceToActualReconcileVMItem> recItems = new List<EAPriceToActualReconcileVMItem>();
            //For queries Pre Dec-2015, this use ConsumptionPartNumber as the join key
            var joinedData =
                from priceSheetItem in priceListItems
                join usageDetail in detailItems on priceSheetItem.Service equals usageDetail.Product into recItemsJoined
                from usageItem in recItemsJoined.DefaultIfEmpty(new EAUsageDetailItem { Product = "NO USAGE" })
                select new EAPriceToActualReconcileVMItem
                {
                    PriceListPartNumber = priceSheetItem.PartNumber,
                    UsageMeterCategory = usageItem.MeterCategory,
                    UsageMeterId = usageItem.MeterId,
                    UsageMeterName = usageItem.MeterName,
                    UsageMeterRegion = usageItem.MeterRegion,
                    UsageMeterSubCategory = usageItem.MeterSubCategory,
                    UsageProduct = usageItem.Product,
                    PriceListService = priceSheetItem.Service,
                    UsageConsumedService = usageItem.ConsumedService,
                    PriceListUnitOfMeasureAsNumber = priceSheetItem.UnitOfMeasureAsNumber,
                    PriceListUnitOfMeasureAsString = priceSheetItem.UnitOfMeasureAsString,
                    UsageUnitOfMeasure = usageItem.UnitOfMeasure,
                    PriceListUnitPrice = priceSheetItem.UnitPrice,
                    UsageExtendedCost = usageItem.ExtendedCost,
                    UsageConsumedQuantity = usageItem.ConsumedQuantity,
                    CalculatedCost = (usageItem.ConsumedQuantity / priceSheetItem.UnitOfMeasureAsNumber) * priceSheetItem.UnitPrice,
                };

            return joinedData.ToList();
        }


        private async void displayReportData(string reportDate, string reportType, string UrlToReport)
        {
            using (new WaitCursor())
            {
                string urlToFetch = UrlToReport;
                DateTime currentReportDate = DateTime.Parse(reportDate);
                UsageReportType curType = (UsageReportType)Enum.Parse(typeof(UsageReportType), reportType);
                updateStatus("Fetching data ...", true);
                string usageDataJson = await GetEnrollmentUsageByMonth(currentReportDate, curType, currentConfig.EnrollmentNumber, currentToken.Token, "json");
                usageReportDataGrid.DataSource = null;
                usageReportDataGrid.AutoGenerateColumns = true;
                usageListJsonTx.Text = usageDataJson;
                currentDataLabel.Text = $"{reportType} {currentReportDate.ToString("MMMM")}-{currentReportDate.Year}";

                switch (curType)
                {
                    case UsageReportType.Detail:
                        {
                            try
                            {
                                dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAUsageDetailItem>>(usageDataJson);
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
                                dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAPriceSheetItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case UsageReportType.StoreCharge:
                        {
                            dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAStoreChargeItem>>(usageDataJson);
                            break;
                        }
                    case UsageReportType.Summary:
                        {
                            try
                            {
                                dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAUsageSummaryItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case UsageReportType.ReconcileUsageToPriceSheet:
                        {
                            try
                            {
                                //For this case, we are combining 2 data sets. Get them both and then combine them
                                dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAUsageSummaryItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                    case UsageReportType.ReconcileStoreChargeToPriceSheet:
                        {
                            try
                            {
                                dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAUsageSummaryItem>>(usageDataJson);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            break;
                        }
                }

                updateStatus("Data recieved, binding to views ...", true);
                dataTabs.SelectedTab = dataTabs.TabPages["dataTab"];
                usageReportDataGrid.DataSource = dataTabBindingSource;
                usageReportDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                updateStatus("Ready", false);
            }
        }

        private void reconciledDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = e.RowIndex;
            //Ensure they are not clicking on an empty grid
            if (reconciledDataGrid.RowCount > 1 && currentRowIndex > 0)
            {
                //Grab the current Item and display a popup
                EAPriceToActualReconcileVMItem currentItem = reconciledDataGrid.Rows[currentRowIndex].DataBoundItem as EAPriceToActualReconcileVMItem;
                if (currentItem != null)
                {

                }
            }
        }

        private async void getPublicPricingBtn_Click(object sender, EventArgs e)
        {
            if (!validateRuntimeSettings()) { return; }

            using (new WaitCursor())
            {
                updateStatus("Fetching data ...", true);
                BearerToken bears = Utils.GetAccessTokenFromAAD(currentConfig.TenantId, currentConfig.ClientId, currentConfig.SharedSecret, currentConfig.ResourceUri).Result;
                string azPricingDataJson = await GetAzureRateCard(bears, currentConfig.SubscriptionId, ((AzureOfferCode)offerCodeLst.SelectedItem).OfferNumber, currencyLst.SelectedItem.ToString(), localeLst.SelectedItem.ToString(), regionLst.SelectedItem.ToString());
                List<AzureRateCard> azurePrices = JsonConvert.DeserializeObject<List<AzureRateCard>>(azPricingDataJson);

                usageReportDataGrid.DataSource = null;
                usageReportDataGrid.AutoGenerateColumns = true;
                usageListJsonTx.Text = azPricingDataJson;
                //currentDataLabel.Text = $"{reportType} {currentReportDate.ToString("MMMM")}-{currentReportDate.Year}";

                try
                {
                    dataTabBindingSource.DataSource = JsonConvert.DeserializeObject<List<EAPriceSheetItem>>(azPricingDataJson);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                updateStatus("Data recieved, binding to views ...", true);
                dataTabs.SelectedTab = dataTabs.TabPages["publicPricingTab"];
                publicPricingDataGrid.DataSource = dataTabBindingSource;
                publicPricingDataGrid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                updateStatus("Ready", false);

            }
        }

        private bool validateRuntimeSettings()
        {
            bool isValid = false;
           if (!string.IsNullOrEmpty(currentConfig.AzureOfferCode))
            {
                isValid = true;
            }

            return isValid;
        }

        private void eaTestKeyLnk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link != null)
            {
                Process.Start(e.Link.LinkData as string);
            }
        }

        private void savConifigBtn_Click(object sender, EventArgs e)
        {
            //Update the currrent config and save
            Settings appSettings = Settings.Default;
            appSettings.AADClientId = azureClientIdTxt.Text;

            appSettings.AADClientSecret = azureSharedSecretTxt.Text;

            appSettings.AADTenantId = aadTenantIdTxt.Text;

            appSettings.AccessKeyBilling = accessKeyPriceTxt.Text;

            appSettings.AccessKeyUsage = accessKeyUsageTxt.Text;

            appSettings.DefaultCurrency = currencyLst.SelectedValue?.ToString();

            appSettings.DefaultLocale = localeLst.SelectedValue?.ToString();

            appSettings.DefaultRegion = regionLst.SelectedValue?.ToString();

            appSettings.EnrollmentNumber = enrollmentTx.Text;

            appSettings.SubscriptionId = azureSubscriptionIdTxt.Text;

            appSettings.Save();

            //initSettings();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            initSettings();
            initValidators();
        }
    }
}
