using System.Collections.Generic;
using System.Linq;
using Solutions.Extensions;

namespace Solutions.Solutions
{
    /// <summary>
    /// A palindromic number reads the same both ways. 
    /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// 
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public static class Problem_0004
    {
        public static int Solve()
        {
            int maxDigit = 999;
            var palindromes = new List<int>();

            for (int i = 100; i <= maxDigit; i++)
            {
                for (int j = i; j <= maxDigit; j++)
                {
                    var product = i * j;
                    if (product.IsPalindromic())
                        palindromes.Add(product);
                }
            }

            return palindromes.Max();
        }
    }
}
