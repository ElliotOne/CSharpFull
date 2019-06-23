using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_AsynchronousProgramming
{
    class _03_ReturningValueAndStatus
    {
        public static void ReturnValueAndTaskStatus()
        {
            //Retunring value
            Task<int> task = new Task<int>(() =>
            {
                int result = 0;
                for (int i = 0; i < 10; i++)
                {
                    result += i;
                }
                return result;
            });

            task.Start();
            Console.WriteLine("Result=" + task.Result);
            //Task Status
            if (task.Status == TaskStatus.Running)
            {
                Console.WriteLine("Task running...");
            }
            else if (task.Status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine("Task is complete");
            }
        }
    }
}
