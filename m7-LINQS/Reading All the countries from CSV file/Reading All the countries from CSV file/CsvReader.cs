using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

/* the class contains :
 * 
 *1) constructor that takes the file path and initialize a string variable with this path)
 *2) a method to read one line (the line is passed to it as an argument and it is not the method's responsibility to get it from the file)
 * and then parse it into a a country object (read country from CSV line)
 *3) a method that is responsible to read the next line in the file by using (using stream reader) and then call the readCountry from line method
 * then add this country to a preinstantiated List of countries, after this loop, the method returns the List of countries.
 */
namespace Reading_All_the_countries_from_CSV_file
{
    class CsvReader
    {
         private string _CsvFilePath;

        public CsvReader (string CsvFilePath)
        {
            this._CsvFilePath = CsvFilePath;

        }

        public Country ReadCountryFromCsvLine(string CsvLine)
        {
            string[] parts = CsvLine.Split(",");
            string Name;
            string Code;
            string Region;
            string PopText;

            switch (parts.Length)
            {
                case 4:
                    Name = parts[0];
                    Code = parts[1];
                    Region = parts[2];
                    PopText = parts[3];

                    break;
                case 5:
                    Name = parts[0]+","+parts[1];
                    Code = parts[2];
                    Region = parts[3];
                    PopText = parts[4];
                    break;
                default:
                    throw new Exception(" can't parse country from CSV line");  
            }

            // returns zero if parse failed 
            int.TryParse(PopText, out int Population);


        return new Country (Name, Code,Region,Population);

        }

        public List<Country> ReadAllCountries()
        {
            List < Country > Countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_CsvFilePath))
            {
                // readin header
                sr.ReadLine();
                string Line;
                while ( (Line = sr.ReadLine()) != null)
                {
                    Countries.Add (ReadCountryFromCsvLine(Line));
                }
            }

                return Countries;

        }


    }

}
