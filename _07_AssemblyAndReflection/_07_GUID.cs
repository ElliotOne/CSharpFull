using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AssemblyAndReflection
{
    class _07_GUID
    {
        void ThisIsMain()
        {
            //Guid : creating uniq numbers

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = Guid.NewGuid();
            Console.WriteLine(guid);
        }
    }
}
