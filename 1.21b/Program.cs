using System;

namespace _1._21b
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 9.99;
            b = a;
            a = b;
            Console.WriteLine("a = {0}; b = {1}", a, b);

        }
    }
}
