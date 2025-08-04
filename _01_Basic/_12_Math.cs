using System;

namespace _01_Basic
{
    public class _12_Math
    {
        void SimpleMethod()
        {
            double x = 3.2521;

            //ceiling
            Console.WriteLine(Math.Ceiling(x));

            //floor
            Console.WriteLine(Math.Floor(x));

            //round
            Console.WriteLine(Math.Round(x, 2));

            //truncate
            Console.WriteLine(Math.Truncate(x));

            //Pow
            Console.WriteLine(Math.Pow(2, 3));

            int first = 16;
            int second = -4;
            Console.WriteLine(Math.Max(first, second));
            Console.WriteLine(Math.Min(first, second));
            Console.WriteLine(Math.Sqrt(first));
            Console.WriteLine(Math.Abs(second));
            Console.WriteLine(Math.PI);
        }
    }
}
