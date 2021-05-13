using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr6
{
    
    public class Plane
    {

        public string Name_plane { get; set; }
        public string Country_departure { get; set; }
        public string Country_arrival { get; set; }
        public int Flight_number { get; set; }
        public int pepolnumber_of_seats { get; set; }
        public int lux_seats { get; set; }
        public bool eat { get; set; }
      
        public double Getseats()
        {
            return pepolnumber_of_seats + lux_seats;
        }

        public Plane (string name, string country, string region,
        int population, int yearIncome, int square,
        bool hasPort)
        {
            Name_plane = name;
            Country_departure = country;
            Country_arrival = region;
            Flight_number = population;
            pepolnumber_of_seats = yearIncome;
            lux_seats = square;
            eat = hasPort;
           
        }

        public Plane()
        {
        }
    }
}
