using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _04_CancelTask
    {
        public static void CancelTask()
        {
            //Canceling a Task
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;
            Task taskSecond = new Task(() =>
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (token.IsCancellationRequested)
                    {
                        Console.WriteLine("TaskSecond Cancelled");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(i + 1);
                    }
                }
                Console.WriteLine("TaskSecond is complete");
            });
            taskSecond.Start();

            //Thread.Sleep(3000);
            //cancellationTokenSource.Cancel();
            cancellationTokenSource.CancelAfter(3000);
        }
    }
}
