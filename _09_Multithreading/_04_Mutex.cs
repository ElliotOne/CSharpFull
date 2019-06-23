using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Multithreading
{
    class _04_Mutex
    {
        private static Mutex mut = new Mutex();
        public static void StartProcess()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(new ThreadStart(delegate ()
                {
                    //for (int j = 0; j < 1; j++)
                    //{
                    //    UseResource();   
                    //}
                    for (int j = 0; j < 2; j++)
                    {
                        UseResource();
                    }
                }));
                thread.Name = string.Format("(Thread no. {0})", i + 1);
                thread.Start();
            }
        }

        private static void UseResource()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is requesting the mutex.");
            mut.WaitOne();

            Console.WriteLine($"{Thread.CurrentThread.Name} has enterd the critical section.");
            Thread.Sleep(10000);
            Console.WriteLine($"{Thread.CurrentThread.Name} is leaving the critical section.");
            mut.ReleaseMutex();

            Console.WriteLine($"{Thread.CurrentThread.Name} has released the mutex.");

        }
    }
}
