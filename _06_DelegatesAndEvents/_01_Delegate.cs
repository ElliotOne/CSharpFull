using System;
using System.Collections.Generic;

namespace _06_DelegatesAndEvents
{
    public delegate void MyMethodDelegate();
    public delegate void MyMethodDelegate2(string str);
    public delegate void MyMethodDelegate3(string str, int num);

    public delegate void MyDictionaryDelegate(Dictionary<int, string> dict);
    public delegate void SayHiDelegate();
    public class _01_Delegate
    {
        void ThisIsMain()
        {
            MyMethodDelegate myDel = new MyMethodDelegate(MyMethod);
            myDel.Invoke();

            MyMethodDelegate2 myDel2 = new MyMethodDelegate2(MyMethod);
            myDel2.Invoke("Hello");

            MyMethodDelegate3 myDel3 = new MyMethodDelegate3(MyMethod);
            myDel3.Invoke("Hello", 1);

            Console.WriteLine(myDel3.Method);

            foreach (var item in myDel3.Method.GetParameters())
            {
                Console.WriteLine(item.ParameterType + " " + item.Name);
            }

            MyDictionaryDelegate dicDel = new MyDictionaryDelegate(DictionaryMethod);
            Dictionary<int, string> data = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                data.Add(i, $"val{i}");
            }
            dicDel.Invoke(data);

            SayHiDelegate sayHi = new SayHiDelegate(SayHi1);
            sayHi += SayHi2; // = new sayHiDelegate(sayHi2);
            sayHi += SayHi3;
            sayHi += SayHi4;
        }

        public static void MyMethod()
        {
            Console.WriteLine("HelloWorld");
        }

        public static void MyMethod(string str)
        {
            Console.WriteLine(str);
        }
        public static void MyMethod(string str, int num)
        {
            Console.WriteLine(str + " " + num);
        }


        public static void MyMethod(int num)
        {
            Console.WriteLine(num);
        }

        public static void DictionaryMethod(Dictionary<int, string> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        public void SayHi1()
        {
            Console.WriteLine("Hello");
        }
        public void SayHi2()
        {
            Console.WriteLine("Hi");
        }
        public void SayHi3()
        {
            Console.WriteLine("Helllllooooo");
        }
        public void SayHi4()
        {
            Console.WriteLine("Hiiiii");
        }
    }
}
