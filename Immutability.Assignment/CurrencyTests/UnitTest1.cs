using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Immutability.Assignment;

namespace CurrencyTests
{
    [TestClass]
    public class UnitTest1
    {
        private Currency _currency;
        [TestInitialize]
        public void Initialize()
        {
            _currency = new Currency();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
