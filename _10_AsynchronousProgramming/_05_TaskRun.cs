using System;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _05_TaskRun
    {
        public static void RunTask()
        {
            NewMethod();
        }

        private static Task NewMethod()
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Hello World!");
            });
        }

        public static Task AddNumbersTask(params int[] numbers)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Add numbers task started :");
                int res = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    res += numbers[i];
                }
                Console.WriteLine($"Sum = {res}");
            });
        }
    }
}
