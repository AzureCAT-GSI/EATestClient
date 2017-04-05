using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAUsageSummaryItem
    {
        public string Amount { get; set; }

        [JsonProperty(PropertyName = "Azure Service Commitment")]
        public string AzureServiceCommitment { get; set; }

        [JsonProperty(PropertyName="Currency Code")]
        public string CurrencyCode { get; set; }
    }
}

