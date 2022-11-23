using System;

namespace _8._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[18, 3];
            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Введите оценку. Ученик №{i + 1}, предмет №{j + 1}");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Вы ввели {grades[i, j]}");
                }
                Console.WriteLine("___________________________________");
            }

            for (int i = 0; i < 18; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(grades[i, j] + " ");
                Console.WriteLine();
            }
        }
    }
}
