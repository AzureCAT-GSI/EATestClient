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

    }
}
