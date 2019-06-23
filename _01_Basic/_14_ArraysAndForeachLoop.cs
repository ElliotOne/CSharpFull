using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            //Two demensional
            int[,] nums2 = new int[3, 2];
            nums2[0, 0] = 00;
            nums2[1, 3] = 13;
            nums2[3, 2] = 32;

            for (int i = 0; i < nums2.GetLength(0); i++)
            {
                for (int j = 0; j < nums2.GetLength(1); j++)
                {
                    Console.WriteLine(nums2[i,j]);
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
