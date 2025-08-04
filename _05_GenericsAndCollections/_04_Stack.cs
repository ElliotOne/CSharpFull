using System;
using System.Collections;
using System.Collections.Generic;

namespace _05_GenericsAndCollections
{
    class _04_Stack
    {
        void NonGenericStack()
        {
            Stack stack = new Stack();

            stack.Push("Hello");
            stack.Push("Elliot");
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
            stack.Push("Elliot");
            stack.Push("Hello2");
            stack.Pop();

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
