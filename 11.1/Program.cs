using System;

namespace _11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInts = { 37, 0, 50, 46, 34, 46, 0, 13 }; 
            for (int i = 0; i < arrayInts.Length; i++) 
            { Console.WriteLine($"{ i + 1}){ arrayInts[i]}");
        }
    }
    }
}
