using System.Collections.Generic;
using System.Linq;

namespace Solutions.Solutions
{
    /// <summary>
    /// Multiple of 3 and 5
    /// 
    /// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
    /// Find the sum of all the multiples of 3 or 5 below 1000.
    /// 
    /// </summary>
    public static class Problem_0001
    {
        public static int Solve(int threshold, IEnumerable<int> listOfDivider)
        {
            int sum = 0;

            for(int i = 3; i < threshold; i++)
            {
                if (listOfDivider.Any(x => i % x == 0))
                    sum += i;
            }

            return sum;
        }
    }
}
