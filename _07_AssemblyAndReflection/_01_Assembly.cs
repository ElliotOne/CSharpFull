using System;
using System.Reflection;

namespace _07_AssemblyAndReflection
{
    public class _01_Assembly
    {
        void ThisIsMain()
        {
            Console.WriteLine(Assembly.GetEntryAssembly()?.Location);
            Console.WriteLine(Assembly.GetEntryAssembly()?.FullName);
        }
    }
}
