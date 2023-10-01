using System;
namespace FactoryMethod
{
    public class Sedan : IVehicle
    {
        public int GetCC()
        {
            return 1800;
        }

        public string GetClass()
        {
            return "Sedan";
        }

        public string GetModel()
        {
            return "Hyundai Verna";
        }
    }

    public class SUV : IVehicle
    {
        public int GetCC()
        {
            return 3200;
        }

        public string GetClass()
        {
            return "SUV";
        }

        public string GetModel()
        {
            return "Toyota Fortuner";
        }
    }

    public class HatchBack : IVehicle
    {
        public int GetCC()
        {
            return 1200;
        }

        public string GetClass()
        {
            return "Hatchback";
        }

        public string GetModel()
        {
            return "Hyundai I10";
        }
    }
}