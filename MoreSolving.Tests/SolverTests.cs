using System;
using System.Collections.Generic;
using Xunit;

namespace MoreSolving.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -15)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, 3)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void Sum(int[] numbers, int expected)
        {
            // Arrange
            var solver = new Solver();

            // Act
            int actual = solver.Sum(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -6)]
        [InlineData(new int[] { 1, -2, 3, -4, 5 }, -6)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void SumEvens(int[] numbers, int expected)
        {
            // Arrange
            var solver = new Solver();

            // Act
            int actual = solver.SumEvens(numbers);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -3)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, 2.6666666666)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, -2.6666666666)]
        [InlineData(new int[] { 1, -2, 2, 3, -4 }, -1.3333333333)]
        [InlineData(new int[] { 1, 3, 5, 7 }, 0)]
        [InlineData(new int[] { 0, 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void AverageEvens(int[] numbers, double expected)
        {
            // Arrange
            var solver = new Solver();

            // Act
            double actual = solver.AverageEvens(numbers);

            // Assert
            Assert.Equal(Math.Round(expected, 5), Math.Round(actual, 5));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, true)]
        [InlineData(new int[] { 1, 2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, -2, -2, 3, -4 }, false)]
        [InlineData(new int[] { 1, -2, 2, 3, 4 }, false)]
        [InlineData(new int[] { 1, 3, 5, 7, 9 }, true)]
        [InlineData(new int[] { 1, 3, 5, 8 }, true)]
        [InlineData(new int[] { 10, 10, 10, 10 }, false)]
        [InlineData(new int[] { 0, 1, 0 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void IsSumOdd(int[] numbers, bool expected)
        {
            // Arrange
            var solver = new Solver();
            var numbersList = numbers == null ? null : new List<int>(numbers);

            // Act
            bool actual = solver.IsSumOdd(numbersList);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, 0)]
        [InlineData(new int[] { 5, 10, 15 }, 0)]
        [InlineData(new int[] { -1, -1, -1 }, -3)]
        [InlineData(new int[] { -5, -10, -15 }, -30)]
        [InlineData(new int[] { 7, -2, 5 }, -2)]
        [InlineData(new int[] { 0, 0 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(null, 0)]
        public void SumNegativeNumbers(int[] numbers, int expectedSum)
        {
            // Arrange
            var solver = new Solver();

            // Act
            int actualSum = solver.SumNegativeNumbers(numbers);

            // Assert
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(new bool[] { false, false, false }, false)]
        [InlineData(new bool[] { false, false, true }, true)]
        [InlineData(new bool[] { true, false, false }, true)]
        [InlineData(new bool[] { true, true, true }, true)]
        [InlineData(new bool[] { false }, false)]
        [InlineData(new bool[] { true }, true)]
        [InlineData(new bool[] { }, false)]
        [InlineData(null, false)]
        public void ContainsTrue(bool[] values, bool expectedResult)
        {
            // Arrange
            var solver = new Solver();

            // Act
            bool actualResult = solver.ContainsTrue(values);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new int[] { 1, 1, 1 }, false)]
        [InlineData(new int[] { 2, 1, 1 }, true)]
        [InlineData(new int[] { 1, 1, 2 }, true)]
        [InlineData(new int[] { 5, 10, 15 }, true)]
        [InlineData(new int[] { -1, -1, -1 }, false)]
        [InlineData(new int[] { -5, -10, -15 }, true)]
        [InlineData(new int[] { 7, -2, 5 }, true)]
        [InlineData(new int[] { 0, 0 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(null, false)]
        public void ContainsEven(int[] numbers, bool expectedResult)
        {
            // Arrange
            var solver = new Solver();

            // Act
            bool actualResult = solver.ContainsEven(numbers);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(new string[] { "abc" }, new string[] { "ABC" })]
        [InlineData(new string[] { "abc", "Def", "GHi" }, new string[] { "ABC", "DEF", "GHI" })]
        [InlineData(new string[] { "a" }, new string[] { "A" })]
        [InlineData(new string[] { "", "", "" }, new string[] { "", "", "" })]
        [InlineData(new string[] { "abc", null, "" }, new string[] { "ABC", null, "" })]
        [InlineData(new string[] { null, null, null }, new string[] { null, null, null })]
        [InlineData(null, null)]
        public void MakeElementsUppercase(string[] values, string[] expectedResult)
        {
            // Arrange
            var solver = new Solver();

            // Act
            string[] actualResult = solver.MakeElementsUppercase(values);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
