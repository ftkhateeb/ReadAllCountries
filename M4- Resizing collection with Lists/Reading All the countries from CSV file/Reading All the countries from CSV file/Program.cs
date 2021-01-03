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

            List<Country> belad = reader.ReadAllCountries();

           foreach (Country country in belad)
            {
                Console.WriteLine($"")
            }
        }
    }
}
