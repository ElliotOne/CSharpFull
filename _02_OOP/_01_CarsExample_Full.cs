using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP
{
    class _01_CarsExample_Full
    {
        private decimal price;
        protected int maxSpeed;
        public string color;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public virtual void DisplayInfo()
        {
            price = 10000;
            maxSpeed = 260;
            color = "Black";
            Console.WriteLine($"Default values : price = {price} , max speed = {maxSpeed} , color = {color}");
        }
    }
    
    class Merceds : _01_CarsExample_Full
    {
        public Merceds(decimal price)
        {
            Price = price;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a merced car!");
        }
    }
}
