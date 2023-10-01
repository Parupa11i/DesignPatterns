using System;
namespace Factory
{
    public class SUV : ICar
    {
        public string GetCarType()
        {
            return "SUV";
        }
        public decimal GetPrice()
        {
            return 2000000;
        }
        public int GetCC()
        {
            return 6500;
        }
    }
    public class Sedan : ICar
    {
        public string GetCarType()
        {
            return "Sedan";
        }
        public decimal GetPrice()
        {
            return 1500000;
        }
        public int GetCC()
        {
            return 6000;
        }
    }
    public class Coupe : ICar
    {
        public string GetCarType()
        {
            return "Coupe";
        }
        public decimal GetPrice()
        {
            return 1450000;
        }
        public int GetCC()
        {
            return 5500;
        }
    }

}
