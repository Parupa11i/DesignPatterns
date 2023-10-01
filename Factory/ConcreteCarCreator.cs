using System;
namespace Factory
{
    public class SUVFactory : CarFactory
    {
        protected override ICar GetCar()
        {
            ICar suv = new SUV();
            return suv;
        }
    }
    public class SedanFactory : CarFactory
    {
        protected override ICar GetCar()
        {
            ICar sedan = new Sedan();
            return sedan;
        }
    }
    public class CoupeFactory : CarFactory
    {
        protected override ICar GetCar()
        {
            ICar coupe = new Coupe();
            return coupe;
        }
    }
}
