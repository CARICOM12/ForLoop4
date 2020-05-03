using System;

namespace ForLoop4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /*
            for (int i = 100; i >= 5; i /= 2)
            {
                Console.WriteLine(i);
            }
            */

            for (int b = 100; b <= 5; b *=2)
            {
                Console.WriteLine(b);
            }

            for (int c = 100; c <= 5; c -= 2)
            {
                Console.WriteLine(c);
            }

            for (int d = 100; d <= 5; d += 2)
            {
                Console.WriteLine(d);
            }
        }
    }
}
