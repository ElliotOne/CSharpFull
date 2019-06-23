using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Multithreading
{
    class _03_DeadlocksAndLockKeyword
    {
        public static void StartReadAndWrite()
        {
            Files file = new Files();
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(file.Write));
                threads[i].Start($"c:\\account{i}.txt");
            }
        }
    }
    class Files
    {
        public object thisLock = new object();
        public void Write(object path)
        {
            //only one thread accessing locked block at the same time
            //lock(thisLock)
            //{
            //    Console.WriteLine("Writing in " + path);
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Writing process finished.");
            //}

            //Monitor
            Monitor.Enter(path);
            try
            {
                Console.WriteLine("Writing in " + path);
                Thread.Sleep(2000);
                Console.WriteLine("Writing process finished.");
            }
            finally
            {
                Monitor.Exit(path);
            }
        }

        public void Read(object path)
        {
            Console.WriteLine("Reading from " + path);
            Thread.Sleep(1000);
            Console.WriteLine("Reading process finished.");
        }
    }
}
