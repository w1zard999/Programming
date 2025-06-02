using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Time
    {
        /// <summary>
        /// Часы.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Минуты.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Секунды.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает часы.
        /// </summary>
        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hours));
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает минуты.
        /// </summary>
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Minutes));
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает секунды.
        /// </summary>
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                Validator.AssertValueInRange(value, 0, 59, nameof(Seconds));
                _seconds = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Time() { }

        /// <summary>
        /// Конструктор с передачей часов, минут и секунд.
        /// </summary>
        /// <param name="hours">Значение часов.</param>
        /// <param name="minutes">Значение минут.</param>
        /// <param name="seconds">Значение секунд.</param>
        public Time(int hours, int minutes, int seconds)
        {
            this.Hours = hours;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }
    }
}
