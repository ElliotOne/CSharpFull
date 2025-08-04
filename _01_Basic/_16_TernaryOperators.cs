using System;

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
            Console.WriteLine(otherMethod() ? "True" : "False");
        }
        bool otherMethod()
        {
            return false;
        }
    }
}
