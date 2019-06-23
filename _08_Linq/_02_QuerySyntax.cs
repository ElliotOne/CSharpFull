using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Linq
{
    class _02_QuerySyntax
    {
        void ThisIsMain()
        {
            var filteredList = new List<Employee>();
            var listOfEmployees = new List<Employee>
            {
                new Employee{Id = 1,firstName = "F1",lastName="L1",age = 20,salary =4000,appriasal=new List<int>{1,4,5,1,1}},
                new Employee{Id = 2,firstName = "F2",lastName="L2",age = 21,salary =5000,appriasal=new List<int>{1,2,5,1,1}},
                new Employee{Id = 3,firstName = "F3",lastName="L3",age = 20,salary =3000,appriasal=new List<int>{1,5,5,6,1}},
                new Employee{Id = 4,firstName = "F4",lastName="L4",age = 30,salary =2000,appriasal=new List<int>{1,47,5,7,1}},
                new Employee{Id = 5,firstName = "F5",lastName="L5",age = 46,salary =1000,appriasal=new List<int>{1,4,58,1,7,1}},
                new Employee{Id = 6,firstName = "F6",lastName="L6",age = 36,salary =6000,appriasal=new List<int>{1,4,5,7,2,1}},
                new Employee{Id = 7,firstName = "F7",lastName="L7",age = 24,salary =2000,appriasal=new List<int>{1,4,5,0,1}},
                new Employee{Id = 8,firstName = "F8",lastName="L8",age = 51,salary =40000,appriasal=new List<int>{6,4,5,7,1}},
                new Employee{Id = 9,firstName = "F9",lastName="L9",age = 37,salary =4100,appriasal=new List<int>{10,41,5,7,1}},
                new Employee{Id = 10,firstName = "F10",lastName="L10",age = 19,salary =41000,appriasal=new List<int>{11,4,5,7,1}},
                new Employee{Id = 11,firstName = "F11",lastName="L11",age = 72,salary =40700,appriasal=new List<int>{1,41,5,7,1}},
                new Employee{Id = 12,firstName = "F12",lastName="L12",age = 60,salary =8400,appriasal=new List<int>{1,9,5,71,1}},
                new Employee{Id = 13,firstName = "F13",lastName="L13",age = 41,salary =680000,appriasal=new List<int>{1,40,51,7,1}}
            };

            Employee.DisplayWithApparisal(listOfEmployees, "All Employees");

            filteredList = (from emp in listOfEmployees
                           where emp.salary >= 5000 || emp.age <= 30
                           select emp).ToList();

            Employee.DisplayWithApparisal(filteredList, "filtered data");

            filteredList = (from emp in listOfEmployees
                            where emp.Id > 10 || emp.age == 20 || emp.salary >= 7000 && emp.age > 20
                            select emp).ToList();


            //Sorting
            filteredList = (from emp in listOfEmployees
                            orderby emp.salary ascending
                            select emp).ToList();

            filteredList = (from emp in listOfEmployees
                            orderby emp.salary ascending, emp.age
                            select emp).ToList();
        }
    }
}
