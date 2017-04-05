using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAUsageDetailItem
    {
        public string AccountOwnerId { get; set; }
        public string AccountName { get; set; }
        public string ServiceAdministratorId { get; set; }
        public long SubscriptionId { get; set; }
        public string SubscriptionGuid { get; set; }
        public string SubscriptionName { get; set; }
        public string Date { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string Product { get; set; }
        public string MeterId { get; set; }
        public string MeterCategory { get; set; }
        public string MeterSubCategory { get; set; }
        public string MeterRegion { get; set; }
        public string MeterName { get; set; }
        public double? ConsumedQuantity { get; set; }
        public double? ResourceRate { get; set; }
        public double? ExtendedCost { get; set; }
        public string ResourceLocation { get; set; }
        public string ConsumedService { get; set; }
        public string InstanceId { get; set; }
        public string ServiceInfo1 { get; set; }
        public string ServiceInfo2 { get; set; }
        public string AdditionalInfo { get; set; }
        public string Tags { get; set; }
        public string StoreServiceIdentifier { get; set; }
        public string DepartmentName { get; set; }
        public string CostCenter { get; set; }
        public string UnitOfMeasure { get; set; }
        public string ResourceGroup { get; set; }
    }
}
