using System;

namespace _5._13
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(string.Format("{0}*{1}={2}", 7, i, 7 * i));
            }
        }
    }
}
