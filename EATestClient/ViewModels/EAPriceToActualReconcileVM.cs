using EATestClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.ViewModels
{
    public class EAPriceToActualReconcileVMItem
    {
        public DateTime StartDate = System.DateTime.UtcNow;
        public DateTime EndDate = System.DateTime.UtcNow;

        public decimal? PriceListUnitOfMeasureAsNumber { get; internal set; }
        public decimal? UsageExtendedCost { get; internal set; }
        public string UsageMeterCategory { get; internal set; }
        public string UsageMeterSubCategory { get; internal set; }
        public string UsageMeterId { get; internal set; }
        public string UsageMeterName { get; internal set; }
        public string UsageMeterRegion { get; internal set; }
        public string UsageProduct { get; internal set; }
        public string UsageUnitOfMeasure { get; internal set; }
        public string PriceListUnitOfMeasureAsString { get; internal set; }
        public decimal? PriceListUnitPrice { get; internal set; }
        public string PriceListPartNumber { get; internal set; }
        public string PriceListService { get; internal set; }
        public decimal? UsageConsumedQuantity { get; internal set; }
        public string UsageConsumedService { get; internal set; }
        public decimal? CalculatedCost { get; internal set; }
    }
}
