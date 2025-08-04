using System;

namespace _11_miscellaneous
{
    class _15_TimeSpan
    {
        void ThisIsMain()
        {
            TimeSpan ts = new TimeSpan(25, 8, 55);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Seconds);
            Console.WriteLine(ts.TotalMilliseconds);

            ts = ts.Add(new TimeSpan(0, 10, 40));
            Console.WriteLine(ts);

            DateTime dateTime1 = new DateTime(1999, 2, 1);
            DateTime dateTime2 = new DateTime(1888, 12, 7);
            var sub = dateTime1 - dateTime2;
            Console.WriteLine(sub);
        }
    }
}
