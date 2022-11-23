using System;

namespace _6._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int k, n, last, c, m, cnt0, cnt5, kc, sum7, prod7;
            cnt5 = 0;
            cnt0 = 0;
            Console.WriteLine("Введите число N");
            n = int.Parse(Console.ReadLine());
            m = n % 10;
            last = 0;
            k = 0;
            kc = 0;
            sum7 = 0;
            prod7 = 1;

            do
            {
                c = n % 10;
                if ((n % 10) == 3) { k = k + 1; }
                if (n % 2 == 0) { kc = kc + 1; };
                if (c == m) { last = last + 1; }
                if (n % 10 == 0) { cnt0 = cnt0 + 1; }
                if (n % 10 == 5) { cnt5 = cnt5 + 1; }
                if (c > 7) { prod7 = prod7 * c; sum7 = sum7 + c; }
                n = n / 10;
            }
            while (n != 0);
            Console.WriteLine("Число 3 встречается: " + k + " раз");
            Console.WriteLine("Последнее число встречается: " + last + " раз");
            Console.WriteLine("Четных чисел: " + kc);
            Console.WriteLine("Всего чисел 5 и 0:" + (cnt0 + cnt5));
            Console.WriteLine("Сумма чисел больше 7: " + sum7);
            Console.WriteLine("Произведение чисел больше 7: " + prod7);

        }
    }
}
