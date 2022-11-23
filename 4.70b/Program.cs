using System;

namespace _4._70b
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
                a = a + b;
                b = a - b;
                a = a - b;
            }
            
            Console.WriteLine("Число {0} меньше, чем {1}", a, b);

        }
    }
}
