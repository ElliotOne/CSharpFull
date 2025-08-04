﻿using System;
using _02_OOP._02_Classes;
using _02_OOP._03_Inheritance;
using _02_OOP._05_Polymorphism;

namespace _02_OOP_UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiation
            Person person = new Person();

            //call set on FirstName
            person.FirstName = "Elliot";

            //class get on FirstName
            Console.WriteLine(person.FirstName);

            //passing values to constructor parameters
            _02_ConstructorAndDestructor myObj = new _02_ConstructorAndDestructor("myLastName");

            //Encapsulation
            WheeledVehicles car = new WheeledVehicles();
            car.Color = "Green";
            car.ChangeColor();


            //Polymorphism
            _01_ShapesExample[] shapes = new _01_ShapesExample[4];
            shapes[0] = new _01_ShapesExample();
            shapes[1] = new Circle();
            shapes[2] = new Square();
            foreach (_01_ShapesExample sh in shapes)
            {
                if (sh != null)
                {
                    sh.Draw();
                }
            }

            //Abstraction
            Lines line = new Lines();
            line.SayHi();
            line.Draw();
        }
    }
}
