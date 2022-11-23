using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите расстояние в см:");
            int i = int.Parse(Console.ReadLine());
            Console.Write("Полных м: ");
            Console.WriteLine(i / 100);
        }
    }
}
