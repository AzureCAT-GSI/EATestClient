using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Common
{
    public class RuntimeConstants
    {
        public static string AzureUsageUrl = @"https://management.azure.com/subscriptions/{SUBSCRIPTIONID}/providers/Microsoft.Commerce/UsageAggregates?api-version={APIVERSION}&reportedStartTime={st}&reportedEndTime={et}&aggregationGranularity={AGGREGATIONGRANULARITY}&showDetails={SHOWDETAILS}";
        public static string DefaultAzureRegion = "EN-US";

        public static string BaseUsageUrl = @"https://consumption.azure.com/v1/enrollments";
        public static string BillingPeriodUrl = BaseUsageUrl + "/{enrollmentNumber}/billingperiods";
        public static string UsageDetailsUrl = BaseUsageUrl + "/{enrollmentNumber}/usagedetails";
        public static string UsageDetailsByBillingPeriodUrl = BaseUsageUrl + "/{enrollmentNumber}/billingPeriods/{billingPeriod}/usagedetails";
        public static string UsageDetailsByDateUrl = BaseUsageUrl + "/{enrollmentNumber}/usagedetailsbycustomdate?startTime={startdate}&endTime={enddate}";
        public static string UsageDetailsMarketplaceUrl = BaseUsageUrl + "/enrollments/{enrollmentNumber}/marketplacecharges";
        public static string UsageDetailsMarketplaceByBillingPeriodUrl = BaseUsageUrl + "/{enrollmentNumber}/billingPeriods/{billingPeriod}/marketplacecharges";
        public static string UsageDetailsMarketplaceByDateUrl = BaseUsageUrl + "/{enrollmentNumber}/marketplacechargesbycustomdate?startTime={startdate}&endTime={enddate}";
        public static string PriceSheetUrl = BaseUsageUrl + "/{enrollmentNumber}/pricesheet";
        public static string PriceSheetByBillingPeriodUrl = BaseUsageUrl + "/{enrollmentNumber}/billingPeriods/{billingPeriod}/pricesheet";
    }
}
