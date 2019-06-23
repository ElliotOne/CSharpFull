using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP._02_Classes
{
    public class _09_GenericClass
    {
        void CreateABuilding()
        {
            Buildings<int> first = new Buildings<int>();
            first.Name = "One";
            first.City = "City1";
            first.Height = 100;
            first.Weight = 30000;

            Buildings<double> second = new Buildings<double>();
            second.Name = "Two";
            second.City = "City2";
            second.Height = 34.515;
            second.Weight = 101024.1515;
        }
    }

    class Buildings<T>
    {
        private string name;
        private string city;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        private T height;
        private T weight;
        public T Height
        {
            get { return height; }
            set { height = value; }
        }
        public T Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
