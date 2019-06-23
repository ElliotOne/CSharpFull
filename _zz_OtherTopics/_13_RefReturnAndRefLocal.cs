using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _13_RefReturnAndRefLocal
    {
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


            ref var returnedValue = ref ReturnByRefrence();
            Console.WriteLine(returnedValue);

        }

        static ref string ReturnByRefrence()
        {
            string[] names = { "Ella", "Liz", "Eve", "Claire"};
            return ref names[0];
        }
    }
}
