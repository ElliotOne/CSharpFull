using System;

namespace _02_OOP._05_Polymorphism
{
    public abstract class _02_ShapesExample_Abstraction
    {
        public abstract void Draw();
        public void SayHi()
        {
            Console.WriteLine("Hello from the abstract class");
        }
    }

    public class Lines : _02_ShapesExample_Abstraction
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a line!");
        }
    }
}
