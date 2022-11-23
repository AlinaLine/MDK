using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();
            int max = 1, count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(10);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
                if (count > max)
                {
                    max = count;
                }
                if (array[i] % 2 == 0)
                {
                    count = 0;
                }
            }
            Console.WriteLine($"Максимум подряд идущих нечетных чисел - {max}");

        }
    }
}
