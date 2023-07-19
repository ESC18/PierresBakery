// BreadPrice.Tests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalc.Models;

namespace PriceCalc.Tests
{
    [TestClass]
    public class BreadPriceTests
    {
        [TestMethod]
        public void BreadOutput_ReturnsTotalCostForMultipleOfThreeBread()
        {
            int userNumBread = 6;
            int expectedCost = 20;
            BreadPrice breadCalculation = new BreadPrice(userNumBread);
            int actualCost = breadCalculation.BreadOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void BreadOutput_ReturnsTotalCostForNonMultipleOfThreeBread()
        {
            int userNumBread = 4;
            int expectedCost = 15;
            BreadPrice breadCalculation = new BreadPrice(userNumBread);
            int actualCost = breadCalculation.BreadOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void BreadOutput_ReturnsTotalCostForZeroBread()
        {
            int userNumBread = 0;
            int expectedCost = 0;
            BreadPrice breadCalculation = new BreadPrice(userNumBread);
            int actualCost = breadCalculation.BreadOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void BreadOutput_ReturnsTotalCostForLessThanThreeBread()
        {
            int userNumBread = 2;
            int expectedCost = 10;
            BreadPrice breadCalculation = new BreadPrice(userNumBread);
            int actualCost = breadCalculation.BreadOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
