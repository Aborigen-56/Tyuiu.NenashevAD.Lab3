namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double a, double x, double y)
        {
            return Math.Round(2 * y + (2 + 3 * a) / (10 * x - 3 * a) + 2 * a + ((a / y) / (3 * a / x)), 3);
        }
    
    }
}
