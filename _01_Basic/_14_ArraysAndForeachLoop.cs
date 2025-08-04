using System;

namespace _01_Basic
{
    public class _14_ArraysAndForeachLoop
    {
        void SimpleMethod()
        {
            int[] nums = new int[10];
            nums[0] = 2;
            nums[1] = 10;
            nums[2] = 6;


            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }

            string[] str = new string[] { "Hello", "World", "FirstName" };
            string[] str2 = { "Hello", "Worl", "LastName" };


            //Two dimensional
            int[,] nums2 = new int[3, 2];
            nums2[0, 0] = 00;
            nums2[1, 3] = 13;
            //nums2[3, 2] = 32; //Exception: System.IndexOutOfRangeException

            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    Console.WriteLine(nums2[i, j]);
                }
            }

            //foreach loop
            foreach (var item in str)
            {
                Console.WriteLine(item);
            }
        }
    }
}
