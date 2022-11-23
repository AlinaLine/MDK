using System;

namespace _9._77
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Какова красота сегодня с утра";
            Console.WriteLine(s1);
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == 'а' || s1[i] == 'А')
                {
                    Console.WriteLine($"{s1[i]} Под номером {i + 1}");
                    break;
                }
            }
        }
    }
}
