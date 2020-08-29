using System.Collections.Generic;
using Solutions.Extensions;

namespace Solutions.Solutions
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// 
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public static class Problem_0005
    {
        public static int Solve()
        {
            int start = 22;
            var divisors = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            do
            {
                if (CheckDivisors(start, divisors))
                    return start;

                start += 2;
            }
            while (true);
        }

        /// <summary>
        /// Determine if x is divisible by all integers in a list
        /// </summary>
        /// <param name="x">Number to divide</param>
        /// <param name="divisors">List of divisors to check</param>
        /// <returns>True if x is divisible by all integers in the list, false otherwise</returns>
        private static bool CheckDivisors(int x, IEnumerable<int> divisors)
        {
            foreach (var divisor in divisors)
            {
                var quotient = x / (double)divisor;
                if (!quotient.IsInteger())
                    return false;
            }

            return true;
        }
    }
}
