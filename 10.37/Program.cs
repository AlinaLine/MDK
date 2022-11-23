using System;

namespace _10._37
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = Console.WindowWidth;
            var h = Console.WindowHeight;
            for (var i = 0; i < h; ++i)
            {
                for (var j = 0; j < w; ++j)
                {
                    if ((i > 0 && i < h - 1) && (j > 0 && j < w - 1)) Console.Write(' ');
                    else Console.Write('*');
                }
            }
            Console.ReadKey();
        }
    }
}
