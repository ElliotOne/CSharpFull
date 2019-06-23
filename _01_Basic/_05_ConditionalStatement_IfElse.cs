using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _05_ConditionalStatement_IfElse
    {
        void SimpleMethod()
        {
            int x = 4;
            int y = 5;
            string result = "";

            //if(condition)
            //{
            //  if condition is true
            //}

            //if(condition)
            //{
            //  if condition is true
            //}
            //else
            //{
            //  if condition is flase
            //}


            //if(condition1)
            //{
            //  if condition1 is true
            //}
            //else if(condition2)
            //{
            //  if condition2 is true
            //}
            //...
            //else
            //{
            //  if all of the conditions are false 
            //}

            if (x < y)
            {
                result = $"{x} is smaller than {y}.";
            }
            else if (x > y)
            {
                result = $"{x} is bigger than {y}.";
            }
            else
            {
                result = $"{x} is equal to {y}.";
            }


            //Nester if else statements
            int a = 2;
            string strResult;
            if (a > 0)
            {
                if (a == 2)
                {
                    strResult = "a is equal 2.";
                }
                else
                {
                    strResult = "a is not equal 2.";
                }
            }
            else
            {
                strResult = "a is smaller than 0.";
            }
        }
    }
}
