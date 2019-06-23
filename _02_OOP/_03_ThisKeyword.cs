using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP
{
    public class _03_ThisKeyword
    {
        Person person = new Person();
        void GetPersinData()
        {
            person.Display();
        }
    }
    class Person
    {
        string firstName;
        string lastName;
        public string Display()
        {
            //this : the currnent instance of the class
            return this.firstName + " " + this.lastName;
        }
        public Person()
        {
            firstName = "No FirstName";
            lastName = string.Empty;
        }
        //Same name for parameters and fields
        public Person(string lastName)
        {
            this.lastName = lastName;
        }
    }
}
