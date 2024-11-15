using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            MathFirstExpression mathFirstExpression = new MathFirstExpression();
            Assert.AreEqual(mathFirstExpression.CalculateFirstExpression(5, 6, 9), 62.051);
        }
    }
}