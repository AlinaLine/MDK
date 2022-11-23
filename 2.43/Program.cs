using System;

namespace _2._43
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число а:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите целое число b:");
            int  b = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат:");
            //перемножить остаток от деления a на b с остатком от деления b на a, прибавить единицу. если что-то на что-то делится, один из остатков будет нулевым => произведение будет нулевым => результат будет 1.
            Console.WriteLine(((a % b) * (b % a) + 1));

        }
    }
}
