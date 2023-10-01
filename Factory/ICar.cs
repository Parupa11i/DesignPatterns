using System;
namespace Factory
{
    public interface ICar
    {
        public string GetCarType();
        public decimal GetPrice();
        public int GetCC();
    }
}