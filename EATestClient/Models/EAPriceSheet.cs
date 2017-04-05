using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAPriceSheet
    {
        public DateTime EndDate = System.DateTime.UtcNow;
        public List<EAPriceSheetItem> PriceListItems = new List<EAPriceSheetItem>();
        public DateTime StartDate = System.DateTime.UtcNow;
    }
}
