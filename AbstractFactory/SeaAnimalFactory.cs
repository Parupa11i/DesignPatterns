using System;
namespace AbstractFactory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "Whale":
                    return new Whale();
                case "Fish":
                    return new Fish();
            }
            return null;
        }
    }
}
