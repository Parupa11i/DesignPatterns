using System;
namespace Factory
{
    public abstract class CarFactory
    {
        protected abstract ICar GetCar();

        public ICar CreateCar()
        {
            return this.GetCar();
        }
    }
}
