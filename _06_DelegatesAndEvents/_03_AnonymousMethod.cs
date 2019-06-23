using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegatesAndEvents
{
    delegate void displayInfoDel();
    delegate void displayInfoByNumberDel(int number);
    class _03_AnonymousMethod
    {
        void ThisIsMain()
        {
            //Anonymous Method
            displayInfoDel displayInfo = delegate
            {
                Console.WriteLine("Hello from anonymous method");
            };

            
            displayInfo();

            displayInfoByNumberDel displayInfoByNum = delegate (int number)
            {
                Console.WriteLine(number + " from anonymouse method");
            };

            
            displayInfoByNum(2);

        }
    }
}
