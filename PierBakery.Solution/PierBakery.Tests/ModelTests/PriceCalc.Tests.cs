using Microsoft.VisualStudio.TestTools.UnitTesting;
using PriceCalc.Models;

namespace PriceCalc.Tests.ModelTests
{
    [TestClass]
    public class PriceCalcTests
    {
        [TestMethod]
        public void BreadOutput_ReturnsCorrectPrice_ForMultipleOf3()
        {
            int userNumBread = 6; // Multiple of 3
            BreadPrice breadPrice = new BreadPrice();
            int result = breadPrice.BreadOutput(userNumBread);
            int expectedPrice = (userNumBread / 3) * 10;
            Assert.AreEqual(expectedPrice, result);
        }
        
        [TestMethod]
        public void BreadOutput_ReturnsCorrectPrice_ForLessThanOrEqualTo0()
        {
            int userNumBread = 0; // Less than or equal to 0
            BreadPrice breadPrice = new BreadPrice();
            int result = breadPrice.BreadOutput(userNumBread);
            int expectedPrice = 0;
            Assert.AreEqual(expectedPrice, result);
        }
    }
}