using System;

namespace _3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = true;
            bool c = true;
            //а) не(А или не В и С);
            Console.WriteLine((!a || !b && c));
            //б) А и не(В и или не С);
            Console.WriteLine((a & !(b &&( b || !c))));
            //в) не(не А или В и С).
            Console.WriteLine(!(!a || b && c));

        }
    }
}
