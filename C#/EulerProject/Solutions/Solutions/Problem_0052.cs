using Solutions.Extensions;

namespace Solutions.Solutions
{
    public class Problem_0052
    {
        /// <summary>
        /// It can be seen that the number, 125874, and its double, 251748, contain exactly the same digits, but in a different order.
        /// 
        /// Find the smallest positive integer x such that 2x, 3x, 4x, 5x, and 6x, contain the same digits.
        /// </summary>
        /// <returns></returns>
        public static int Solve()
        {
            int n = 1;

            int n2 = 2 * n;
            int n3 = 3 * n;
            int n4 = 4 * n;
            int n5 = 5 * n;
            int n6 = 6 * n;

            while(!n2.HasSameDigits(n) ||
                !n3.HasSameDigits(n) ||
                !n4.HasSameDigits(n) ||
                !n5.HasSameDigits(n) ||
                !n6.HasSameDigits(n))
            {
                n++;
                n2 = 2 * n;
                n3 = 3 * n;
                n4 = 4 * n;
                n5 = 5 * n;
                n6 = 6 * n;
            }

            return n;
        }
    }
}
