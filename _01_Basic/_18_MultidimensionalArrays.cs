using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Basic
{
    class _18_MultidimensionalArrays
    {
        void SimpleMethod()
        {
            //2D array (matrix)
            int[,] matrix = new int[9,9];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i + j;
                }
            }

            //3D array
            string[,,] array3D = new string[,,]
            {
                {
                    {"000","001"},
                    {"010","011"}
                },
                {
                    {"100","101"},
                    {"110","111"}
                }
            };


        }
    }
}
