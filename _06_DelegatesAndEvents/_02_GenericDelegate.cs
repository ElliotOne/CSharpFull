using System;

namespace _06_DelegatesAndEvents
{
    public delegate T DisplayInfoDel<T>(T val);
    class _02_GenericDelegate
    {
        void ThisIsMain()
        {
            DisplayInfoDel<int> infoDel = new DisplayInfoDel<int>(DisplayInfo);
            Console.WriteLine(infoDel(100));

            DisplayInfoDel<string> infoDel2 = new DisplayInfoDel<string>(DisplayInfo);
            Console.WriteLine(infoDel2("Hello"));
        }

        public static T DisplayInfo<T>(T val)
        {
            Console.WriteLine($"value Type = {val.GetType().Name}");
            return val;
        }
    }
}
