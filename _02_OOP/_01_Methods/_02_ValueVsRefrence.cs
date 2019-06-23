using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._01_Methods
{
    public class _02_ValueVsRefrence
    {
        void getStringCopy(string str)
        {
            str = "New data won't change str outside method";
        }

        void getStringRefrence(ref string str)
        {
            str = "String will change outside the method";
        }

        int outString(out string str,int data)
        {
            str = "String will change outside the method";
            return data * 3;
        }
    }
}
