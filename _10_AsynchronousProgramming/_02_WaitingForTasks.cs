using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _02_WaitingForTasks
    {
        public static void StartTasks()
        {
            Task t1 = new Task(() =>
            {
                Console.WriteLine("Task 1 started");
                Console.WriteLine("Task 1 running...");
                Thread.Sleep(8000);
                Console.WriteLine("Task 1 finished.");
            });
            t1.Start();
            t1.Wait();

            Task t2 = new Task(() =>
            {
                Console.WriteLine("Task 2 started");
                Console.WriteLine("Task 2 running...");
                Thread.Sleep(6000);
                Console.WriteLine("Task 2 finished.");
            });
            t2.Start();
            t2.Wait();

            //task 3 wait for task 1 and then task 2 to complete then it starts

            Task t3 = new Task(() =>
            {
                Console.WriteLine("Task 3 started");
                Console.WriteLine("Task 3 running...");
                Thread.Sleep(1500);
                Console.WriteLine("Task 3 finished.");
            });
            t3.Start();


            Task.WaitAll(t1, t2, t3);
            //then do sth after all tasks finished
        }
    }
}
