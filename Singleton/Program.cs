using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadedSingleton();
        }

        private static void ShowSingleton()
        {
            Singleton s1 = Singleton.GetInstance;
            Console.WriteLine("First one");
            Singleton s2 = Singleton.GetInstance;
            Console.WriteLine("Second one");
        }

        private static void ThreadedSingleton()
        {
            Parallel.Invoke(
                () => PrintStudent(),
                () => PrintTeacher()
            );
            Console.ReadLine();
        }

        private static void PrintStudent()
        {
            Singleton s1 = Singleton.GetInstance;
            Console.WriteLine("From Student");
        }

        private static void PrintTeacher()
        {
            Singleton t1 = Singleton.GetInstance;
            Console.WriteLine("From Teacher");
        }

    }
}
