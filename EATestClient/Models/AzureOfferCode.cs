using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class AzureOfferCode
    {
        public string OfferName { get; set; }
        public string OfferNumber { get; set; }
        public bool SpendingLimit { get; set; }
        public bool IsRetired { get; set; }
    }
}
