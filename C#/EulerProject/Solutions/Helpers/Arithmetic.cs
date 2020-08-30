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
    }
}
