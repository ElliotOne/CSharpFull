using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._01_Methods
{
    public class _01_Basic
    {

        void ThisIsMain()
        {
            _01_Basic basicObj = new _01_Basic();
            basicObj.myPublicMethod();

            //Not accessable
            //basicObj.myPrivateMethod();

            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            ArrayParametersForMethod(nums);
        }

        void SimpleMethod()
        {
            Console.WriteLine("It's simple method!");
        }

        int Sum(int a , int b)
        {
            return a + b;
        }
        
        double Sub(double a,double b)
        {
            return a - b;
        }

        void CallAnotherFunction()
        {
            int sumValue = Sum(1, 2);
        }


        void NestedFunction(int data)
        {
            int otherFunc(int num)
            {
                int result = 0;
                for (int i = 0; i <= num; i++)
                {
                    result += i;
                }
                return result;
            }

            Console.WriteLine("Hello World");
        }

        void ArrayParametersForMethod(int[] numbers)
        {
            foreach (var item in numbers)
            {
                //do sth
            }
        }
        
        //Access modifiers (public , private , internal)
        public void myPublicMethod()
        {

        }

        private void myPrivateMethod()
        {

        }

    }
}
