using System;

namespace _11._196
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[28];
            int b = 0;
            Console.WriteLine("Введите оценки учеников (28): ");
            for (int i = 0; i < a.Length; i++)
                a[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 2)
                {
                    b++;
                }
                else if (a[i] == 2)
                {
                    Console.WriteLine("Среди оценок учеников есть двойки");
                    break;
                }
            }
            if (b == a.Length)
                Console.WriteLine("Среди оценок учеников нет двоек");
        }
    }
}
