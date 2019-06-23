using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    class _06_BitArray
    {
        void NonGenericBitArray()
        {
            bool[] boolArray = new bool[4];
            boolArray[0] = false;
            boolArray[1] = false;
            boolArray[2] = false;
            boolArray[3] = true;

            BitArray bit1 = new BitArray(4);
            BitArray bit2 = new BitArray(boolArray);

            bit1.Set(0, false);
            bit1.Set(1, false);
            bit1.Set(2, false);
            bit1.Set(3, true);

            BitArray bitResult = new BitArray(4);
            //And - Or - Not
            bitResult = bit1.Or(bit2);
            foreach (var item in bitResult)
            {
                Console.WriteLine(item);
            }
        }
    }
}
