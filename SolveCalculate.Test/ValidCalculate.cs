using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    [TestClass]
    public class ValidCalculate
    {
        [TestMethod]
        public void TestCalculateSumma()
        {
            Calculate calculate = new Calculate();
            Assert.AreEqual(calculate.CalculateSumma(3, 8), 11);
        }
        
        [TestMethod]
        public void TestCalculateDifference()
        {
            Calculate calculate = new Calculate();
            Assert.AreEqual(calculate.CalculateDifference(9, 7), 2);
        }

        [TestMethod]
        public void TestCalculateMultiplication()
        {
            Calculate calculate = new Calculate();
            Assert.AreEqual(calculate.CalculateMultiplication(5, 6), 30);
        }

        [TestMethod]
        public void TestCalculateQuotient()
        {
            Calculate calculate = new Calculate();
            Assert.AreEqual(calculate.CalculateQuotient(8, 2), 4);
        }

    }
}