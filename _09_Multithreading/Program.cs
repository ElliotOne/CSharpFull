using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _09_Multithreading
{
    class Program
    {
        
        static void Main(string[] args)
        {


            //_01_Basic.StartThreads();

            //_02_ParameterizedThreadStart.StartThread();

            //_03_DeadlocksAndLockKeyword.StartReadAndWrite();

            //_04_Mutex.StartProcess();

            _05_Semaphore.StartProcess();


            Console.ReadKey();
        }
    }
}
