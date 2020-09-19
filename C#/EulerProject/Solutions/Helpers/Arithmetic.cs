using System;
using System.Collections.Generic;
using System.Linq;
using Solutions.Extensions;

namespace Solutions.Helpers
{
    /// <summary>
    /// Arithmetic methods
    /// </summary>
    public static class Arithmetic
    {
        /// <summary>
        /// Get the product of the integer in the list
        /// </summary>
        /// <param name="factors">List of factors</param>
        /// <returns>The product of all factors</returns>
        public static ulong GetProductOf(IList<ulong> factors)
        {
            ulong product = 1;

            foreach (ulong factor in factors)
                product *= factor;

            return product;
        }

        /// <summary>
        /// Get the product of the integer in the list
        /// </summary>
        /// <param name="factors">List of factors</param>
        /// <returns>The product of all factors</returns>
        public static int GetProductOf(IList<int> factors)
        {
            int product = 1;

            foreach (int factor in factors)
                product *= factor;

            return product;
        }

        /// <summary>
        /// Apply the sieve of Eratosthene
        /// </summary>
        /// <param name="n">Max value of prime number</param>
        /// <returns>List of all prime numbers under the max value passed in parameter</returns>
        public static IList<ulong> ApplySieveOfEratosthenes(ulong n)
        {
            var maxNumberToCheck = Math.Sqrt(n);

            var numberList = new List<ulong>();

            for (ulong i = 2; i <= n; i++)
            {
                numberList.Add(i);
            }

            for (ulong i = 2; i <= maxNumberToCheck; i++)
            {
                numberList = numberList.Where(x => x <= i || !x.IsDivideBy(i)).ToList();
            }

            return numberList;
        }

        /// <summary>
        /// Get the sum from one to the number passed in parameter
        /// </summary>
        /// <param name="max">Max threshold to calculate the sum</param>
        /// <returns>The sum from one to max. Zero if max < 1</returns>
        public static int GetSumFromOneTo(int max)
        {
            var sum = 0;
            for (int i = 1; i <= max; i++)
                sum += i;

            return sum;
        }

        /// <summary>
        /// Get divisors of a number
        /// </summary>
        /// <param name="number">Number to get the divisors</param>
        /// <returns></returns>
        public static IList<int> GetDivisorOf(int number)
        {
            var divisors = new List<int>();
            if (number <= 0)
                return divisors;

            int current = 1;
            int max = number;
            divisors.Add(1);
            if (number != 1)
            {
                divisors.Add(number);
            }

            current++;
            while (current < max)
            {
                if (number % current == 0)
                {
                    divisors.Add(current);
                    max = number / current;
                    if (max != current)
                        divisors.Add(max);
                }
                current++;
            }
            return divisors;
        }

    }
}
