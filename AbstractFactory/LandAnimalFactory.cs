using System;
namespace AbstractFactory
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            switch (AnimalType)
            {
                case "Dog":
                    return new Dog();
                case "Cat":
                    return new Cat();
                case "Lion":
                    return new Lion();
            }
            return null;
        }
    }
}
