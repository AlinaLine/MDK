using System;

namespace _12._53
{
    class Program
    {
        static void Main(string[] args)
        {
            int countShops = 10, countMonths = 12;
            double sr = 0, sum = 0;
            double[,] array = new double[countShops, countMonths];
            Random rnd = new Random();

            for (int i = 0; i < countShops; i++)
            {
                for (int j = 0; j < countMonths; j++)
                {
                    array[i, j] = rnd.Next(1, 10);
                }
            }
            for (int i = 0; i < countShops; i++)
            {
                for (int j = 0; j < countMonths; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Среднемесячный доход какого магазина рассчитать?");
            int x = int.Parse(Console.ReadLine());
            x--;
            if (x >= 0 && x < countShops)
            {
                for (int j = 0; j < countMonths; j++)
                {
                    sum += array[x, j];
                }
                sr = sum / countMonths;
                Console.WriteLine("Среднемесячный доход {0} магазина рассчитать = {1}", ++x, sr);
            }
            else
                Console.WriteLine("Такого магазина не существует.");
        }
        }
    }
