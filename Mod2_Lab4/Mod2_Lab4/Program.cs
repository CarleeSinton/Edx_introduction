using System;

namespace Mod2_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            // while loop example
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            // do while loop example
            int x = 0;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x < 5);
        }
    }
}
