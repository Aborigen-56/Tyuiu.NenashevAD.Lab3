namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(int arg1, int arg2, int arg3)
        {
            var x = (double)arg1;
            var y = (double)arg2;
            var a = (double)arg3;
            return Math.Round(6 * y - (((a + 3) / x) / ((2 - x * a) / (x * y))) + (2 + 3 * a) / (10 * x + 3 * a) + 4 * y, 3);
        }

    }
}
