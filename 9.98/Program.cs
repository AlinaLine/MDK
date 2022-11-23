using System;

namespace _9._98
{
    class Program
    {
        static void Main(string[] vs)
        {
            Console.WriteLine("Введите текст:");
            string txt = Console.ReadLine();

            Console.Write("Введите подстроки S1 и S2(через пробел):");
            string[]args = Console.ReadLine().Split();

            txt = txt.Replace(args[0], args[1]);
            Console.WriteLine(txt);
        }
    }
}
