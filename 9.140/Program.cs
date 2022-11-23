using System;

namespace _9._140
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Утром 12 числа 1990 года в 13 часов дня";
            Console.WriteLine(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count++;
                }
            }
            Console.WriteLine("Цифр в тексте:");
            Console.WriteLine(count);
        }
    }
}
