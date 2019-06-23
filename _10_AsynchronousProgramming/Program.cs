using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class Program
    {
        static string processConnectToDatabase = "(Connecting to database)";
        static string processGetDataFromDatabase = "(Getting data from database)";
        static void Main(string[] args)
        {

            _01_Tasks.StartTask();

            //_02_WaitingForTasks.StartTasks();

            //_03_ReturningValueAndStatus.ReturnValueAndTaskStatus();

            //_04_CancelTask.CancelTask();

            //_05_TaskRun.RunTask();
            //_05_TaskRun.AddNumbersTask(10,5,2,1);

            //Console.WriteLine("First we are inside the main()");
            //_06_AsyncAndAwait.RunProcess(1,1_000_000);

            //var dbTask = ConnectToDatabaseProcessAndGetData();
            //Console.WriteLine("Back to the main()");
            //if (dbTask.Status == TaskStatus.RanToCompletion)
            //{
            //    Console.WriteLine($"Process {processConnectToDatabase} is completed.");
            //}
            //else
            //{
            //    Console.WriteLine($"Process {processConnectToDatabase} is not completed.");
            //}

            //_06_AsyncAndAwait.RunProcess(2, 1_000_000);



            //_07_ConcurrentCollections.ConcurrentCollectionsOperations();


            Console.ReadLine();
        }

        public static async Task ConnectToDatabaseProcessAndGetData()
        {
            Console.WriteLine($"Contolr is with process {processConnectToDatabase}");
            Console.WriteLine($"Process {processConnectToDatabase} has started.");
            Console.WriteLine($"Process {processConnectToDatabase} is running...");

            await Task.Run(() =>
            {
                Console.WriteLine("Start executing process in await block");
                Thread.Sleep(10000);
                Console.WriteLine("Process in the await block is complete!");
            });
            Console.WriteLine($"Process {processConnectToDatabase} is complete!");
            Console.WriteLine($"Control is with process {processGetDataFromDatabase} again");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Getting data...");
            }
            Console.WriteLine($"Process {processGetDataFromDatabase} is complete!");
        }
    }
}
