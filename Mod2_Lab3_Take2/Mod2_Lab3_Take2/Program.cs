using System;

namespace Mod2_Lab3_Take2
{
    class Program
    {
        static void Main(string[] args)
        {
            //first part of lab - simple for loop 
            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}");
            }

            // second part of lab - nested for loop
            int outer;
            int inner;

            for (outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer / inner); inner++)
                    if ((outer % inner) == 0) break;
                if (inner > (outer / inner))
                    Console.WriteLine("{0} is prime", outer);
            }
        }
    }
}
