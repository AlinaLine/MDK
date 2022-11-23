using System;

namespace _4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое вещественное число");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Второе вещественное число:");
            double b = double.Parse(Console.ReadLine());
            if (a>b)
            {
                Console.WriteLine("Первое вещественное число максимальное, второе - минимальное");
            }
            else
            {
                Console.WriteLine("Второе вещественное число максимальное, первое - минимальное");
            }
        }
    }
}
