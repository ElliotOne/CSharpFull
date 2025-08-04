using System;
using System.Threading;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _06_AsyncAndAwait
    {
        public static async void RunProcess(int processNumber, int processLoopCondition)
        {
            Console.WriteLine("Control is with process " + processNumber);
            Console.WriteLine($"Process {processNumber} has started.");
            Console.WriteLine($"Process {processNumber} is running ...");

            for (int i = 0; i <= processLoopCondition; i++)
            {
                // Simulate work asynchronously
                await Task.Delay(processLoopCondition * 100);
            }

            Console.WriteLine($"Process {processNumber} is complete!");
            Console.WriteLine("Control is back to main()");
        }
    }
}
