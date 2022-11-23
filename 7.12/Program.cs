using System;

namespace _7._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 30; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    sum += i;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("\n\n Сумма " + sum);
        }
    }
}
