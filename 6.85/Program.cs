using System;

namespace _6._85
{
    class Program
    {
        static double Input(string Name, double Min = Double.MinValue, double Max = Double.MaxValue, double Exception1 = Double.MaxValue)
        {
            double Num;
            Console.WriteLine($"Введите {Name}");
            while (!(double.TryParse(Console.ReadLine(), out Num) && Num >= Min && Num <= Max && Num != Exception1)) Console.WriteLine($"Введено неверное значение, введите {Name}");
            return Num;
        }
        static void Main(string[] args)
        {
            long N6 = (long)Input("Натуральное число", long.MinValue, long.MaxValue);
            int N6count = 1;
            int N6place2 = -1;
            int N6place5 = -1;
            while (N6 > 0)
            {
                if (N6 % 10 == 2) N6place2 = N6count;
                if (N6 % 10 == 5) N6place5 = N6count;
                N6count++;
                N6 /= 10;
            }
            if (N6place2 > 0 && N6place5 > 0) Console.WriteLine(N6place5 > N6place2 ? "Цифра 5 расположена левее, чем 2" : "Цифра 2 расположена левее, чем 5");
            else Console.WriteLine("В числе нет цифр 2 и 5");
            Console.ReadKey();
        }
    }
}
