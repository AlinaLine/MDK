using System;

namespace _12._221
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность квадратной матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[size, size];
            int[,] array2 = new int[size, size];
            int i, j;
            Random rand = new Random();

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    array[i, j] = rand.Next(0, 10);
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (size % 2 == 0)
            {
                Console.WriteLine("Четное");
                for (i = 0; i < size; i++)
                {
                    for (j = 0; j < size; j += 2)
                    {
                        array2[i, j] = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = array2[i, j];
                    }
                }
            }
            else Console.WriteLine("Число столбцов нечетное, изменений нет!");

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
