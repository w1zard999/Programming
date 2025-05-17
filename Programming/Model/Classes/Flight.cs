using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        public string Departure { get; set; }
        public string Destination { get; set; }
        private int _flightTimeInMinutes;

        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }

        public Flight() { }

        public Flight(string departure, string destination, int flightTimeInMinutes)
        {
            this.Departure = departure;
            this.Destination = destination;
            this.FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
