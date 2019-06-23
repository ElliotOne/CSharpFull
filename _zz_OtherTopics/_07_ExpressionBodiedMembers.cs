using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _07_ExpressionBodiedMembers
    {
        void ThisIsMain()
        {

        }

        //Expression bodied method
        public int AddNumbers(int x, int y) => x + y;
        public void SayHi() => Console.WriteLine("Hello");
    }

    class ExpressionBodiedClass
    {
        private int age;
        public int Age
        {
            get => age;
            set => age = value;
        }

        public ExpressionBodiedClass() => Console.WriteLine("Constarctor is here!");
    }
}
