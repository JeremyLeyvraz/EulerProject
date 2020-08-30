namespace Solutions.Extensions
{
    /// <summary>
    /// Extension methods on ulong number
    /// </summary>
    public static class UlongExtensions
    {
        /// <summary>
        /// Determine if x is divisible by y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>True if x is divide by y, false otherwise</returns>
        public static bool IsDivideBy(this ulong x, ulong y)
        {
            var quotient = x / (double)y;
            return quotient.IsInteger();
        }
    }
}
