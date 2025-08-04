using System;

namespace _02_OOP._03_Inheritance
{
    //Base Class
    public class _01_AnimalExample
    {
        void NewAnimal()
        {
            Animal animal = new Animal();
            animal.Name = "ABC";
            animal.BirthDate = DateTime.Now;

            Birds bird = new Birds();
            bird.Name = "Bird1";
            bird.Color = "Red";
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public void FeedAnimal()
        {

        }
    }

    class Dogs : Animal
    {
        public string Breed { get; set; }
        public string Intelligence { get; set; }
        public bool IsEasyToTrain;
    }

    class Birds : Animal
    {
        public string Color;
        public string Country;
    }
}
