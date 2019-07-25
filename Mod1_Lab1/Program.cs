using System;

namespace Mod1_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            firstName = "C";
            lastName = "S";
            age = 57;
            street = "100 Main Street";
            city = "Boston";
            country = "USA";
            birthDate = new DateTime(1867, 4, 18);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine("{0} years old.", age);
            Console.WriteLine(street + ", " + city + ", " + country);
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
