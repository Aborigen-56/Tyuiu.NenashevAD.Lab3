namespace SolveArray.Lib
{
    public class Array
    {
        public int CalculateMinimum(int[] numbers)
        {
            return numbers.Min();
        }

        public int CalculateMaximum(int[] numbers)
        {
            return numbers.Max();
        }

        public double CalculateAverage(int[] numbers)
        {
            return numbers.Average();
        }

        public double CalculateMedian(int[] numbers)
        {
            numbers = numbers.OrderBy(n => n).ToArray();
            int mid = numbers.Length / 2;
            return (numbers.Length % 2 != 0) ? numbers[mid] : (numbers[mid - 1] + numbers[mid]) / 2.0;
        }

        public int CalculateNumberOfEven(int[] numbers)
        {
            return numbers.Count(n => n % 2 == 0);
        }

        public int CalculateNumberOfOdd(int[] numbers)
        {
            return numbers.Count(n => n % 2 != 0);
        }

        public int SignsOfDivisibilityByTwo(int[] numbers)
        {
            return numbers.Count(n => n % 2 == 0);
        }

        public int SignsOfDivisibilityByThree(int[] numbers)
        {
            return numbers.Count(n => n % 3 == 0);
        }

        public int SignsOfDivisibilityByFive(int[] numbers)
        {
            return numbers.Count(n => n % 5 == 0);
        }

        public int SignsOfDivisibilityByTen(int[] numbers)
        {
            return numbers.Count(n => n % 10 == 0);
        }
    }
}
