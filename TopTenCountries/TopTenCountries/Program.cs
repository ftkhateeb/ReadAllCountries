using System;

namespace TopTenCountries
{
    class Program
    {
        static void Main(string[] args)
        {
           string filepath = @"D:\PluralSight\C# Track\Beginning C# Collections\Ex Material\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filepath);

            Country[] countries = reader.ReadFirstNCountries(10);

            foreach(Country country in countries)
            {
                Console.WriteLine($"{ country.Population}:{ country.Name}");
            }


        }
    }
}
