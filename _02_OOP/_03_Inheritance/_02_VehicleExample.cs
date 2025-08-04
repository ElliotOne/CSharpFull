using System;

namespace _02_OOP._03_Inheritance
{
    public class _02_VehicleExample
    {

    }
    public class WheeledVehicles
    {
        private string color;
        private decimal price;

        public string Color { get; set; }
        public decimal Price { get; set; }

        public void ChangeColor()
        {
            Console.WriteLine($"Color is changing.\n Color has changed");
            Color = "Red";
        }
    }

    public class FourWheeledVehicles : WheeledVehicles
    {
        private string brandName;
        private int capacity;
        public string BrandName { get; set; }
        public int Capacity { get; set; }

        public void StartVehicle()
        {
            Console.WriteLine("Car has started");
        }
        public void RunAtFullSpeed()
        {
            Console.WriteLine("Car is running on full speed");
        }
    }

}
