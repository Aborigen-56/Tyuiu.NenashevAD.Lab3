namespace SolveCalculate.Lib
{
    public class Calculate
    {
        public double CalculateSumma(double a, double b)
        {
            return a + b;
        }

        public double CalculateDifference(double a, double b)
        {
            return a - b;
        }

        public double CalculateMultiplication(double a, double b)
        {
            return a * b;
        }

        public double CalculateQuotient(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Деление на ноль невозможно");
            }
            return a / b;
        }
    }
}
