using System;
using System.Collections.Generic;

namespace Reading_All_the_countries_from_CSV_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\PluralSight\C# Track\Beginning C# Collections\Ex Material\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            Dictionary<string, Country> belad = reader.ReadAllCountries();

            Console.WriteLine("Enter the key of the country ");

            string UserInput = Console.ReadLine();

            //TryGetValue return true or false and have an output parameter to return the Value of type x  if True

            var exists = belad.TryGetValue(UserInput, out Country country);

            if (!exists)
            {
                Console.WriteLine(" the country doesnt exist");

            }
            else
            {
                Console.WriteLine($"Country found    \n {country.Name}:{country.Population}");
            }







        }
    }
}
