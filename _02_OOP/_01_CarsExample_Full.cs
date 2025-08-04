using System;

namespace _02_OOP
{
    class _01_CarsExample_Full
    {
        private decimal price;
        protected int MaxSpeed;
        public string Color;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public virtual void DisplayInfo()
        {
            price = 10000;
            MaxSpeed = 260;
            Color = "Black";
            Console.WriteLine($"Default values : price = {price} , max speed = {MaxSpeed} , color = {Color}");
        }
    }

    class Mercedes : _01_CarsExample_Full
    {
        public Mercedes(decimal price)
        {
            Price = price;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("This is a Mercedes car!");
        }
    }
}
