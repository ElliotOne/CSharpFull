using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07_AssemblyAndReflection
{
    public class _01_Assembly
    {
        void ThisIsMain()
        {
            Console.WriteLine(Assembly.GetEntryAssembly().Location);
            Console.WriteLine(Assembly.GetEntryAssembly().FullName);
        }
    }
}
