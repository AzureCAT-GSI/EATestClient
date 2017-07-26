using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Common
{
    public class RuntimeConfig
    {
        public string Locale { get; set; }
        public string Currency { get; set; }
        public string Region { get; set; }
        public string AzureOfferCode { get; set; }
        public string ClientId { get; set; }
        public string SharedSecret { get; set; }
        public string EnrollmentNumber { get; set; }
        public string UsageAccessKey { get; set; }
        public string PricingAccessKey { get; set; }
        public string SubscriptionId { get; set; }
        public string TenantId { get; set; }
        public string BillingAccessKey { get; internal set; }
        public string ResourceUri { get { return "https://microsoft.onmicrosoft.com/9dd79774-c43d-4400-a643-daa41c1bd484"; } set { } }

        public string ManagementTokenAudience { get; internal set; }
    }
}
