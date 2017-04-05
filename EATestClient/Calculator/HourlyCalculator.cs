using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EATestClient.Models;

namespace EATestClient.Calculator
{
    public class HourlyCalculator : IUsageCalculator
    {
        EAPriceSheetItem currentPriceSheetItem;
        EAUsageDetailItem currentUsageItem;

        public bool HasDescrepency { get; set; }
        public HourlyCalculator(EAPriceSheetItem item, EAUsageDetailItem usage)
        {
            if (!IsValid()) { throw new Exception("Unable to initialize calculator."); }
            currentPriceSheetItem = item;
            currentUsageItem = usage;
        }
        public int CalculateUsageCost()
        {
            int usageCost = 0;
            if (!CanCalculate()) { throw new Exception("Unable to initialize calculator."); }

            if (IsSkuFoundOnPriceSheet(currentUsageItem.Product))
            {
                //Calulate the usage based on the meter type
                //////double? baseCost = currentPriceSheetItem.CommitmentPrice;
                ////double? usage = currentUsageItem.ConsumedQuantity;
                ////double? calculatedCost = usage * baseCost;
                //if (calculatedCost != currentUsageItem.ExtendedCost)
                //{
                //    //mark the current item as not good
                //    HasDescrepency = true;
                //}
            }
            return usageCost;
        }

        public bool CanCalculate()
        {
            bool retVal = false;
            if (IsSkuFoundOnPriceSheet(currentUsageItem.Product))
            {
                //if (IsServiceFoundOnUsageDetail(currentPriceSheetItem.ConsumptionPartNumber))
                {
                    retVal = true;
                }
            }
            return retVal;
        }

        public bool IsServiceFoundOnUsageDetail(string PartNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsSkuFoundOnPriceSheet(string AzureServiceName)
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
