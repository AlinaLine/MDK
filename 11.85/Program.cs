using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._85
{
    class Program
    {
        static int CountNeg(int[] arr, int c)
        {
            int count = 0;
            foreach (var i in arr)
            {
                if (i < 0 && i % c == 0)
                {
                    count++;
                }

            }

            return count;
        }

        static int CountSumm(int[] arr, int c)
        {
            int summ = 0;

            foreach (var i in arr)
            {
                if (i < 0 && i % c == 0)
                {
                    summ += i;
                }

            }


            return summ;
        }
        static void Main(string[] args)
        {

                //задаем массив
                int[] arr = new int[29];
                Random rand = new Random();
                // заполняем массив значениями и выводим его
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rand.Next(-100, 101);
                    Console.WriteLine(arr[i]);
                }
                //находим минимальный элемент массива
                int x = arr.Min();
                Console.WriteLine();
                Console.WriteLine("Минимальный элемент:{0}", x);
                //находим сумму нужных отрицательных элементов и их количество
                int summ = CountSumm(arr, x);
                int count = CountNeg(arr, x);

                // Находим среднее арифмитическое
                double average = summ / count;

                Console.WriteLine();
                Console.WriteLine("Ответ:{0}", average);

            }
        }
    }

