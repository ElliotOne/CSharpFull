using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _14_YeildKeyword
    {
        void ThisIsMain()
        {
            foreach (var item in PerformMathOperations(10,5))
            {
                Console.WriteLine(item);
            }

        }
        IEnumerable<double> PerformMathOperations(int x, int y)
        {
            yield return x + y;
            yield return x * y;
            yield return Math.Round(((double)x / (double)y),2);
            yield return x - y;
        }
    }
}
