using System;

namespace _5._34
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 1, num = 1; 

            for (int i = 1; i < 8; i++)
            {
                num = num * 3; // вычисление степени тройки
                sum += 1 / num; // увеличение содержимого переменной sum на (на найденную дробь)
            }
            Console.WriteLine(sum); 
        }
    }
}
