using System;
using System.Threading;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Thread.Sleep(3000);
            Console.WriteLine("Привет, {0}, {1}, {2}, {3}", name, "Maria", "Vladislav", "Ivan");
            Console.ReadKey();
            Console.WriteLine("HelloFucking world!");
        }
    }
}
