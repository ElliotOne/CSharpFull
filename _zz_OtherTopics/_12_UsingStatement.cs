using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    class _12_UsingStatement
    {
        void ThisIsMain()
        {
            //StreamWriter sw = new StreamWriter("myfile.txt");
            //sw.WriteLine("First line");
            //sw.WriteLine("Second line");
            //sw.WriteLine("Third line");
            //sw.Close();

            //using , don't need to close or dispose the resource
            using (StreamWriter sw = new StreamWriter("myfile.txt"))
            {
                sw.WriteLine("First line");
                sw.WriteLine("Second line");
                sw.WriteLine("Third line");
            }
        }
    }
}
