using System;
using System.Collections.Generic;

namespace _08_Linq
{
    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public int Age { get; set; }
        public List<int> Appraisal { get; set; }

        public static void Display(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine(
                    $"Id={item.Id} , " +
                    $"firstName = {item.FirstName} , " +
                    $"lastName = {item.LastName} , " +
                    $"salary = {item.Salary}");
            }
        }

        public static void DisplayWithAppraisal(List<Employee> employees, string message)
        {
            if (message != string.Empty)
            {
                Console.WriteLine(message);
                Console.WriteLine("*************");
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"Id={emp.Id} , " +
                                  $"firstName = {emp.FirstName} , " +
                                  $"lastName = {emp.LastName} , " +
                                  $"salary = {emp.Salary}");

                foreach (var item in emp.Appraisal)
                {
                    Console.Write(item + "|");
                }

                Console.WriteLine();
            }
        }
    }
}
