using System.Collections.Generic;

namespace EATestClient.Models
{
    public class AzureRateCard
    {
        public List<OfferTerm> OfferTerms { get; set; }
        public List<Meter> Meters { get; set; }
        public string Currency { get; set; }
        public string Locale { get; set; }
        public bool IsTaxIncluded { get; set; }
        public string MeterRegion { get; set; }
        public List<object> Tags { get; set; }

        public class OfferTerm
        {
            public string Name { get; set; }
            public double? Credit { get; set; }
            public List<string> ExcludedMeterIds { get; set; }
            public string EffectiveDate { get; set; }
        }

        public class Meter
        {
            public string MeterId { get; set; }
            public string MeterName { get; set; }
            public string MeterCategory { get; set; }
            public string MeterSubCategory { get; set; }
            public string Unit { get; set; }
            public string MeterRates { get; set; }
            public string EffectiveDate { get; set; }
            public double IncludedQuantity { get; set; }
        }
    }
}