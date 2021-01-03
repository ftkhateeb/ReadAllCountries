using System;
using System.Collections.Generic;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DaysOfWeek = new List<String>();

            DaysOfWeek.Add("Monday");

            DaysOfWeek.Add("SunDay");

            DaysOfWeek.Add("TuesDay");

            DaysOfWeek.Add("Wednesday");

            DaysOfWeek.Add("Thursday");

            DaysOfWeek.Add("Friday");

            DaysOfWeek.Add("Saturday");

            //OR 

            List<string> DaysOfWeek2 = new List<string>
            {
                "Monday",
                "Sunday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",


            };

            foreach( string Day in DaysOfWeek)
            {
                Console.WriteLine(Day);
               
            }

            Console.WriteLine("end of first loop");

            foreach (string Day in DaysOfWeek2)
            {
                Console.WriteLine(Day);
            }

        }
    }
}
