using System.Collections.Generic;
using System.Linq;

namespace _08_Linq
{
    class _02_QuerySyntax
    {
        void ThisIsMain()
        {
            var filteredList = new List<Employee>();
            var listOfEmployees = new List<Employee>
            {
                new Employee{Id = 1, FirstName = "F1",  LastName = "L1",  Age = 20, Salary = 4000,   Appraisal=new List<int>{1,4,5,1,1}},
                new Employee{Id = 2, FirstName = "F2",  LastName = "L2",  Age = 21, Salary = 5000,   Appraisal=new List<int>{1,2,5,1,1}},
                new Employee{Id = 3, FirstName = "F3",  LastName = "L3",  Age = 20, Salary = 3000,   Appraisal=new List<int>{1,5,5,6,1}},
                new Employee{Id = 4, FirstName = "F4",  LastName = "L4",  Age = 30, Salary = 2000,   Appraisal=new List<int>{1,47,5,7,1}},
                new Employee{Id = 5, FirstName = "F5",  LastName = "L5",  Age = 46, Salary = 1000,   Appraisal=new List<int>{1,4,58,1,7,1}},
                new Employee{Id = 6, FirstName = "F6",  LastName = "L6",  Age = 36, Salary = 6000,   Appraisal=new List<int>{1,4,5,7,2,1}},
                new Employee{Id = 7, FirstName = "F7",  LastName = "L7",  Age = 24, Salary = 2000,   Appraisal=new List<int>{1,4,5,0,1}},
                new Employee{Id = 8, FirstName = "F8",  LastName = "L8",  Age = 51, Salary = 40000,  Appraisal=new List<int>{6,4,5,7,1}},
                new Employee{Id = 9, FirstName = "F9",  LastName = "L9",  Age = 37, Salary = 4100,   Appraisal=new List<int>{10,41,5,7,1}},
                new Employee{Id = 10,FirstName = "F10", LastName = "L10", Age = 19, Salary = 41000,  Appraisal=new List<int>{11,4,5,7,1}},
                new Employee{Id = 11,FirstName = "F11", LastName = "L11", Age = 72, Salary = 40700,  Appraisal=new List<int>{1,41,5,7,1}},
                new Employee{Id = 12,FirstName = "F12", LastName = "L12", Age = 60, Salary = 8400,   Appraisal=new List<int>{1,9,5,71,1}},
                new Employee{Id = 13,FirstName = "F13", LastName = "L13", Age = 41, Salary = 680000, Appraisal=new List<int>{1,40,51,7,1}}
            };

            Employee.DisplayWithAppraisal(listOfEmployees, "All Employees");

            filteredList = (from emp in listOfEmployees
                            where emp.Salary >= 5000 || emp.Age <= 30
                            select emp).ToList();

            Employee.DisplayWithAppraisal(filteredList, "filtered data");

            filteredList = (from emp in listOfEmployees
                            where emp.Id > 10 || emp.Age == 20 || emp.Salary >= 7000 && emp.Age > 20
                            select emp).ToList();


            //Sorting
            filteredList = (from emp in listOfEmployees
                            orderby emp.Salary ascending
                            select emp).ToList();

            filteredList = (from emp in listOfEmployees
                            orderby emp.Salary ascending, emp.Age
                            select emp).ToList();
        }
    }
}
