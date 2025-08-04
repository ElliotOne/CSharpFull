using System.IO;

namespace _11_Miscellaneous
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

            //using: don't need to close or dispose the resource
            using (StreamWriter sw = new StreamWriter("myfile.txt"))
            {
                sw.WriteLine("First line");
                sw.WriteLine("Second line");
                sw.WriteLine("Third line");
            }
        }
    }
}
