using System;

namespace _11._112
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25;
            int[] heigth = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                heigth[i] = rnd.Next(150, 220);
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > i; j--)
                    if (heigth[j - 1] > heigth[j])
                    {
                        int temp = heigth[j];
                        heigth[j] = heigth[j - 1];
                        heigth[j - 1] = temp;
                    }
            }
            Console.WriteLine("Самый высокий человек: {0} см.", heigth[n - 1]);
            Console.WriteLine("Самый низкий человек: {0} см.", heigth[0]);
            Console.WriteLine("Разница в росте составит: {0} см.", heigth[n - 1] - heigth[0]);
        }
    }
}
