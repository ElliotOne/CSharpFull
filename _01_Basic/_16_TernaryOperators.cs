using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    class _16_TernaryOperators
    {
        void SimpleMethod()
        {
            if (otherMethod())
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            //Ternary Operator
            //condition ? if true : if false
            Console.WriteLine(otherMethod() ? "True":"False");
        }
        bool otherMethod()
        {
            return false;
        }
    }
}
