using ClassLibraryForClientsNet;

namespace ClassLibraryForClientsNetTests2
{
    [TestClass]
    public class CircleAreaTests
    {
        [TestMethod]
        public void AreaOfCircleCalculationTEST_PositiveNumber()
        {
            Assert.AreEqual(Math.PI, Calculation.AreaOfCircleCalculation(1));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_NegativeNumber()
        {
            Assert.AreEqual(null, Calculation.AreaOfCircleCalculation(-4));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_Null()
        {
            Assert.AreEqual(null, Calculation.AreaOfCircleCalculation(0));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_FractionalNumber()
        {
            Assert.AreEqual(19.634954084936208, Calculation.AreaOfCircleCalculation(2.5));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_BigNumber()
        {
            Assert.AreEqual(254469004940773.25, Calculation.AreaOfCircleCalculation(9000000));
        }
    }
}