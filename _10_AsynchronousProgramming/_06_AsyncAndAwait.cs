using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _06_AsyncAndAwait
    {
        public static void RunProcess(int processNumber,int processLoopConfition)
        {
            Console.WriteLine("Control is with process "+processNumber);
            Console.WriteLine($"Process {processNumber} has started.");
            Console.WriteLine($"Process {processNumber} is running ...");
            for (int i = 0; i <=processLoopConfition ; i++)
            {

            }
            Console.WriteLine($"Process {processNumber} is complete!");
            Console.WriteLine("Contorol is back to main()");
        }
    }
}
