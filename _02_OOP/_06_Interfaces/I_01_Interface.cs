using System;

namespace _02_OOP._06_Interfaces
{
    public interface I_01_Interface : IAnimals
    {
        void Stay();
        void Sit();
        void Attack();

        string Name { get; set; }
    }

    public interface IAnimals
    {
        void Run();
    }

    public class Cats
    {
        public string CatName { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public int RunningSpeed { get; set; }
    }
    public class Dogs : Cats, I_01_Interface
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sit()
        {
            throw new NotImplementedException();
        }

        public void Stay()
        {
            throw new NotImplementedException();
        }
    }
}
