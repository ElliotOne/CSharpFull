using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._03_Inheritance
{
    //Base Class
    public class _01_AnimalExample
    {
        void NewAnimal()
        {
            Animal animal = new Animal();
            animal.Name = "ABC";
            animal.birthDate = DateTime.Now;

            Birds bird = new Birds();
            bird.Name = "Bird1";
            bird.birdColor = "Red";
        }
    }

    class Animal
    {
        public string Name { get; set; }
        public DateTime birthDate { get; set; }
        public void FeedAnimal()
        {

        }
    }

    class Dogs : Animal
    {
        public string dogBreed { get; set; }
        public string dogIntelligence { get; set; }
        public bool isEasyToTrain;
    }

    class Birds : Animal
    {
        public string birdColor;
        public string birdCountry;
    }
}
