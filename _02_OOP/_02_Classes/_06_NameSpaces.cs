using System;


//Add NameSpace
using myNameSpace;

namespace _02_OOP._02_Classes
{
    class _06_NameSpaces
    {
        void AnotherMethod()
        {
            myNameSpace.MyCustomClass myObj = new myNameSpace.MyCustomClass();
            MyCustomClass myObj2 = new MyCustomClass();
            myObj2.SayHi();
        }
    }
}

namespace myNameSpace
{
    public class MyCustomClass
    {
        public string AnimalColor;
        public void SayHi()
        {
            Console.WriteLine("Hello form myNameSpace!");
        }
    }
}
