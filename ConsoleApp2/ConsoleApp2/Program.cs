using System;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввежите имя");
            string name = Console.ReadLine();
            Thread.Sleep(5000);
            Console.WriteLine("Hello, {0}", name);
            Thread.Sleep(5000);
            Console.Write("Goodby");
            Console.ReadKey();
        }
    }
}
