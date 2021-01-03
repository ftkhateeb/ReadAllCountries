using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Text;

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

            switch ( parts.Length)
            {
                case 4:
                    Name = parts[0];
                    Code = parts[1];
                    Region = parts[2];
                    PopText = parts[3];
                    break;

                case 5:
                    Name = parts[0] + "," + parts[1];
                    Code = parts[2];
                    Region = parts[3];
                    PopText = parts[4];
                    break;

                default:

                    throw new Exception($" Can't parse country from csvLine: {CsvLine}");
            }

            //try parse writes 0 if failed to parse

            int.TryParse(PopText, out int Population);

        return new Country (Name, Code,Region,Population);

        }

        public Dictionary<string,Country> ReadAllCountries()
        {
            Dictionary <string, Country > Countries = new Dictionary<string,Country>();

           using (StreamReader sr = new StreamReader(_CsvFilePath))
            {
                // readin header
                sr.ReadLine();
                string Line;
                while ((Line = sr.ReadLine()) != null)
                {
                    Country country = ReadCountryFromCsvLine(Line);
                    Countries.Add(country.Code, country);
                }
            }

                return Countries;

        }


    }

}
