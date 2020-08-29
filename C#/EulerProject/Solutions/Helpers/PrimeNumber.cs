using System.Collections.Generic;
using Solutions.Extensions;

namespace Solutions.Helpers
{
    /// <summary>
    /// Methods about prime numbers
    /// </summary>
    public static class PrimeNumber
    {
        /// <summary>
        /// Get the decomposition of x in prime factors
        /// </summary>
        /// <param name="x"></param>
        /// <returns>List of prime factor of x</returns>
        public static IList<int> PrimeDecomposition(long x)
        {
            var primeFactor = new List<int>();

            var middle = x / 2.0;
            var currentQuotient = x;

            for (int i = 2; i < middle; i++)
            {
                if (!i.IsAPrimeNumber())
                    continue;

                while (currentQuotient > 1 && (currentQuotient / (double)i) % 1 == 0)
                {
                    primeFactor.Add(i);
                    currentQuotient = currentQuotient / i;
                }

                if (currentQuotient <= 1)
                    break;
            }

            return primeFactor;
        }
    }
}
