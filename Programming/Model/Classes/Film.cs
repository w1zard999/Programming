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
                Validator.AssertOnPositiveValue(value, nameof(DurationInMinutes));
                _durationInMinutes = value;
            }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(ReleaseYear));
                _releaseYear = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
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
