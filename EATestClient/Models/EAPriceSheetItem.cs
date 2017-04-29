using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EATestClient.Models
{
    public class EAPriceSheetItem
    {
        private string unitOfMeasure;

        public EAPriceSheetItem()
        {

        }
        public string ConsumptionPartNumber { get; set; }
        public decimal? ConsumptionPrice { get; set; }
        /// <summary>
        /// The currency used in your current billing period.
        /// </summary>
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Identifies the unique system identifier for each Azure resource. AKA SKU
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        /// An Azure service name, such as Storage or Virtual Machines. Service names are created by product teams that own the service.
        /// </summary>
        public string Service { get; set; }
        /// <summary>
        /// The basis of measurement for a service. Some common units of measurements are:
        /// GB Gigabytes are the unit of measure for Storage
        /// Compute Hours Virtual Machines and Cloud Services Compute measure hours of use
        /// Database Days SQL Server measures instances in database days
        /// </summary>
        public string UnitOfMeasure {
            get
            {
                return unitOfMeasure;
            }
            set
            {
                unitOfMeasure = value;
            }
        }
        /// <summary>
        /// The parsed unit of measure as a decimal. Returns just the raw number
        /// </summary>
        public decimal? UnitOfMeasureAsNumber {
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
        /// <summary>
        /// The parsed unit of measure as a string.Returns just the Unit (GB, Hours, Days, etc)
        /// </summary>
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
        /// <summary>
        /// Identifies the Unit that the service is charged in. For example, GB, hours, 10,000s.
        /// </summary>
        public decimal? UnitPrice { get; set; }
    }
}
