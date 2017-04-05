using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAUsageAvailableMonth
    {
        public string LinkToDownloadDetailReport { get; set; }
        public string LinkToDownloadPriceSheetReport { get; set; }
        public string LinkToDownloadStoreChargeReport { get; set; }
        public string LinkToDownloadSummaryReport { get; set; }
        public string Month { get; set; }
    }
}
