using SolveArray.Lib;
using Array = SolveArray.Lib.Array;

namespace SolveArray.Test
{
    [TestClass]
    public class ValidArray
    {
        [TestMethod]
        public void TestCalculateMinimum()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9 };
            Assert.AreEqual(array.CalculateMinimum(numbers), 1);
        }

        [TestMethod]
        public void TestCalculateMaximum()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9 };
            Assert.AreEqual(array.CalculateMaximum(numbers), 9);
        }

        [TestMethod]
        public void TestCalculateAverage()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9 };
            Assert.AreEqual(array.CalculateAverage(numbers), 5.2, 0.001);
        }

        [TestMethod]
        public void TestCalculateMedian()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9 };
            Assert.AreEqual(array.CalculateMedian(numbers), 5.0, 0.001);
        }

        [TestMethod]
        public void TestCalculateNumberOfEven()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2 };
            Assert.AreEqual(array.CalculateNumberOfEven(numbers), 2);
        }

        [TestMethod]
        public void TestCalculateNumberOfOdd()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2 };
            Assert.AreEqual(array.CalculateNumberOfOdd(numbers), 4);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByTwo()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2 };
            Assert.AreEqual(array.SignsOfDivisibilityByTwo(numbers), 2);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByThree()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2 };
            Assert.AreEqual(array.SignsOfDivisibilityByThree(numbers), 2);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByFive()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2 };
            Assert.AreEqual(array.SignsOfDivisibilityByFive(numbers), 1);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByTen()
        {
            Array array = new Array();
            int[] numbers = { 5, 3, 8, 1, 9, 2, 10 };
            Assert.AreEqual(array.SignsOfDivisibilityByTen(numbers), 1);
        }
    }
}