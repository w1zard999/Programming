using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationInMinutes;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задаёт продолжительность фильма в минутах.
        /// </summary>
        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выхода фильма.
        /// </summary>
        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт рейтинг фильма.
        /// </summary>
        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Film() { }

        /// <summary>
        /// Конструктор с полным набором свойств.
        /// </summary>
        /// <param name="title">Название фильма.</param>
        /// <param name="durationInMinutes">Продолжительность фильма в минутах.</param>
        /// <param name="releaseYear">Год выхода фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма.</param>
        public Film(string title, int durationInMinutes, int releaseYear, string genre, double rating)
        {
            this.Title = title;
            this.DurationInMinutes = durationInMinutes;
            this.ReleaseYear = releaseYear;
            this.Genre = genre;
            this.Rating = rating;
        }
    }
}
