using System;

namespace _06_DelegatesAndEvents
{
    delegate void DisplayInfoDel();
    delegate void DisplayInfoByNumberDel(int number);

    class _03_AnonymousMethod
    {
        void ThisIsMain()
        {
            //Anonymous Method
            DisplayInfoDel displayInfo = delegate
            {
                Console.WriteLine("Hello from anonymous method");
            };


            displayInfo();

            DisplayInfoByNumberDel DisplayInfoByNum = delegate (int number)
            {
                Console.WriteLine(number + " from Anonymous method");
            };


            DisplayInfoByNum(2);
        }
    }
}
