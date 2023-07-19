// PastryPrice.Tests.cs
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalc.Models;

namespace PriceCalc.Tests
{
    [TestClass]
    public class PastryPriceTests
    {
        [TestMethod]
        public void PastryOutput_ReturnsTotalCostForMultipleOfFourPastry()
        {
            int userNumPastry = 8;
            int expectedCost = 12;
            PastryPrice pastryCalculation = new PastryPrice(userNumPastry);
            int actualCost = pastryCalculation.PastryOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void PastryOutput_ReturnsTotalCostForNonMultipleOfFourPastry()
        {
            int userNumPastry = 5;
            int expectedCost = 8;
            PastryPrice pastryCalculation = new PastryPrice(userNumPastry);
            int actualCost = pastryCalculation.PastryOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void PastryOutput_ReturnsTotalCostForZeroPastry()
        {
            int userNumPastry = 0;
            int expectedCost = 0;
            PastryPrice pastryCalculation = new PastryPrice(userNumPastry);
            int actualCost = pastryCalculation.PastryOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }

        [TestMethod]
        public void PastryOutput_ReturnsTotalCostForLessThanFourPastry()
        {
            int userNumPastry = 2;
            int expectedCost = 4;
            PastryPrice pastryCalculation = new PastryPrice(userNumPastry);
            int actualCost = pastryCalculation.PastryOutput();
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}
