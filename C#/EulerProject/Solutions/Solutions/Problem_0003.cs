using System.Collections.Generic;
using System.Linq;

namespace Solutions.Solutions
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public static class Problem_0003
    {
        public static int Solve(long argument)
        {
            var primeFactor = new List<int>();

            var middle = argument / 2.0;
            var currentQuotient = argument;

            for (int i = 2; i < middle; i++)
            {
                if (!IsPrime(i))
                    continue;

                while (currentQuotient > 1 && (currentQuotient / (double)i) % 1 == 0)
                {
                    primeFactor.Add(i);
                    currentQuotient = currentQuotient / i;
                }

                if (currentQuotient <= 1)
                    break;
            }

            return primeFactor.LastOrDefault();
        }

        /// <summary>
        /// Determine if x is prime
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True if x is prime, false otherwise</returns>
        private static bool IsPrime(int x)
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
    }
}
