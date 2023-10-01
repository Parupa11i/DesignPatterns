using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 1 for SUV, 2 for Sedan, 3 for Coupe");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ICar suv = new SUVFactory().CreateCar();
                    Console.WriteLine("Car type is: " + suv.GetCarType());
                    Console.WriteLine("Cubic capacity is: " + string.Format("{0:#,###,###}",suv.GetCC()));
                    Console.WriteLine("Price is: " + string.Format("{0:c2}",suv.GetPrice()));
                    break;
                case "2":
                    ICar sedan = new SedanFactory().CreateCar();
                    Console.WriteLine("Car type is: " + sedan.GetCarType());
                    Console.WriteLine("Cubic capacity is: " + string.Format("{0:#,###,###}", sedan.GetCC()));
                    Console.WriteLine("Price is: " + string.Format("{0:c2}", sedan.GetPrice()));
                    break;
                case "3":
                    ICar coupe = new CoupeFactory().CreateCar();
                    Console.WriteLine("Car type is: " + coupe.GetCarType());
                    Console.WriteLine("Cubic capacity is: " + string.Format("{0:#,###,###}", coupe.GetCC()));
                    Console.WriteLine("Price is: " + string.Format("{0:c2}", coupe.GetPrice()));
                    break;
            }
        }
    }
}