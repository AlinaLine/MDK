using System;

namespace _12._32
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            Console.WriteLine("Введите количество строк массива ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива ");
            M = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N, M];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i, j] = r.Next(100);
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Все третей строки массива: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 3; j < 2; i++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите m - строку все элементы которой вы хотите вывести ");
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = s - 1; i < s; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] + " ");
            }
        }
    }
}
