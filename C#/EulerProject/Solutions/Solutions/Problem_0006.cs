namespace Solutions.Solutions
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is:
    /// 1² + 2² + 3² + ... + 9² + 10² = 385
    /// 
    /// The square of the sum of the first ten natural numbers is:
    /// (1 + 2 + 3 + ... + 10)² = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is:
    /// 3025 - 385 = 2640
    /// 
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public static class Problem_0006
    {
        public static int Solve()
        {
            var x = 100;
            var sumOfSquares = 0;
            var sumOfNumber = 0;

            for (int i = 1; i <= x; i++)
            {
                sumOfNumber += i;
                sumOfSquares += i * i;
            }

            return sumOfNumber * sumOfNumber - sumOfSquares;
        }
    }
}
