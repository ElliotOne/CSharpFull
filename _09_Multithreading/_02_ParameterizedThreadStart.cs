﻿using System;
using System.Threading;

namespace _09_Multithreading
{
    class _02_ParameterizedThreadStart
    {
        public static void StartThread()
        {
            Helper helper = new Helper();
            Thread t1 = new Thread(new ParameterizedThreadStart(helper.Loop));
            t1.Start(400);
        }
    }

    class Helper
    {
        public void Loop(object number)
        {
            for (int i = 0; i < int.Parse(number.ToString()); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
