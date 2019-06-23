using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _zz_OtherTopics
{
    class _06_Timer
    {
        void ThisIsMain()
        {
            Timer timer = new Timer();
            timer.Elapsed += OnEachSecond;
            timer.Interval = 3000;
            timer.Enabled = true;

            Console.WriteLine("Press X to exit");
            while (Console.Read() != 'x')
            {

            }
        }

        private void OnEachSecond(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
