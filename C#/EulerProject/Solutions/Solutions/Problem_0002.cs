﻿namespace Solutions.Solutions
{
    /// <summary>
    /// Even Fibonacci numbers
    /// 
    /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. 
    /// By starting with 1 and 2, the first 10 terms will be:
    /// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
    /// 
    /// By considering the terms in the Fibonacci sequence whose values do not exceed four million, 
    /// find the sum of the even-valued terms.
    /// 
    /// </summary>
    public static class Problem_0002
    {
        public static int Solve()
        {
            int firstTerm = 1;
            int secondTerm = 2;
            int currentTerm = firstTerm + secondTerm;
            int sum = 2;

            do
            {
                if (currentTerm % 2 == 0)
                    sum += currentTerm;

                var save = currentTerm;
                currentTerm += secondTerm;
                secondTerm = save;
            }
            while (currentTerm <= 4000000);

            return sum;
        }
    }
}