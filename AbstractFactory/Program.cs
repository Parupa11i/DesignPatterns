using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalFactory animalFactory = null;
            IAnimal animal = null;

            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            animal = animalFactory.GetAnimal("Dog");
            Console.WriteLine(animal.Speak());

        }
    }
}
