using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        /// <summary>
        /// Город отправления.
        /// </summary>
        public string Departure { get; set; }

        /// <summary>
        /// Город прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeInMinutes;

        /// <summary>
        /// Возвращает и задаёт продолжительность полёта в минутах.
        /// </summary>
        public int FlightTimeInMinutes
        {
            get { return _flightTimeInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(FlightTimeInMinutes));
                _flightTimeInMinutes = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Flight() { }

        /// <summary>
        /// Конструктор с параметрами маршрута и продолжительности полета.
        /// </summary>
        /// <param name="departure">Город отправления.</param>
        /// <param name="destination">Город прибытия.</param>
        /// <param name="flightTimeInMinutes">Время полёта в минутах.</param>
        public Flight(string departure, string destination, int flightTimeInMinutes)
        {
            this.Departure = departure;
            this.Destination = destination;
            this.FlightTimeInMinutes = flightTimeInMinutes;
        }
    }
}
