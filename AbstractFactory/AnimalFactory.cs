using System;
namespace AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string AnimalType);

        public static AnimalFactory CreateAnimalFactory(string AnimalType)
        {
            if (AnimalType == "Land")
            {
                return new LandAnimalFactory();
            }
            else if (AnimalType == "Sea")
            {
                return new SeaAnimalFactory();
            }
            else
                return null;
        }
    }
}
