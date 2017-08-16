using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Immutability.Assignment;

namespace CurrencyTests
{
    [TestClass]
    public class CurrencyTestFixtures
    {
        private CurrencyDictionary _currencyCollection;

        [TestInitialize]
        public void Initialize()
        {
            _currencyCollection = new CurrencyDictionary();
        }

        [TestMethod]
        public void TestCurrencyStateChange()
        {
            var currencyInfo = _currencyCollection.CurrencyCollection["India"];
            var currency = currencyInfo.ToUpper(currencyInfo);
        }
    }
}
