using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_DelegatesAndEvents
{
    delegate void DisplayMessageDel();
    delegate int MultiplyDel(int n);
    class _04_LambdaExpressions
    {
        void ThisIsMain()
        {
            MultiplyDel multiply = delegate (int n) { return n * 2; };

            //Lambda Expression
            MultiplyDel multiply2 = n => n * 2;
            DisplayMessageDel display = () => Console.WriteLine("Hello"); ;

            List<int> list = new List<int>();

            list.Add(3);
            list.Add(1);
            list.Add(4);
            list.Add(2);
            list.Add(10);
            list.Add(7);

            var oodList = list.Where(n => n % 2 != 0).ToList();
            var evenList = list.Where(n => n % 2 == 0).ToList();
        }
    }
}
