using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    public class _09_Strings
    {
        void SimpleMethod()
        {
            string str = "This is a sentence.  ";
            //Indexes
            char first = str[0];
            //Trim
            string clearStr = str.Trim();
            //UpperCase/LowerCase
            string UPERCASE = str.ToUpper();
            string lowercase = str.ToLower();
            //Length
            int len = str.Length;
            //Replace
            string newStr = str.Replace('T', 'M');
            //Index of
            int indexOfT = str.IndexOf('T');
            //Last index of
            int lastIndexOfE = str.LastIndexOf('e');
            //Substring
            string substr = str.Substring(4, 12);
            //Remove
            string rem = str.Remove(10, 15);
            //Insert
            string insStr = str.Insert(0, "HelloWorld!");



            //Escape Sequences
            string st1 = "This is \\backslah!";
            string st2 = @"C:\ProgramFile\VisualStudio";
            string st3 = "This is a \t tab!";
            string st4 = "Creating \n new line";

            
            //Concatination
            string st1Andst3 = string.Concat(st1, st3);
            string st1Andst3_Old = st1 + st2;

            //PlaceHolders
            Console.WriteLine("This is {0} a place holder! {1}", "first", "second");
        }
    }
}
