using System;
using System.Collections.Generic;
using System.Text;

namespace MoreSolving
{
    public class Solver
    {
        public int Sum(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;

            }
            return total;
        }

        public int SumEvens(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            return total;
        }

        public double AverageEvens(int[] numbers)
        {
            int sumEvens = SumEvens(numbers);
            int countEvens = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    countEvens += 1;
                }
            }
            return sumEvens / countEvens;
        }

        public bool isSumOdd(List<int> numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                if (sum % 2 != 0)
                {
                    return true;
                }
                return false;
            }
        }   

        public int SumNegativeNumbers(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    total += number;
                }
            }
            return total;
        }

        public bool ContainsTrue(bool[] values)
        {
            foreach (bool value in values)
            {
                if (value)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsEven(int[] numbers)
        {
            foreach (bool value in values)
            {
                return true;
            }
        }
        return false

        public string[] MakeElementsUppercase(string[] values)
        {
            if (values == null)
            {
                return null;
            }

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].ToUpper();
            }

            return values;
        }
        bool ContainsAFalse(bool[] vals)
        {

        }
        decimal LastElementMinusFirstElement(decimal[] nums)
        {
            if (nums == null)
            {
                return 0;
            }
            if (nums.Length == 0)
            {
                return 0;
            }
        }
        public static bool containsEven (int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers % 2 = 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
