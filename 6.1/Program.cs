using System;

namespace _6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, s = 0, a = 1;
            while (a != 0)
            {
                Console.Write("Введите целое число: ");
                a = Convert.ToInt32(Console.ReadLine());
                s += a;
                n++;
            }
            Console.WriteLine("Сумма = {0}, всего чисел = {1}", s, n);
            Console.ReadKey();
        }
    }
}
