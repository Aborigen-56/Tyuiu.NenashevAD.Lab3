using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            MathSecondExpression mathSecondExpression = new MathSecondExpression();
            Assert.AreEqual(mathSecondExpression.CalculateSecondExpression(2.0, 3.0, 4.0), 12.583);
        }
    }
}