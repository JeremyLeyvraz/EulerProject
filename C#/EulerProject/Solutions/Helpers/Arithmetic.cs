using System.Collections.Generic;

namespace Solutions.Helpers
{
    /// <summary>
    /// Arithmetic methods
    /// </summary>
    public static class Arithmetic
    {
        /// <summary>
        /// Get the product of the integer in the list
        /// </summary>
        /// <param name="factors">List of factors</param>
        /// <returns>The product of all factors</returns>
        public static ulong GetProductOf(IList<ulong> factors)
        {
            ulong product = 1;

            foreach (ulong factor in factors)
                product *= factor;

            return product;
        }

        /// <summary>
        /// Get the product of the integer in the list
        /// </summary>
        /// <param name="factors">List of factors</param>
        /// <returns>The product of all factors</returns>
        public static int GetProductOf(IList<int> factors)
        {
            int product = 1;

            foreach (int factor in factors)
                product *= factor;

            return product;
        }
    }
}
