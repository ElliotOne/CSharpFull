using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_GenericsAndCollections
{
    class _14_IEnumerableAndIEnumerator
    {
        void ThisIsMain()
        {
            IEnumerable<int> result = from value in Enumerable.Range(1, 10)
                                      select value;

            foreach (var val in result)
            {
                Console.WriteLine(val);
            }

            double avg = result.Average();
            Console.WriteLine(avg);

            List<int> numbersList = result.ToList();
            numbersList.Add(11);
            numbersList.Add(13);
            numbersList.Add(40);

            foreach (var item in numbersList)
            {
                Console.WriteLine(item);
            }

            result = numbersList.AsEnumerable();

            int[] arr = result.ToArray();


            IEnumerator<int> enumerator = numbersList.GetEnumerator();

            //foreach (var item in enumerator)
            //{ }

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
    }
}
