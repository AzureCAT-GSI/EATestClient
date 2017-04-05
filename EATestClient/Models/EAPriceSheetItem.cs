using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAPriceSheetItem
    {
        public EAPriceSheetItem()
        {

        }
        public string Service { get; set; }
        public string UnitOfMeasure { get; set; }
        /// <summary>
        /// The parsed unit of measure as integer
        /// </summary>
        public double? UnitOfMeasureAsNumber {
            get
            {
                int retVal = 0;
                if (!string.IsNullOrEmpty(UnitOfMeasure))
                {
                    //parse the unit of measure. Get the first Space, this is the unit number
                    int splitChar = UnitOfMeasure.IndexOf(" ");
                    string unitInt = UnitOfMeasure.Substring(0, splitChar);
                    string unitString = UnitOfMeasure.Substring(splitChar);
                    if (!string.IsNullOrEmpty(unitInt))
                    {
                        //Strip the commas
                        string cleanString = unitInt;
                        if (unitInt.Contains(','))
                        {
                            cleanString = unitInt.Replace(",", "");
                        }
                        retVal = int.Parse(cleanString.Trim());
                    }
                }
                return retVal;
            }
        }
        public string UnitOfMeasureAsString
        {
            get
            {
                string retVal = string.Empty;
                if (!string.IsNullOrEmpty(UnitOfMeasure))
                {
                    //parse the unit of measure. Get the first Space, this is the unit number
                    int splitChar = UnitOfMeasure.IndexOf(" ");
                    string unitInt = UnitOfMeasure.Substring(0, splitChar);
                    string unitString = UnitOfMeasure.Substring(splitChar);
                    if (!string.IsNullOrEmpty(unitInt))
                    {
                        retVal = unitString.Trim();
                    }
                }
                return retVal;
            }
        }
        public string ConsumptionPartNumber { get; set; }
        public double? ConsumptionPrice { get; set; }

        public string PartNumber { get; set; }
        public Double? UnitPrice { get; set; }
        public string CurrencyCode { get; set; }
    }
}
