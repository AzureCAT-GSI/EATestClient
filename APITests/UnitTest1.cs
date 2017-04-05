using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace APITests
{
    [TestClass]
    public class EAPriceSheetTest
    {
        string apikey = string.Empty;
        public EAPriceSheetTest()
        {
            initTest();
        }

        private void initTest()
        {
            apikey = "";
        }

        [TestMethod]
        public void CanGetPriceSheet()
        {
        }

    }
}
