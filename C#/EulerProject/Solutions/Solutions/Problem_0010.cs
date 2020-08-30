using Solutions.Helpers;

namespace Solutions.Solutions
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// 
    /// Find the sum of all the primes below two million.
    /// </summary>
    public static class Problem_0010
    {
        public static ulong Solve()
        {
            ulong maxThreshold = 2000000;
            ulong sum = 0;

            var primeNumbers = Arithmetic.ApplySieveOfEratosthenes(maxThreshold);

            foreach (var primeNumber in primeNumbers)
            {
                sum += primeNumber;
            }

            return sum;
        }
    }
}
