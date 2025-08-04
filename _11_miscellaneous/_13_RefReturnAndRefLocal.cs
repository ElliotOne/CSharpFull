using System;

namespace _11_miscellaneous
{
    class _13_RefReturnAndRefLocal
    {
        static string[] names = { "Ella", "Liz", "Eve", "Claire" };

        void ThisIsMain()
        {
            int x1 = 3;
            int x2 = x1;

            x1 = 10;
            //x2 will not change

            //Ref Local
            int y1 = 0;
            ref int y2 = ref y1;
            y1 = 6;
            //y2 = 6 too


            ref var returnedValue = ref ReturnByReference();
            Console.WriteLine(returnedValue);

            returnedValue = "Elliot";
            Console.WriteLine(returnedValue);
            Console.WriteLine(names[0]);
        }

        static ref string ReturnByReference()
        {
            return ref names[0];
        }
    }
}
