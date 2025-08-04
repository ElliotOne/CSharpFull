using System;

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
        public static void AnimalSoundIs(Animal animal)
        {
            if (animal is Dog)
                Console.WriteLine("Woof");
            else if (animal is Cat)
                Console.WriteLine("Meow");
            else if (animal is Lion)
                Console.WriteLine("Roarrr");
            else if (animal is Snake)
                Console.WriteLine("Sseh");
            else
                Console.WriteLine("Unknown animal");
        }

        //Switch
        public static void AnimalSoundSwitch(object animal)
        {
            switch (animal)
            {
                case Dog d: Console.WriteLine("Woof"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roarrr"); break;
                case Snake s: Console.WriteLine("Sseh"); break;
                default:
                    Console.WriteLine("Unknown animal");
                    break;
            }
        }

        //Switch and When
        public static void AnimalSoundSwitchWhen(object animal)
        {
            switch (animal)
            {
                case Dog d when d.Name == null: Console.WriteLine("Dog name is not entered"); break;
                case Cat c: Console.WriteLine("Meow"); break;
                case Lion l: Console.WriteLine("Roarrr"); break;
                case Snake s: Console.WriteLine("Sseh"); break;
                default:
                    Console.WriteLine("Unknown animal");
                    break;
            }
        }
    }

    public abstract class Animal
    {
        public string Sound { get; set; }
        public string Name { get; set; }
    }

    class Dog : Animal { }

    class Cat : Animal { }

    class Lion : Animal { }

    class Snake : Animal { }
}
