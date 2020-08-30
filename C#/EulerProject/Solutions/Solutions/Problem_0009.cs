using Solutions.Helpers;

namespace Solutions.Solutions
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// a² + b² = c²
    /// For example, 3² + 4² = 9 + 16 = 25 = 5².
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public static class Problem_0009
    {
        public static int Solve()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    for (int c = b + 1; c < 1000; c++)
                    {
                        if (a + b + c != 1000)
                            continue;

                        if (Geometry.IsPythagoreanTriplet(a, b, c))
                            return a * b * c;
                    }
                }
            }

            return 0;
        }
    }
}
