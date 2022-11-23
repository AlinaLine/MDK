using System;
using System.Collections.Generic;
using System.Text;

namespace _4._28
{
    class Program
    {
        struct resh
        {
            public double x1;
            public double x2;
            public bool fl;
        }
        static resh Urav(double a, double b, double c)
        {
            resh rez;
            rez.x1 = 0;
            rez.x2 = 0;
            rez.fl = false;
            double D = b * b - 4 * a * c;
            if (D < 0) return rez;
            rez.x1 = (-b + Math.Sqrt(D)) / 2 * a;
            rez.x2 = (-b - Math.Sqrt(D)) / 2 * a;
            rez.fl = true;
            return rez;
        }
        static void Main(string[] args)
        {

            int a, b, c;
            Console.WriteLine("Введите коэффициенты квадратного уравнения");
            Console.Write("a=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Это программа решения только квадратного урванения");

            }
            resh otvet = Urav(a, b, c);
            if (otvet.fl == true)
                Console.WriteLine("Корни уравнения x1={0}, x2={1}", otvet.x1, otvet.x2);
            else
                Console.WriteLine("Уравнение не имеет корней");
            Console.ReadKey();
        }
    }
}