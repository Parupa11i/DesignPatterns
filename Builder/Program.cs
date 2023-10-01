using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string fname = "Varun";
            Console.WriteLine(fname.IndexOf("run"));

            string[] namelist = {"allam", "bellam", "kaas", "cees"};
            foreach(string x in namelist)
            {
                Console.WriteLine(x);
            }
            Array.Sort(namelist);
            foreach (string y in namelist)
            {
                Console.WriteLine(y);
            }
        }
    }
}
