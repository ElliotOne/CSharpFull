using System;

namespace _01_Basic
{
    public class _13_Random
    {
        void SimpleMethod()
        {
            Random rand = new Random();
            int x = 0;
            x = rand.Next();
            int y = 0;
            y = rand.Next(150, int.MaxValue);
        }
    }
}
