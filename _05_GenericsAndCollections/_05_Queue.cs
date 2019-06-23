using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    class _05_Queue
    {
        void NonGenericQueue()
        {
            Queue queue = new Queue();
            queue.Enqueue("Hello");
            queue.Enqueue(1);
            queue.Enqueue('b');
            queue.Enqueue("Good");
            Console.WriteLine(queue.Dequeue());
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            queue.Peek();
        }

        void GenericQueue()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("Good");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
