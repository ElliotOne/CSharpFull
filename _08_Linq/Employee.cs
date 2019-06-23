using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Linq
{
    class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal salary { get; set; }
        public int age { get; set; }
        public List<int> appriasal { get; set; }

        public static void Display(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"Id={item.Id} , firstName = {item.firstName} , lastName = {item.lastName} , salary = {item.salary}");
            }
        }

        public static void DisplayWithApparisal(List<Employee> employees, string message)
        {
            if (message != string.Empty)
            {
                Console.WriteLine(message);
                Console.WriteLine("*************");
            }
            foreach (var emp in employees)
            {
                Console.WriteLine($"Id={emp.Id} , firstName = {emp.firstName} , lastName = {emp.lastName} , salary = {emp.salary}");
                foreach (var item in emp.appriasal)
                {
                    Console.Write(item + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
