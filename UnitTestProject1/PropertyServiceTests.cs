using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleTest.Models;
using SampleTest.Services;

namespace UnitTestProject1
{
    [TestClass]
    public class PropertyServiceTests
    {

        private const string XML_PROVIDER = "Microsoft.VisualStudio.TestTools.DataSource.XML";
        //Inside XML\TestData.xml, for every CanBuyHouse node, create the appropriate child nodes to satisfy the expected results (one positive and one negative test)
        [TestMethod]
        [DataSource(XML_PROVIDER, @"|DataDirectory|\XML\TestData.xml", "CanBuyHouse", DataAccessMethod.Sequential)]
        public void CanBuyHouse()
        {

            //Get the expected results, input country, and properties country from the XML
            string country = "Get the Data from the XML";
            bool expected = false;//Get the data from the XML
            Property prop = new Property();
            prop.Country = "Get the data from the XML";
            PropertyService propertyService = new PropertyService();

            var actual = propertyService.CanBuyHouse(prop, country);

            Assert.AreEqual(expected, actual);
        }
    }
}
