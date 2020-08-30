using System.Collections.Generic;
using System.Linq;
using Solutions.Extensions;

namespace Solutions.Solutions
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    /// 
    /// What is the 10 001st prime number?
    /// </summary>
    public static class Problem_0007
    {
        public static int Solve()
        {
            var primeNumbers = new List<int> { 2, 3, 5, 7, 11, 13 };
            var current = 17;

            while (primeNumbers.Count() != 10001)
            {
                if (current.IsAPrimeNumber())
                    primeNumbers.Add(current);

                current += 2;
            }

            return primeNumbers.Last();
        }
    }
}
