using System;

namespace EATestClient
{
    public enum UsageReportType
    {
        //Used to show the combined reports of Detail and PriceSheet
        ReconcileUsageToPriceSheet = 0,
        //Used to show the combined reports of Summary and PriceSheet
        ReconcileStoreChargeToPriceSheet = 1,
        Summary = 2,
        Detail = 3,
        StoreCharge = 4,
        PriceSheet=5
    }
}
