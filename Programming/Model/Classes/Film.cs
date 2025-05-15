using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Film
    {
        public string Title { get; set; }
        private int _durationInMinutes;
        private int _releaseYear;
        public string Genre { get; set; }
        private double _rating;

        public int DurationInMinutes
        {
            get { return _durationInMinutes; }
            set
            {
                if (value < 0) throw new ArgumentException("Продолжительность не может быть отрицательной");
                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException($"Год выпуска должен быть между 1900 и {DateTime.Now.Year}");
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Рейтинг должен быть между 0 и 10");
                _rating = value;
            }
        }

        public Film() { }

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
