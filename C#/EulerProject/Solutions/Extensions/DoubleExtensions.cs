namespace Solutions.Extensions
{
    /// <summary>
    /// Extension methods on double number
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Determine if a double is also an integer
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True if x is an integer, false otherwise</returns>
        public static bool IsInteger(this double x)
        {
            return x % 1 == 0;
        }
    }
}
