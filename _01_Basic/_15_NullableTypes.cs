using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            //?? : if null the data before ?? , else after 
            Console.WriteLine(num1 ?? 3);
        }
    } 
}
