using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _zz_OtherTopics
{
    public class _01_Documentations
    {
        void AddDog()
        {
            Dogs animal = new Dogs();
            animal.Sit();
            animal.Sit("abcd", "efghi");
        }
    }

    /// <summary>
    /// DogCommand is a inteface for the Animal base class.
    /// </summary>
    interface DogCommand
    {
        void Sit();
        void Sit(string dogName, string trainerName);
    }

    /// <summary>
    /// Animal class is bass class for other classes like dog class.
    /// </summary>
    class Animal
    {

    }
    class Dogs : Animal, DogCommand
    {
        /// <summary>
        /// Sit method will make the dog to sit!
        /// </summary>
        public void Sit()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sit method will make the dog to sit!
        /// </summary>
        /// <param name="dogName">String for dog name</param>
        /// <param name="trainerName">String for trainer name</param>
        public void Sit(string dogName, string trainerName)
        {
            throw new NotImplementedException();
        }
    }
}
