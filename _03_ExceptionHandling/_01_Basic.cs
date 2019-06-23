using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExceptionHandling
{
    class _01_Basic
    {
        string Divide(int a, int b)
        {
            double result;
            try
            {
                result =(double) a / b;
                return result.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string ReadFileData()
        {
            FileStream fs = new FileStream(@"C:\Data.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string text = string.Empty;
            startAgain:
            try
            {
                text=sr.ReadToEnd();
            }
            catch (FileNotFoundException ex)
            {
                text = $"Oops,we couldn't find the file.Help Link : {ex.HelpLink}";
            }
            catch(Exception ex)
            {
                text = $"Opps,{ex.Message}";
                goto startAgain;
            }
            finally
            {
                sr.Close();
            }
            return text;
        }
    }
}
