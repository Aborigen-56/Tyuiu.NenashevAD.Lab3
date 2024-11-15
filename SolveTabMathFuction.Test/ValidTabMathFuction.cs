using SolveTabMathFuction.Lib;

namespace SolveTabMathFuction.Test
{
    [TestClass]
    public class ValidTabMathFuction
    {
        [TestMethod]
        public void TestCalculateTabMathFuction()
        {
            TabMathFuction Calculate = new TabMathFuction();
            int startValue = -5;
            int stopValue = 5;
            double[] expected = { -9796193.01, -645175.14, -31082.92, -878.83, -11.16, 1.00, 4.53, 11.62, 26.00, 61.02, 154.93 };
            double[] actual = Calculate.CalculateTabMathFuction(startValue, stopValue);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}