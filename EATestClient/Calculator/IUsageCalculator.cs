using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Calculator
{
    public interface IUsageCalculator
    {
        /// <summary>
        /// Checks to see if the Azure Service Name from the usage sheet is found on the price sheet
        /// </summary>
        /// <param name="AzureServiceName"></param>
        /// <returns></returns>
        bool IsSkuFoundOnPriceSheet(string AzureServiceName);
        /// <summary>
        /// Checks to see if the part number on the price list is found in the usage
        /// </summary>
        /// <param name="PartNumber"></param>
        /// <returns></returns>
        bool IsServiceFoundOnUsageDetail(string PartNumber);

        /// <summary>
        /// Checks to see if the price sheet, and usage combination match
        /// </summary>
        /// <returns></returns>
        bool IsValid();

        /// <summary>
        /// Ensures that the calculator has the proper data to try to caluculate
        /// </summary>
        /// <returns></returns>
        bool CanCalculate();

        int CalculateUsageCost();

    }
}
