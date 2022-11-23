using System;

namespace _12._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите колво строк / столбцов:");

            int a = int.Parse(Console.ReadLine());
            int[,] arr = new int[a, a];
            Random r = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = r.Next(10);
                }
            }
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr[0, 0] + "элемент, расположенный в левом верхнем углу массива.");
            Console.WriteLine(arr[0, a - 1] + "элемент, расположенный в правом верхнем углу массива.");
            Console.WriteLine(arr[a - 1, 0] + "элемент, расположенный в левом нижнем углу массива.");
            Console.WriteLine(arr[a - 1, a - 1] + "элемент, расположенный в правом нижнем углу массива.");

            double temp =((arr[0, 0] + arr[0, a - 1] + arr[a - 1, a - 1] + arr[a - 1, 0]) / 4);
            Console.WriteLine("Ср арифметичсекое =");
            Console.WriteLine(temp);
        }
    }
}
