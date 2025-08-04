using System;

namespace _02_OOP._02_Classes
{
    class _01_Basic
    {
        class InnerClass
        {
            //Inner class
            class InnerClass2
            {
                //Another inner class
            }
        }
    }

    class MyClass
    {
        //This is another class
    }
    class MyClass2
    {
        //This is another class too!
    }

    public class Person
    {
        //fields
        string firstName;
        private string lastName;
        DateTime birthDate;
        private string country;
        private int age;

        //properties
        //short form
        string Name { get; set; }
        //long form
        //public void SetFirstName(string firstname)
        //{
        //    firstName = firstname;
        //}
        //public string GetFirstName()
        //{
        //    return firstName;
        //}
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (age < 0)
                    throw new Exception("Age most be positive.");
                else
                    age = value;
            }
        }

        //read only properties  : doesn't have "set"
        //write only properties : doesn't have "get"
        public string Country
        {
            get { return country; }
        }
    }
}
