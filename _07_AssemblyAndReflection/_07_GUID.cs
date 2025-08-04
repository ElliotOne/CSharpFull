using System;

namespace _07_AssemblyAndReflection
{
    class _07_GUID
    {
        void ThisIsMain()
        {
            //Guid : Creating uniq identifiers

            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid);

            guid = Guid.NewGuid();
            Console.WriteLine(guid);
        }
    }
}
