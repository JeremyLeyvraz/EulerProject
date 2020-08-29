using System.Collections.Generic;

namespace Solutions.Helpers
{
    /// <summary>
    /// Methods about prime numbers
    /// </summary>
    public static class PrimeNumber
    {
        /// <summary>
        /// Determine if x is a prime number
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True if x is a prime number, false otherwise</returns>
        public static bool IsAPrimeNumber(int x)
        {
            if (x < 2)
                return false;

            double middle = x / 2.0;

            for (int i = 2; i < middle; i++)
            {
                var quotient = x / (double)i;
                if (quotient % 1 == 0)
                    return false;
            }

            return true;
        }

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
                if (!IsAPrimeNumber(i))
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
