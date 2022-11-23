using System;

namespace _2._22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n (n > 99)");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Число десятков в натуральном числе n:");
            Console.WriteLine((n / 10) % 10);
            Console.WriteLine("Число сотен в натуральном числе n:");
            Console.WriteLine((n / 100) % 10);
        }
    }
}
