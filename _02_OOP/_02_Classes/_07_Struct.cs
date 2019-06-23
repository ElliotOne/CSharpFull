using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    class _07_Struct
    {
        void CreateEmployee()
        {
            Employee emp = new Employee();
            emp.Salary = 1000;
            emp.fullName = "AliMomenzadeh";
            emp.jobTittle = "Programmer";
            Console.WriteLine($"Salary = {emp.Salary}");
        }
    }

    struct Employee
    {
        public string fullName;
        public string jobTittle;
        private decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
}
