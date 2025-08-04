using System;
using System.IO;

namespace _04_Files
{
    public class _01_StreamReaderAndWriter
    {
        string ReadFromFile(bool readAll)
        {
            string filePath = @"C:\Data.txt";
            string text = string.Empty;
            StreamReader sr = new StreamReader(filePath);
            try
            {
                if (readAll)
                {
                    text = sr.ReadToEnd();
                }
                else
                {
                    text = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                text = ex.Message + " " + ex.StackTrace;
            }
            finally
            {
                sr.Close();
            }
            return text;
        }
        void WriteToFile(string text)
        {
            string filePath = @"C:\Data.txt";
            StreamWriter sw = new StreamWriter(filePath, true);
            try
            {
                sw.Write(text);
            }
            catch (Exception ex)
            {
                text = ex.Message + " " + ex.StackTrace;
            }
            finally
            {
                sw.Close();
            }
        }

        void createDirectory()
        {
            StreamWriter sw;
            string language = string.Empty;

            int count = Enum.GetNames(typeof(Languages)).Length;

            for (int i = 0; i < count; i++)
            {
                language = Enum.GetValues(typeof(Languages)).GetValue(i).ToString();
                Directory.CreateDirectory(@"C:\Languages");
                Directory.CreateDirectory(@"C:\Languages\" + language);
                sw = new StreamWriter(@"C:\Languages\" + language + @"\log.txt");
                sw.WriteLine("File number : " + i + " Created on : " + DateTime.Now);
                sw.Close();
            }
        }
    }

    enum Languages
    {
        Arabic,
        Persian,
        English,
        French,
        German
    }
}
