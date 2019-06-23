using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    class _10_Indexers
    {
        void SimpleMethod()
        {
            IndexersClass myObj = new IndexersClass();
            myObj[0] = "Hello";
            myObj[2] = "World";
            myObj[1] = "Data";
            Console.WriteLine(myObj[1]);
        }
    }

    class IndexersClass
    {
        private string[] name = new string[100];

        public string this[int index]
        {
            get { return name[index]; }
            set { name[index] = value; }
        }
    }
}
