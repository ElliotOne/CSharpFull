using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _06_ConditionalStatement_Switch
    {
        void SimpleMethod()
        {
            int x = 4;
            string result = "";
            switch (x)
            {
                case 1: result = "one"; break;
                case 2: result = "two"; break;
                case 3: result = "three"; break;
                default:
                    result = "not 1 , 2 or 3 !";
                    break;
            }
        }
    }
}
