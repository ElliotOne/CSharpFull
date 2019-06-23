using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._01_Methods
{
    class _08_ExtensionMethods
    {
        void ThisIsMain()
        {
            int x = 0;
            x.IsGreater(20);

            string txt = "Hello";
            bool isItNumber = txt.IsNumber();


            DateTime date = new DateTime(2000, 11, 1);
            string dateString = date.myCunstomDateFormat();
        }
    }


    static class myCustomeExtension
    {
        public static bool IsGreater(this int value,int number)
        {
            return value > number;
        }

        public static bool IsNumber(this string text)
        {
            return int.TryParse(text, out int result);
        }

        public static string myCunstomDateFormat(this DateTime dateTime)
        {
            return string.Format("{0:dddd dd \nMMMM yyyy}", dateTime);
        }
    }
}
