using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _01_Tasks
    {
        public static void StartTask()
        {
            Task task = new Task(new Action(SayHi));
            task.Start();

            Task task2 = new Task(delegate ()
            {
                Console.WriteLine("Task 2 is starting");
                Console.WriteLine("Task 2 is running");
                Console.WriteLine("Hello from task 2!");
                Thread.Sleep(4000);
                Console.WriteLine("Task 2 is complete");
            });
            task2.Start();

            Task task3 = new Task(() =>
            {
                Console.WriteLine("Task 3 is starting");
                Thread.Sleep(1000);
                Console.WriteLine("Task 3 is complete");
            });
            task3.Start();


            //Passing parameter to task
            Task task4 = new Task(new Action<object>(SayHi), "Elliot");
            task4.Start();
        }
        private static void SayHi()
        {
            Console.WriteLine("Task is starting");
            Console.WriteLine("Task is running");
            Console.WriteLine("Hello!");
            Thread.Sleep(2000);
            Console.WriteLine("Task is complete");
        }

        private static void SayHi(object name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
