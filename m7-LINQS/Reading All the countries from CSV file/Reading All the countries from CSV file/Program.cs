using Pluralsight.BegCShCollections.ReadAllCountries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reading_All_the_countries_from_CSV_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\PluralSight\C# Track\Beginning C# Collections\Ex Material\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);

            List<Country> belad = reader.ReadAllCountries();

            // different linq syntax
            /*
             -Calling LINQ methods explicitly
            var filteredCountries1 = belad.Where(x => !x.Name.Contains(','));

            -Using LINQ Syntax  
            var filteredCountries2 = from balad in belad
                                     where !balad.Name.Contains(',')
                                     select balad;
            */

           foreach (Country country in belad.OrderBy(x=>x.Name))
            {
                Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}:{country.Name}");
            }
        }
    }
}
