using System;

namespace _8._31
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                bool simple = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        simple = false;
                        break;
                    }
                }
                if (simple)
                    Console.Write(i + " ");
            }
        }
    }
}
