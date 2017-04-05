using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAAvailableUsageReports
    {
        public List<EAUsageAvailableMonth> AvailableMonths { get; set; }
        public string ContractVersion { get; set; }
        public string ObjectType { get; set; }
    }
}
