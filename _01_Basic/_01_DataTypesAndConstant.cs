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
        bool isHappy = true;

        int minInt = int.MinValue;
        double maxDouble = double.MaxValue;

        bool isIntPrimitiveType = typeof(int).IsPrimitive;

        const double PI = 3.14;
    }
}
