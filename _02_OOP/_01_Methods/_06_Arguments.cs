using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._01_Methods
{
    class _06_Arguments
    {
        //Optional Arguments
        void MyMethod(string data,int number = 2)
        {
            Console.WriteLine(number);
        }

        void ThisIsMain()
        {
            otherClass.otherMethod(text: "string", myBool: true, num: 1);

            otherClass.GenericArgument<string>("hello", 123);
        }
    }

    class otherClass
    {
        //Named Arguments
        public static void otherMethod(int num,string text,bool myBool)
        {
            Console.WriteLine(num +" " + text + " " + myBool);
        }

        //Generic Argument
        public static void GenericArgument<T>(T data,int number)
        {
            Console.WriteLine(data);
        }
    }
}
