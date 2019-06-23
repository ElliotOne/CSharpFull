using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AssemblyAndReflection
{
    class _03_Attributes
    {
        void ThisIsMain()
        {
            Persons.sayHi();
            Persons.sayHello();
        }
    }

    class Persons
    {
        [Obsolete("Use sayHello() instead.")]
        public static void sayHi()
        {
            Console.WriteLine("Old Method");
        }
        public static void sayHello()
        {
            Console.WriteLine("New Method");
        }
    }
}

