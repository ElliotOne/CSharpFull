using System;

namespace _02_OOP._01_Methods
{
    class _07_ParamsKeyword
    {
        void ThisIsMain()
        {
            otherClass2.myMethodHere(20, new string[] { "first", "second", "third" });
        }

    }

    class otherClass2
    {
        public static void myMethodHere(int data, params string[] names)
        {
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
