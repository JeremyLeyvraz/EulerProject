using System.Numerics;

namespace Solutions.Solutions
{
    public class Problem_0025
    {
        /// <summary>
        /// The Fibonacci sequence is defined by the recurrence relation:
        /// Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
        /// 
        /// What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
        /// </summary>
        /// <returns></returns>
        public static int Solve()
        {
            BigInteger f1 = 1;
            BigInteger f2 = 1;
            BigInteger f3 = 0;
            int index = 2;
            
            while((f3 + "").Length < 1000)
            {
                index++;
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }

            return index;
        }

    }
}
