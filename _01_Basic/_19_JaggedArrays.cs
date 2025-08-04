using System;

namespace _01_Basic
{
    class _19_JaggedArrays
    {
        void SimpleMethod()
        {
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[2] { 14, 42 };
            jaggedArray[1] = new int[4] { 1, 2, 3, 4 };
            jaggedArray[2] = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            jaggedArray[3] = new int[2] { 1, 2 };

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
