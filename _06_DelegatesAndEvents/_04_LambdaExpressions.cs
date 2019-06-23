using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegatesAndEvents
{
    delegate void diplayMessageDel();
    delegate int multiplyDel(int n);
    class _04_LambdaExpressions
    {
        void ThisIsMain()
        {
            multiplyDel multiply = delegate (int n) { return n * 2; };

            //Lamda
            multiplyDel multiply2 = n => n * 2;
            diplayMessageDel diplay = () => Console.WriteLine("Hello"); ;

            List<int> list = new List<int>();
            list.Add(3); list.Add(1);list.Add(4);
            list.Add(2); list.Add(10);list.Add(7);
            var oodList = list.Where(n => n % 2 != 0).ToList();
            var evenList = list.Where(n => n % 2 == 0).ToList();
        }
    }
}
