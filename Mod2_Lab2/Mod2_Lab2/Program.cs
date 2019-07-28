using System;

namespace Mod2_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coffee sizes: 1. Small 2. Medium 3. Large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                    cost += 25;
                    break;
                case "2":
                    cost += 50;
                    break;
                case "3":
                case "large":
                    cost += 75;
                    break;
                default:
                    Console.WriteLine("That is not a choice. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
                Console.WriteLine("Thank you for your business!");
            }
        }
    }
}
