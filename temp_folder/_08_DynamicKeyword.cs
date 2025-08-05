using System;

namespace _11_Miscellaneous
{
    class _08_DynamicKeyword
    {
        void ThisIsMAin()
        {
            dynamic value = 0;
            Console.WriteLine("Value = " + value);
            value = "Hello";
            Console.WriteLine("Value = " + value);
            value = new DynamicClassEx();
            value.Name = "Name!";
        }
    }

    class DynamicClassEx
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
