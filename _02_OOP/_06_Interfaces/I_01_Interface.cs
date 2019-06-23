using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._06_Interfaces
{
    public interface I_01_Interface : IAnimals
    {
        void Stay();
        void Sit();
        void Attack();

        string DogName{ get; set; }
    }

    public interface IAnimals
    {
        void Run();
    }

    public class Cats
    {
        public string catName { get; set; }
        public string Gender { get; set; }
        public string Color { get; set; }
        public int runingSpeed { get; set; }
    }
    public class Dogs : Cats,I_01_Interface 
    {
        private string dogName;
        public string DogName { get => dogName; set => dogName = value; }

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
