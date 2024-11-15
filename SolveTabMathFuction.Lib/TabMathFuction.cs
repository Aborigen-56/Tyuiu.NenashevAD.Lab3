namespace SolveTabMathFuction.Lib
{
    public class TabMathFuction
    {
        public double[] CalculateTabMathFuction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double f;
                try
                {
                    double denominator1 = Math.Pow(3, x);
                    double denominator2 = Math.Pow(5, x);

                    if (denominator1 == 0 || denominator2 == 0)
                    {
                        throw new DivideByZeroException("Деление на ноль");
                    }

                    f = x + Math.Exp(x) + (Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / denominator1 + Math.Pow(x, 5) / denominator2;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    f = double.NaN;
                }

                valueArray[count] = Math.Round(f, 2);
                count++;
            }

            return valueArray;
        }
    }
}
