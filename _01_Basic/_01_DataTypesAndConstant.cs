using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _01_DataTypesAndConstant
    {
        int num1 = 123;
        double num2 = 13.24d;
        float num3 = 145.5f;
        decimal price = 12341.4m;
        string str1 = "Hello";
        string str2 = "World";
        char ch = 'A';
        bool IsHappy = true;

        int MinInt = int.MinValue;
        double MaxDouble = double.MaxValue;

        bool isIntPrimitiveType = typeof(int).IsPrimitive;

        const double PI = 3.14;

    }
}
