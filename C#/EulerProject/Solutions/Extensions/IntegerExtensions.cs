namespace Solutions.Extensions
{
    /// <summary>
    /// Extension methods on integer number
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Determine if x is a palindromic integer
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True if x is a palindromic integer, false otherwise</returns>
        public static bool IsPalindromic(this int x)
        {
            var stringValue = x + "";
            var invertValue = "";

            foreach (char c in stringValue)
            {
                invertValue = invertValue.Insert(0, "" + c);
            }

            return stringValue == invertValue;
        }

        /// <summary>
        /// Determine if x is a prime number
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True if x is a prime number, false otherwise</returns>
        public static bool IsAPrimeNumber(this int x)
        {
            if (x < 2)
                return false;

            double middle = x / 2.0;

            for (int i = 2; i < middle; i++)
            {
                var quotient = x / (double)i;
                if (quotient.IsInteger())
                    return false;
            }

            return true;
        }
    }
}
