using System;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
