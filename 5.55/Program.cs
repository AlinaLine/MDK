using System;

namespace _5._55
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число, возводимое в степень ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень этого числа ");
            int n = Convert.ToInt32(Console.ReadLine());

            double Exponentiation(double a, int b)
            {
                if (b == 0) return 1;
                if (b == 1) return a;
                else
                {
                    double result = 1;
                    for (int i = 0; i < b; i++)
                    {
                        result *= a;
                    }
                    return result;
                }
            }

            Console.Write($"{Exponentiation(a, n)}");
        }
    }
}
