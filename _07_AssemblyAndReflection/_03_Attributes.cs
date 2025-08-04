using System;

namespace _07_AssemblyAndReflection
{
    class _03_Attributes
    {
        void ThisIsMain()
        {
            Persons.SayHi();
            Persons.SayHello();
        }
    }

    class Persons
    {
        [Obsolete("Use sayHello() instead.")]
        public static void SayHi()
        {
            Console.WriteLine("Old Method");
        }
        public static void SayHello()
        {
            Console.WriteLine("New Method");
        }
    }
}

