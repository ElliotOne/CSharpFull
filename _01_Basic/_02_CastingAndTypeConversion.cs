using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _02_CastingAndTypeConversion
    {
       void SimpleMethod()
        {
            int number = 100;
            string str = "";
            //Convert
            str = number.ToString();

            string numberInString = Convert.ToString(number);

            int num2 = Convert.ToInt32(numberInString);
            int num2_other = Int32.Parse(numberInString);
            //also : TryParse()

            //Explicit conversion
            double myDouble = 11.24;
            int myInt;
            myInt = (int)myDouble;

            //Implicit Conversion
            int num = 1223445;
            long bigNum = num;
        }
    }
}
