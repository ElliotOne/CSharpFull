#define underDev

//Disable all warnings!
#pragma warning disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_miscellaneous
{
    class _11_PreprocessorDirectives
    {
        #region myMainMwthod
        void ThisIsMain()
        {


#if(underDev)
            Console.WriteLine("This app is under development");
#else
            Console.WriteLine("This app is complete");
#warning This app is not complete
#error This is an error!

#endif
        }
#endregion
    }
}
