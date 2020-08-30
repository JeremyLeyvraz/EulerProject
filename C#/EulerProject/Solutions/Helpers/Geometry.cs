namespace Solutions.Helpers
{
    /// <summary>
    /// Geometric methods
    /// </summary>
    public static class Geometry
    {
        /// <summary>
        /// Determine if three integers are a pythagorian triplet
        /// e.g. a² + b² = c²
        /// </summary>
        /// <param name="a">First term</param>
        /// <param name="b">Second term</param>
        /// <param name="c">Result term</param>
        /// <returns>True if integers are a pythagorian triplet, false otherwise</returns>
        public static bool IsPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}
