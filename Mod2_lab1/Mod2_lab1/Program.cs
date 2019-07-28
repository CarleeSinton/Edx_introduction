using System;

namespace Mod2_lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer value and press Enter.");
            int input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("That's totally even!");
            }
            else
            {
                Console.WriteLine("That is so odd!");

            }
        }
    }
}
