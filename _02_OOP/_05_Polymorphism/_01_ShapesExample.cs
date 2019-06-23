using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._05_Polymorphism
{
    public class _01_ShapesExample
    {
        public virtual void Draw()
        {
            Console.WriteLine("This is a simple shape!");
        }
    }
    public class Circle:_01_ShapesExample
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple circle.");
        }
    }
    public class Square : _01_ShapesExample
    {
        public override void Draw()
        {
            Console.WriteLine("This is a simple square.");
        }
    }

    public class Rectangle : _01_ShapesExample
    {
        public new void Draw()
        {
            Console.WriteLine("This is a simple rectangle.");
        }
    }

}
