using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Multithreading
{
    class _01_Basic
    {
        static Thread t1;
        static Thread t2;

        public static void StartThreads()
        {
            t1 = new Thread(new ThreadStart(SayHi));
            t1.Name = "Thread 1 (SayHi)";
            t1.Start();

            t2 = new Thread(new ThreadStart(SayHi2));
            t2.Name = "Thread 2 (SayHi2)";
            t2.Start();


            Thread t3 = new Thread(new ThreadStart(() => Console.WriteLine("Hello form lambda expression")));
            t3.Start();

            Thread t4 = new Thread(new ThreadStart(delegate ()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello form anonymous method!");
                }
            }));
            t4.Start();
        }
        public static void SayHi()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                //Thread.Sleep(500);
                //if (i == 40)
                //{
                //    Console.WriteLine("Exiting thread 1 ....");
                //    t1.Abort();
                //}
                t2.Join();
                Console.WriteLine("Hi ...");
            }
        }

        public static void SayHi2()
        {
            Console.WriteLine("Starting to execute " + Thread.CurrentThread.Name);
            for (int i = 0; i < 50; i++)
            {
                Thread.Sleep(new TimeSpan(0, 0, 1));
                Console.WriteLine("Hello...");
            }
        }
    }
}
