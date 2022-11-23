using System;

namespace _4._112
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Parse("01.01.1990");
            Console.Write("Стартовая дата {0}, введите количество месяцев: ", dt.ToShortDateString());
            int CountMonth;
            if (int.TryParse(Console.ReadLine(), out CountMonth))
            {
                dt = dt.AddMonths(CountMonth);
                dt = dt.AddDays(2);
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Для выхода нажмите любую клавишу...");
                Console.ReadKey(true);
                return;
            }
            string ResMonth = string.Empty;

            switch (dt.Month)
            {
                case 1:
                    ResMonth = "январь";
                    break;
                case 2:
                    ResMonth = "февраль";
                    break;
                case 3
                    ResMonth = "март";
                    break;
                case 4:
                    ResMonth = "апрель";
                    break;
                case 5:
                    ResMonth = "май";
                    break;
                case 6:
                    ResMonth = "июнь";
                    break;
                case 7:
                    ResMonth = "июль";
                    break;
                case 8:
                    ResMonth = "август";
                    break;
                case 9:
                    ResMonth = "сентябрь";
                    break;
                case 10:
                    ResMonth = "октябрь";
                    break;
                case 11:
                    ResMonth = "ноябрь";
                    break;
                case 12:
                    ResMonth = "декабрь";
                    break;
               
            }
            Console.WriteLine(ResMonth);
        }
    }
}
