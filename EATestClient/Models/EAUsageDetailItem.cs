namespace EATestClient.Models
{
    public class EAUsageDetailItem
    {
        public string AccountName { get; set; }

        /// <summary>
        /// AccountOwnerId (formerly AccountOwnerLiveId) is an email address (e.g. jondoe@microsoft.com). The ID is the email address used to log into the Azure portal.
        /// </summary>
        public string AccountOwnerId { get; set; }
        /// <summary>
        /// Description of the compute instance size. For example, Cloud Services returns ComputeSmall for a small compute instance.
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// The amount of the resource used during the billing period.
        /// </summary>
        public decimal? ConsumedQuantity { get; set; }

        /// <summary>
        /// The Azure platform service that you used.
        /// </summary>
        public string ConsumedService { get; set; }

        public string CostCenter { get; set; }
        /// <summary>
        /// This field indicates the date on which this service catalog report was run.
        /// </summary>
        public string Date { get; set; }
        public int Day { get; set; }
        public string DepartmentName { get; set; }
        public decimal? ExtendedCost { get; set; }
        /// <summary>
        /// The identifier for the resource. The identifier contains the name you specify for the resource when it was created. It's either the name of the resource or the fully qualified Resource ID. For more information, see Azure Resource Manager API
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Identifies the top-level service for which this usage belongs
        /// </summary>
        public string MeterCategory { get; set; }

        /// <summary>
        /// The billed meter identifier. This is an identifier used to price billing usage.
        /// </summary>
        public string MeterId { get; set; }

        /// <summary>
        /// Identifies the unit of measure for the resource being consumed.
        /// </summary>
        public string MeterName { get; set; }

        /// <summary>
        /// Identifies the location of the datacenter for certain services that are priced based on datacenter location
        /// </summary>
        public string MeterRegion { get; set; }

        /// <summary>
        /// Defines the type of Azure service and can affect the rate
        /// </summary>
        public string MeterSubCategory { get; set; }

        public int Month { get; set; }
        public string Product { get; set; }
        /// <summary>
        /// The resource group in which the deployed resource is running in. For more information, see Azure Resource Manager overview.
        /// </summary>
        public string ResourceGroup { get; set; }

        /// <summary>
        /// Identifies the datacenter where the resource is running.
        /// </summary>
        public string ResourceLocation { get; set; }

        public decimal? ResourceRate { get; set; }
        public string ServiceAdministratorId { get; set; }
        /// <summary>
        /// The project name that the service belongs to on your subscription.
        /// </summary>
        public string ServiceInfo1 { get; set; }

        /// <summary>
        /// This is a legacy field that captures optional service-specific metadata.
        /// </summary>
        public string ServiceInfo2 { get; set; }

        public string StoreServiceIdentifier { get; set; }
        /// <summary>
        /// The subscription identifier.
        /// </summary>
        public string SubscriptionGuid { get; set; }
        /// <summary>
        /// The subscription identifier for the Azure user.
        /// </summary>
        public long SubscriptionId { get; set; }
        /// <summary>
        /// Name of the service offering
        /// </summary>
        public string SubscriptionName { get; set; }
        /// <summary>
        /// Resource tags specified by the user. This property is optional and may not be included.
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// The unit in which the usage for this resource is being counted, e.g. Hours, GB.
        /// </summary>
        public string UnitOfMeasure { get; set; }
        public int Year { get; set; }
    }
}
