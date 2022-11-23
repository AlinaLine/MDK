using System;

namespace _9._119
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "ценая вещь";
            string h = "н";
            word = word.Insert(3, h);
            Console.Write(word);
        }
    }
}
