using ClassLibraryForClientsNet;

namespace ClassLibraryForClientsNetTests2
{
    [TestClass]
    public class TriangleAreaTests
    {
        [TestMethod]
        public void AreaOfTriangleCalculationTEST_PositiveNumbers()
        {
            Assert.AreEqual(109.35199998171049, Calculation.AreaOfTriangleCalculation(10.2, 24, 30));
        }

        [TestMethod]
        public void AreaOfTriangleCalculationTEST_NegativeNumbers()
        {
            Assert.AreEqual(null, Calculation.AreaOfTriangleCalculation(-10.2, -24, -30));
        }

        [TestMethod]
        public void AreaOfTriangleCalculationTEST_NegativeNumber()
        {
            Assert.AreEqual(null, Calculation.AreaOfTriangleCalculation(10.2, -24, 30));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_Null()
        {
            Assert.AreEqual(null, Calculation.AreaOfTriangleCalculation(0, 0, 0));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_BigNumber()
        {
            Assert.AreEqual(null, Calculation.AreaOfTriangleCalculation(9000000, 4, 5));
        }

        [TestMethod]
        public void AreaOfCircleCalculationTEST_BigNumbers()
        {
            Assert.AreEqual(2352525238971943.5, Calculation.AreaOfTriangleCalculation(90000000, 80000000, 60000000));
        }

        [TestMethod]
        public void AreaOfTriangleCalculationTEST_ImpossibleValue()
        {
            Assert.AreEqual(null, Calculation.AreaOfTriangleCalculation(3, 4, 1));
        }

    }
}