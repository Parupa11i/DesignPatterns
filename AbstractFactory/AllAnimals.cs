using System;
namespace AbstractFactory
{
    public class Dog : IAnimal
    {
        public string Speak()
        {
            return "Bark";
        }
    }
    public class Cat : IAnimal
    {
        public string Speak()
        {
            return "Meow";
        }
    }
    public class Lion : IAnimal
    {
        public string Speak()
        {
            return "Roar";
        }
    }
    public class Whale : IAnimal
    {
        public string Speak()
        {
            return "Sing";
        }
    }
    public class Fish : IAnimal
    {
        public string Speak()
        {
            return "No sound";
        }
    }
}
