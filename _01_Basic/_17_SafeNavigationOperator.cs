using System;

namespace _01_Basic
{
    class _17_SafeNavigationOperator
    {
        void ThisIsMain()
        {
            ASimpleClassOfCars car1 = new ASimpleClassOfCars();

            car1.Brand = "B1";
            car1.Model = "M1";
            car1.Price = 100_241;

            ASimpleClassOfCars.DisplayCarDetails(car1);
        }
    }

    class ASimpleClassOfCars
    {
        private string carBrand;
        private string carModel;
        private int carPrice;

        public string Model
        {
            get => carModel;
            set => carModel = value;
        }

        public string Brand
        {
            get => carBrand;
            set => carBrand = value;
        }

        public int Price
        {
            get => carPrice;
            set => carPrice = value;
        }


        public static void DisplayCarDetails(ASimpleClassOfCars car)
        {
            //if (car.Brand != null)
            //{
            //    Console.WriteLine(car.Brand);
            //}
            //if (car.Model != null)
            //{
            //    Console.WriteLine(car.Model);
            //}
            //if (car.Price != null)
            //{
            //    Console.WriteLine(car.Price);
            //}


            //Safe Navigation Operator
            Console.WriteLine(car?.Brand);
            Console.WriteLine(car?.Model);
            Console.WriteLine(car?.Price);
        }
    }
}
