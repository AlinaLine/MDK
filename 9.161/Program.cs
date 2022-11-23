using System;

namespace _9._161
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, s1, s2;
            Console.Write("Введите первое слово:");
            s = Console.ReadLine();
            Console.Write("Введите второе слово:");
            s2 = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
                if (!s2.Contains(s[i], StringComparison.OrdinalIgnoreCase))
                    Console.Write(s[i] + " ");
            for (int i = 0; i < s2.Length; i++)
                if (!s.Contains(s2[i], StringComparison.OrdinalIgnoreCase))
                    Console.Write(s2[i] + " ");
            Console.WriteLine();
            Console.ReadKey();

            Console.Write("Введите первое слово:");
            s1 = Console.ReadLine();
            Console.Write("Введите второе слово:");
            s2 = Console.ReadLine();
            s = s1 + s2;
            s = s.ToLower();
            for (int i = 0; i < s.Length; i++)
                if (s.IndexOf(s[i]) == i && s.LastIndexOf(s[i]) == i)
                    Console.Write(s[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
