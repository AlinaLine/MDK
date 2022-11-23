using System;

namespace _4._95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите вес боксера до 69");
            int weight = int.Parse(Console.ReadLine());
            if (weight < 60)
            {
                Console.WriteLine("Легкий вес — до 60 кг");
            }
            else if (weight > 60 && weight < 64)
            {
                Console.WriteLine("Первый полусредний вес — до 64 кг");
            }
            else
            {
                Console.WriteLine("Полусредний вес — до 69 кг");
            }
        }
    }
}
