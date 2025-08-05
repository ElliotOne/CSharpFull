using System;
using System.Diagnostics;

namespace _11_Miscellaneous
{
    class _05_StopWatch
    {
        void ExecuteWithTiming(int n)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(n);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed.Milliseconds);
        }
    }
}
