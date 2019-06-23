using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_AssemblyAndReflection
{
    class _08_PatternMatching
    {
        void ThisIsMain()
        {
            Dog max = new Dog();
            Lion simba = new Lion();
            Snake solidSnake = new Snake();

            AnimalSoundIs(simba);
            AnimalSoundSwitch(solidSnake);
            AnimalSoundSwitchWhen(max);
        }

        //Is
        public static void AnimalSoundIs(object animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            else if(animal is Cat)
                Console.WriteLine("Meow");
            else if(animal is Lion)
                Console.WriteLine("Roarrr");
            else if(animal is Snake)
                Console.WriteLine("sseh");
            else
                Console.WriteLine("Unknow animal");
        }

        //Switch
        public static void AnimalSoundSwitch(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("Woof");break;
                case Cat c: Console.WriteLine("Meow");break;
                case Lion l: Console.WriteLine("Roarrr");break;
                case Snake s: Console.WriteLine("sseh");break;
                default:
                    Console.WriteLine("Unknow animal");
                    break;
            }
        }

        //Switch and When
        public static void AnimalSoundSwitchWhen(object animal)
        {
            switch (animal)
            {
                case Dog d when d.DogName == null: Console.WriteLine("Dog name no't entered"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roarrr"); break;
                case Snake s: Console.WriteLine("sseh"); break;
                default:
                    Console.WriteLine("Unknow animal");
                    break;
            }
        }
    }

    class Dog
    {
        public string DogSound { get; set; }
        public string DogName { get; set; }
    }
    class Cat
    {
        public string CatSound { get; set; }
        public string CatName { get; set; }
    }
    class Lion
    {
        public string LionSound { get; set; }
        public string LionName { get; set; }
    }
    class Snake
    {
        public string SnakeSound { get; set; }
        public string SnakeName { get; set; }
    }
}
