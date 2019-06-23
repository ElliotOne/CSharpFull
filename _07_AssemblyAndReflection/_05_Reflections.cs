using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace _07_AssemblyAndReflection
{
    class _05_Reflections
    {
        void ThisIsMain()
        {
            MemberInfo info = typeof(anotherClass);
            object[] attributes = info.GetCustomAttributes(true);
            foreach (var item in attributes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
