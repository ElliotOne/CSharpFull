using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _11_Loop_While
    {
        void SimpleMethod()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
                if (i==8)
                {
                    break;
                }
            }

            i = 10;
            while (i > 0)
            {
                Console.WriteLine(i*2);
                i--;
            }

            i = 1;
            do
            {
                Console.WriteLine("Executes at least one time");
                i++;
            } while (i < 1);
        }
    }
}
