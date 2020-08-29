using System.Linq;
using Solutions.Helpers;

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
            var primeFactor = PrimeNumber.PrimeDecomposition(argument);
            return primeFactor.LastOrDefault();
        }
    }
}
