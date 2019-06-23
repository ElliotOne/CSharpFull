using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    class _04_Stack
    {
        void NonGenericStack()
        {
            Stack stack = new Stack();
            stack.Push("Hello");
            stack.Push("Ali");
            stack.Push(2);
            stack.Push(0.1414);
            stack.Push("Hello2");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        void GenericStack()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("Ali");
            stack.Push("Hello2");
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
