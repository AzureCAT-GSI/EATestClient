using EATestClient.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Common
{
    public class Utils
    {
        /// <summary>
        /// From https://azure.microsoft.com/en-us/support/legal/offer-details/
        /// Valid as of April 5, 2017 (8:00 AM EDT)
        /// </summary>
        /// <returns>A list of offer codes</returns>
        public static List<AzureOfferCode> GetOfferCodes()
        {
            List<AzureOfferCode> codes = new List<AzureOfferCode>() {
                new AzureOfferCode() { OfferName = "Enterprise Agreement Support" },
                new AzureOfferCode() { OfferName = "Pay-As-You-Go", OfferNumber="0003P" },
                new AzureOfferCode() { OfferName = "Support Plans", OfferNumber="0041P, 0042P, 0043P" },
                new AzureOfferCode() { OfferName = "Free Trial", OfferNumber="0044P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Professional subscribers", OfferNumber="0059P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Test Professional subscribersv0060P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "MSDN Platforms subscribers", OfferNumber="0062P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Enterprise subscribers", OfferNumber="0063P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Enterprise (BizSpark) subscribers", OfferNumber="0064P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Enterprise (MPN) subscribers", OfferNumber="0029P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Dev Essentials members", OfferNumber="0022P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Pay-As-You-Go Dev/Test", OfferNumber="0023P" },
                new AzureOfferCode() { OfferName = "Enterprise Dev/Test", OfferNumber="0148P" },
                new AzureOfferCode() { OfferName = "Action Pack", OfferNumber="0025P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Microsoft Azure Sponsored Offer", OfferNumber="0036P" },
                new AzureOfferCode() { OfferName = "Azure Pass", OfferNumber="0120P-0130P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure in Open Licensing", OfferNumber="0111p" , SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Microsoft Imagine", OfferNumber="0144P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "BizSpark Plus", OfferNumber="0149P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure in CSP", OfferNumber="0145P" },
                new AzureOfferCode() { OfferName = "Azure Germany in CSP for Microsoft Cloud Germany", OfferNumber="DE-0145P" },
                new AzureOfferCode() { OfferName = "Azure Germany Free Trial", OfferNumber="0044P", SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure Germany Pay - As - You - Go", OfferNumber="DE-0003P" },
                new AzureOfferCode() { OfferName = "Azure Germany Support Plans", OfferNumber="DE-0041P, DE-0042P, DE-0043P" },
                //Retired
                new AzureOfferCode() { OfferName = "Promotional Offer", OfferNumber="0070P-0089P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure Dynamics", OfferNumber="0033P", IsRetired=true },
                new AzureOfferCode() { OfferName = "Azure MSDN Premium", OfferNumber="0005P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure MSDN – Visual Studio", OfferNumber="0010P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure MSDN – Visual Studio Premium", OfferNumber="0011P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Azure MSDN – Visual Studio Ultimate", OfferNumber="0012P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "MPN Silver Cloud Platform Competency", OfferNumber="0027P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "MPN Gold Cloud Platform Competency", OfferNumber="0028P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "BizSpark Plus", OfferNumber="0034P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "6 - Month Plan", OfferNumber="0037P", IsRetired=true },
                new AzureOfferCode() { OfferName = "6 - Month Plan(Prepaid)", OfferNumber="0038P", IsRetired=true },
                new AzureOfferCode() { OfferName = "12 - Month Commitment Offer", OfferNumber="0026P", IsRetired=true },
                new AzureOfferCode() { OfferName = "12 - Month Plan", OfferNumber="0039P", IsRetired=true },
                new AzureOfferCode() { OfferName = "12 - Month Plan(Prepaid)", OfferNumber="0040P", IsRetired=true },
                new AzureOfferCode() { OfferName = "MPN Action Pack", OfferNumber="0035P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Visual Studio Premium with MSDN(benefit)", OfferNumber="0061P", IsRetired=true, SpendingLimit=true },
                new AzureOfferCode() { OfferName = "Backup Storage for Windows Server", OfferNumber="0090P", IsRetired=true, SpendingLimit=true },
            };
            return codes;
        }

        public static async Task<BearerToken> GetAccessTokenFromAAD(string tenantId, string clientId, string clientSecret, string resourceUri)
        {
            string accessToken = string.Empty;
            string grantType = "client_credentials";
            BearerToken newToken = null;
            HttpResponseMessage response = null;

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri($"https://login.microsoftonline.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var postData = new List<KeyValuePair<string, string>>();
                postData.Add(new KeyValuePair<string, string>("grant_type", grantType));
                postData.Add(new KeyValuePair<string, string>("client_id", clientId));
                postData.Add(new KeyValuePair<string, string>("client_secret", clientSecret));
                postData.Add(new KeyValuePair<string, string>("resource", resourceUri));

                HttpContent content = new FormUrlEncodedContent(postData);
                try
                {
                    response = client.PostAsync($"{tenantId}/oauth2/token", content).Result;
                    if (response.StatusCode.Equals(HttpStatusCode.OK))
                    {
                        string responseMsg = await response.Content.ReadAsStringAsync();
                        newToken = JsonConvert.DeserializeObject<BearerToken>(responseMsg);
                    }
                }
                catch (HttpRequestException ex)
                {
                    response.StatusCode = HttpStatusCode.BadRequest;
                }
                catch (Exception ex2)
                {
                    response.StatusCode = HttpStatusCode.Unauthorized;
                }
            }

            return newToken;
        }
    }
}
