using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegatesAndEvents
{
    public delegate void myMethodDelegate();
    public delegate void myMethodDelegate2(string str);
    public delegate void myMethodDelegate3(string str, int num);

    public delegate void myDictiornayDelegate(Dictionary<int, string> dict);
    public delegate void sayHiDelegate();
    public class _01_Delegate
    {
        void ThisIsMain()
        {
            myMethodDelegate myDel = new myMethodDelegate(myMethod);
            myDel.Invoke();

            myMethodDelegate2 myDel2 = new myMethodDelegate2(myMethod);
            myDel2.Invoke("Hello");

            myMethodDelegate3 myDel3 = new myMethodDelegate3(myMethod);
            myDel3.Invoke("Hello", 1);

            Console.WriteLine(myDel3.Method);

            foreach (var item in myDel3.Method.GetParameters())
            {
                Console.WriteLine(item.ParameterType + " " + item.Name);
            }

            myDictiornayDelegate dicDel = new myDictiornayDelegate(dictionaryMethod);
            Dictionary<int, string> data = new Dictionary<int, string>();
            for (int i = 0; i < 10; i++)
            {
                data.Add(i, $"val{i}");
            }
            dicDel.Invoke(data);

            sayHiDelegate sayHi = new sayHiDelegate(sayHi1);
            sayHi += sayHi2; // = new sayHiDelegate(sayHi2);
            sayHi += sayHi3;
            sayHi += sayHi4;
        }

        public static void myMethod()
        {
            Console.WriteLine("HelloWorld");
        }

        public static void myMethod(string str)
        {
            Console.WriteLine(str);
        }
        public static void myMethod(string str,int num)
        {
            Console.WriteLine(str + " " + num);
        }


        public static void myMethod(int num)
        {
            Console.WriteLine(num);
        }

        public static void dictionaryMethod(Dictionary<int,string> dic)
        {
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }

        public void sayHi1()
        {
            Console.WriteLine("Hello");
        }
        public void sayHi2()
        {
            Console.WriteLine("Hi");
        }
        public void sayHi3()
        {
            Console.WriteLine("aloooo");
        }
        public void sayHi4()
        {
            Console.WriteLine("Salam");
        }
    }
}
