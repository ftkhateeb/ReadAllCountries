using System;
using System.Collections.Generic;
using System.Text;

namespace Reading_All_the_countries_from_CSV_file
{
    class Country
    {
        public string Name { get; }

        public string Code { get; }

        public string Region { get;}

        public int Population { get; }


        public Country(string name, string code, string region, int population)
        {
            this.Name = name;
            this.Code = code;
            Region = region;
            Population = population;

        }

    }
}
