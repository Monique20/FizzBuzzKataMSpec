using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzMSpec
{
    public class FizzBuzz
    {
        private const int MaxPrime = 97;

        public string FizzBuzzer(int number)
        {
            if (InputIsDivisibleByThree(number) && InputIsDivisibleByFive(number))
            {
                return "FizzBuzz";
            }

            if (InputIsDivisibleByFive(number))
            {
                return "Buzz" + WhizSuffix(number);
            }

            if (InputIsDivisibleByThree(number))
            {
                return "Fizz" + WhizSuffix(number);
            }

            return IsPrimeNumber(number) ? WhizSuffix(number) : InputAsString(number);
        }

        private static string InputAsString(int number)
        {
            return number.ToString();
        }

        private string WhizSuffix(int number)
        {
            if (IsPrimeNumber(number))
            {
                return "Whiz";
            }

            return string.Empty;
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number > MaxPrime)
            {
                return false;
            }

            return Enumerable.Range(1, number)
                .Where(x => number % x == 0)
                .SequenceEqual(new[] { 1, number });
        }

        private static bool InputIsDivisibleByFive(int input)
        {
            return input % 5 == 0;
        }

        private static bool InputIsDivisibleByThree(int input)
        {
            return input % 3 == 0;
        }
    }
}
