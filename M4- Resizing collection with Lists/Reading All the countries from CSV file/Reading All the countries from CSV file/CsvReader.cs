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

            string Name = parts[0];
            string Code = parts[1];
            string Region = parts[2];
            int    Population = int.Parse(parts[3]);


        return new Country (Name, Code,Region,Population);

        }

        public List<Country> ReadAllCountries()
        {
            List < Country > Countries = new List<Country>();

            using (StreamReader sr = new StreamReader(_CsvFilePath))
            {
                // readin header
                sr.ReadLine();

                string Line = sr.ReadLine();

                while ( Line != null)
                {
                    Countries.Add (ReadCountryFromCsvLine(Line));
                }
            }

                return Countries;

        }


    }

}
