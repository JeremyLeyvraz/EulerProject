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
                if (x.IsDivideBy(i))
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Determine if x is divisible by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True if x is divide by y, false otherwise</returns>
        public static bool IsDivideBy(this int x, int y)
        {
            var quotient = x / (double)y;
            return quotient.IsInteger();
        }

        /// <summary>
        /// Determine if x and y have the same digits
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static bool HasSameDigits(this int x, int y)
        {
            var xString = x + "";
            var yString = y + "";

            if (xString.Length != yString.Length)
                return false;

            foreach(char c in xString)
            {
                if (!yString.Contains(c + ""))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
