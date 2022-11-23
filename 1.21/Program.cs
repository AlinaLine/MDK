using System;

namespace _1._21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.8;
            double b = -7.9;
            a = b;
            b = a;
            Console.WriteLine("a = {0}; b = {1}", a, b);
        }
    }
}
