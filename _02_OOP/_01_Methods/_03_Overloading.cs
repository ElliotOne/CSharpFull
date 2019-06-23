using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._01_Methods
{
    public class _03_Overloading
    {
        int sum(int a,int b)
        {
            return a + b;
        }
        //different signature is used to overload methods
        double sum(double a,double b)
        {
            return a + b;
        }
        double sum(double a,double b,int c)
        {
            return a + b + c;
        }
    }
}
