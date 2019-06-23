using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    class _02_HashTableAndDictionary
    {
        void NonGenericHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Ali", "Hello");
            hashtable.Add(2, "World");
            hashtable.Add('B', "Me");

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine(item.Key + "-" + item.Value);
            }

            Console.WriteLine(hashtable.Count);
            Console.WriteLine(hashtable.ContainsValue("ABC"));
            Console.WriteLine(hashtable.ContainsKey("Ali"));

            //Copy 
            ArrayList array = new ArrayList(hashtable.Values);
            foreach (var val in array)
            {
                Console.WriteLine(val);
            }
        }

        void GenericDictionary()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Hello");
            dict.Add(2, "World");
            dict.Add(3, "!");
            dict.Add(4, "I'm a programmer");

            foreach (KeyValuePair<int,string> item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            Console.WriteLine(dict.Count);
            dict.Remove(3);
            dict.Clear();
        }
    }
}
