using System;
using System.Collections.Generic;

namespace _11_Miscellaneous
{
    class _14_YieldKeyword
    {
        void ThisIsMain()
        {
            foreach (var item in PerformMathOperations(10, 5))
            {
                Console.WriteLine(item);
            }

        }
        IEnumerable<double> PerformMathOperations(int x, int y)
        {
            yield return x + y;
            yield return x * y;
            yield return Math.Round(((double)x / (double)y), 2);
            yield return x - y;
        }
    }
}
