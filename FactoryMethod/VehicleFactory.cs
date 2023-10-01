using System;
namespace FactoryMethod
{
    public abstract class VehicleFactory
    {
        protected abstract IVehicle CreateVehicle();

        public IVehicle GetVehicle()
        {
            return this.CreateVehicle();
        }
    }

    public class SUVFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new SUV();
        }
    }

    public class SedanFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new Sedan();
        }
    }

    public class HatchbackFactory : VehicleFactory
    {
        protected override IVehicle CreateVehicle()
        {
            return new HatchBack();
        }
    }
}
