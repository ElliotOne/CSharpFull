using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _03_DateAndTime
    {
        void SimpleMethod()
        {
            DateTime mydate = new DateTime();
            int day = mydate.Day;
            int month = mydate.Month;
            int hour = mydate.Hour;

            DateTime todate = DateTime.Today;
            DateTime now = DateTime.Now;
            string longDate = now.ToLongDateString();
            string fomatDate = string.Format("{0:yyyy}", longDate);

            string anotherFormat = string.Format("{0:dd-MM-yyyy HH:mm:ss}", now);
        }
       
    }
}
