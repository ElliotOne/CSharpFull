using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    public class _01_ArrayListAndList
    {
        void NonGenericArrayList()
        {
            ArrayList arr = new ArrayList();
            arr.Add("Hello");
            arr.Add("World");
            arr.Add(3);
            arr.Add('B');
            arr.Add(true);
            arr.Add(12.4145);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            arr.Insert(2, "NewItem");
            Console.WriteLine(arr.IndexOf('B'));
            Console.WriteLine(arr.Count);
            arr.Remove("World");
            arr.RemoveAt(4);
            Console.WriteLine(arr.Contains("NewItem"));
            arr.Clear();
        }

        void GenericList()
        {
            List<string> sentence = new List<string>();
            sentence.Add("Hello");
            sentence.Add("World!");
            sentence.Add("I'm");
            sentence.Add("a");
            sentence.Add("good");
            sentence.Add("programmer!");
            foreach (string item in sentence)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(sentence.Count);
            sentence.Remove("World!");
        }
    }
}
