using System;
using System.Collections.Generic;

namespace _11_miscellaneous
{
    public class _01_Basic
    {
        void CreateTuple()
        {
            var empInfo = new Tuple<int, string, string, DateTime, bool>(1, "Elliot", "One", DateTime.Now, false);
            Console.WriteLine(empInfo.ToString());

            var nestedTuple = new Tuple<int, string, string, string,
                Tuple<double, double, double, double>>(
                    1, "Hello", "B", "C",
                    Tuple.Create(12.1, 14.2, 15.4, 20.0));

            var listTuple = new List<(int, string, bool, int)>();

            listTuple.Add((1, "Hello", true, 2));
            listTuple.Add((4, "World", false, 125));
            listTuple.Add((114, "Me", true, 45));
        }

        void UseTupleWithMethod(Tuple<int, string, bool> data)
        {
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item2);
            Console.WriteLine(data.Item3);

            //Value Tuple
            var my = (myStringData: "Hello", IsOk: true, Name: "Elliot");

            //Nested Value Tuple
            var first = (firstVal: "Hello", secondVal: true, thirdVal: false, fouthVal: 'V');
            var second = (data1: "ABC", data2: first, data3: 233);
        }

        Tuple<int, string, int, double> UseTupleWithMethod2((int, bool) data)
        {
            var info = new Tuple<int, string, int, double>(1, "Data", 2, 2.41);
            return info;
        }
    }
}
