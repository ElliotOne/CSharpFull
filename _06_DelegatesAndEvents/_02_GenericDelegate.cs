using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DelegatesAndEvents
{
    public delegate T DisplayInfoDel<T>(T val);
    class _02_GenericDelegate
    {
        void ThisIsMain()
        {
            DisplayInfoDel<int> infoDel = new DisplayInfoDel<int>(displayInfo);
            Console.WriteLine(infoDel(100));

            DisplayInfoDel<string> infoDel2 = new DisplayInfoDel<string>(displayInfo);
            Console.WriteLine(infoDel2("Hello"));
        }

        public static T displayInfo<T>(T val)
        {
            Console.WriteLine($"value Type = {val.GetType().Name}");
            return val;
        }
    }
}
