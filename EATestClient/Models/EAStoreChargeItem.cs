using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAStoreChargeItem
    {
        public string AccountOwnerId { get; set; }
        public string AccountName { get; set; }
        public long SubscriptionId { get; set; }
        public string SubscriptionGuid { get; set; }
        public string SubscriptionName { get; set; }
        public string Date { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
        public string MeterId { get; set; }
        public string PublisherName { get; set; }
        public string OfferName { get; set; }
        public string PlanName { get; set; }
        public decimal? ConsumedQuantity { get; set; }
        public decimal? ResourceRate { get; set; }
        public decimal? ExtendedCost { get; set; }
        public string UnitOfMeasure { get; set; }
        public string InstanceId { get; set; }
        public string AdditionalInfo { get; set; }
        public string Tags { get; set; }
        public string OrderNumber { get; set; }
        public string DepartmentName { get; set; }
        public string CostCenter { get; set; }
        public string ResourceGroup { get; set; }
    }
}
