using System;

namespace _01_Basic
{
    class _15_NullableTypes
    {
        void SimpleMethod()
        {
            //? : nullable mark
            DateTime? date = null;
            int? num1 = null;
            double? num2 = null;

            //Error:
            //int num3 = null;

            //If the data before ?? is NOT null, use it. Otherwise, use the data after ??.
            Console.WriteLine(num1 ?? 3);
        }
    }
}
