using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    public class _02_ConstructorAndDestructor
    {
        //If there is no constructor , there will be always a hidden deafult constructor
        //but if we add other constructors with parameters and then we need default one ,
        //we should add it.
        public _02_ConstructorAndDestructor()
        {
            //deafalt constractor
        }

        int number;
        string firstName;
        string lastName;
        public _02_ConstructorAndDestructor(int Number,string FirstName = "Deafult FirstName")
        {
            number = Number;
            firstName = FirstName;
        }

        public _02_ConstructorAndDestructor(string LastName)
        {
            lastName = LastName;
        }

        //destructor
        ~_02_ConstructorAndDestructor()
        {
            Console.WriteLine("Object is about to be destroyed!");
        }
    }
}
