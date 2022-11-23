using System;

namespace _9._56
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string txt = Console.ReadLine();
            int nnCounter = 0;

            for (int i = 1; i < txt.Length; i++)
                if (txt[i] == 'н' && txt[i - 1] == 'н')
                {
                    nnCounter++;
                    i++;
                }

            Console.WriteLine($"Количесвто \"НН\"в тексте: {nnCounter}");
        }
    }
}
