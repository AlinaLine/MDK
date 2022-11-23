using System;

namespace _4._70
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое вещественное число");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Второе вещественное число:");
            double b = double.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Первое число больше, второе меньше");
            }
            if (b>a)
            {
                Console.WriteLine("Первое число меньше, второе больше");
            }

        }
    }
}
