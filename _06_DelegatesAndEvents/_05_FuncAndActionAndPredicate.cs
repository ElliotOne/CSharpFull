﻿using System;

namespace _06_DelegatesAndEvents
{
    class _05_FuncAndActionAndPredicate
    {
        void ThisIsMain()
        {
            //Func return value
            Func<int, int, int> func1 = AddTwoNums;
            Console.WriteLine(AddTwoNums(3, 10));

            //Action don't return value
            Action<int> action = DisplayInfo;
            action(12);

            Action action2 = DisplayInfo;
            action2();

            //Predicate return bool value
            Predicate<int> condition = IsAdmin;
            Console.WriteLine(condition(19));


            //Anonymous method and Lambda expression
            Func<string, string> convertToUpperCase = delegate (string name)
            {
                return name.ToUpper();
            };

            Func<string, string> convertToUpperCase2 = name => name.ToUpper();

            Action showMessage = delegate
            {
                Console.WriteLine("Hello");
            };

            Action<int> showMessage2 = (int m) => Console.WriteLine(m);
            showMessage2(9);
        }

        public static int AddTwoNums()
        {
            int z = 0;
            int x = 2;
            int y = 1;
            z = x + y;
            return z;
        }
        public static int AddTwoNums(int x, int y)
        {
            return x + y;
        }

        public static void DisplayInfo(int number)
        {
            Console.WriteLine(number);
        }

        public static void DisplayInfo()
        {
            Console.WriteLine("Hello World");
        }

        public static bool IsAdmin(int empNum)
        {
            if (empNum > 10)
                return true;
            else
                return false;
        }
    }
}
