using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _08_DynamicKeyword
    {
        void ThisIsMAin()
        {
            dynamic value = 0;
            Console.WriteLine("Value = " + value);
            value = "Hello";
            Console.WriteLine("Value = " + value);
            value = new dynamicClassEx();
            value.Name = "Name!";
        }
    }

    class dynamicClassEx
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
