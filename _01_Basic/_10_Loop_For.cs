using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _10_Loop_For
    {
        void SimpleMethod()
        {
            for (int i = 0; i <= 20 ; i++)
            {
                if (i > 5)
                {
                    Console.WriteLine($"{i} is smaller than 5");
                }
                if (i%2==0)
                {
                    Console.WriteLine($"{i} % 2 = 0");
                }
                if (i == 9)
                {
                    continue;
                }
                if (i == 15)
                {
                    break;
                }
            }
        }
    }
}
