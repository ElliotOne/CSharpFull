﻿namespace _02_OOP._01_Methods
{
    class _05_RecursiveMethods
    {
        int Factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
