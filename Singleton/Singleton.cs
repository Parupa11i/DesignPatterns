using System;
namespace Singleton
{
    public class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = new Singleton(); //This is eager loading statement
        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
