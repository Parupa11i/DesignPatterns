using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new SUVFactory().GetVehicle();
            Console.WriteLine("CC is: " + vehicle.GetCC());
            Console.WriteLine("Class is: " + vehicle.GetClass());
            Console.WriteLine("Model is: " + vehicle.GetModel());
            Console.WriteLine("-----------------------");
            vehicle = new SedanFactory().GetVehicle();
            Console.WriteLine("CC is: " + vehicle.GetCC());
            Console.WriteLine("Class is: " + vehicle.GetClass());
            Console.WriteLine("Model is: " + vehicle.GetModel());
            Console.WriteLine("-----------------------");
            vehicle = new HatchbackFactory().GetVehicle();
            Console.WriteLine("CC is: " + vehicle.GetCC());
            Console.WriteLine("Class is: " + vehicle.GetClass());
            Console.WriteLine("Model is: " + vehicle.GetModel());
        }
    }
}
