using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenCountries
{
    class CsvReader
    {
        private string _csvFilePath;

        public CsvReader(string FilePath)
        {
            this._csvFilePath = FilePath;
        }

        public Country[] ReadFirstNCountries(int nCountries)
        {
            Country[] countries = new Country[10];
            using(System.IO.StreamReader esm= new System.IO.StreamReader(_csvFilePath))
            {
                //to read the header which i am not intersted into
                esm.ReadLine();

                for(int i=0;i<10;i++)
                {
                    string Line= esm.ReadLine();
                    countries[i] = ReadCountryFromString(Line);
                }
            }
            return countries;
        }

        public Country ReadCountryFromString(string CsvLine)

        {

           
            string[] parts = CsvLine.Split(",");

            string name = parts[0];
            string code = parts[1];
            string Region = parts[2];
            int Population = int.Parse(parts[3]);

            return new Country(name, code, Region, Population);

            
        }
    }
}
