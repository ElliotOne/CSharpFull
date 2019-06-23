using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Add NameSpace
using myNameSpace;

namespace _02_OOP._02_Classes
{
    class _06_NameSpaces
    {
        void anotherMethod()
        {
            myNameSpace.myCusomeClass myObj = new myNameSpace.myCusomeClass();
            myCusomeClass myObj2 = new myCusomeClass();
            myObj2.SayHi();
        }
    }
}

namespace myNameSpace
{
    public class myCusomeClass
    {
        public string animalColor;
        public void SayHi()
        {
            Console.WriteLine("Hello form myNameSpace!");
        }
    }
}
