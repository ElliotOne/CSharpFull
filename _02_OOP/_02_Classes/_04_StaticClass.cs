using System;

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

    class AnotherClass2
    {
        //Error : can't be instantiated and inherited
        //_04_StaticClass first = new _04_StaticClass();

        public void AnotherMethod()
        {
            _04_StaticClass.SimpleMethod();
        }
    }
}
