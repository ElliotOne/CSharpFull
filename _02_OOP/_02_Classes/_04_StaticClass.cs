using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    public static class _04_StaticClass
    {
        public static string data;
        public static void SimpleMethod()
        {
            Console.WriteLine("Hello form static class!");
        }
    }
    class anotheClass
    {
        //Error : can't be instatiated and inherited
        //_04_StaticClass first = new _04_StaticClass();

        public void AnotherMethod()
        {
            _04_StaticClass.SimpleMethod();
        }
    }
}
