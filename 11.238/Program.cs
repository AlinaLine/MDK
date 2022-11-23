using System;

namespace _11._238
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 10;
            int[] arr = new int[l];
            int[] arr1 = new int[l];
            int sum = 0;
            int rev = 0;
            for (int i = 0; i < l; i++)
            {
                arr[i] = new Random().Next(1, 11);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < l; j++)
            {
                arr1[j] = new Random().Next(1, 11);
                Console.Write(arr1[j] + " ");
            }
            Console.WriteLine();
            for (int i = 0, j = 0; i < l && j < l; i++, j++)
            {
                if (i % 2 == 0)
                {
                    rev = i;
                    if (j == rev)
                    {
                        Console.Write(arr[i] + " ");
                    }
                }
                else
                { Console.Write(arr1[j] + " "); }
            }
            Console.WriteLine(" Измененный массив(элементы на тех же местах, что и в исходном массиве;)");
            for (int i = 0; i < l; i++)
            {
                if (i % 2 == 0)
                {
                    rev = i;
                    Console.Write(arr[i] + " ");
                    sum++;
                }
            }
            for (int j = 0; j < sum; j++)
            { Console.Write(arr1[j] + " "); }
            Console.WriteLine(" Измененный массив (элементы подряд с начала массива)");
        }
    }
}
