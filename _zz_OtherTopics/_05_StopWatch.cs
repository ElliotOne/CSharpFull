using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _05_StopWatch
    {
        void ExuteWithTiming(int n)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i <= n ; i++)
            {
                Console.WriteLine(n);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed.Milliseconds);
        }
    }
}
