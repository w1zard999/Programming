using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes.Geometry;
using static System.Windows.Forms.DataFormats;

namespace Programming.View.Panels
{
    public partial class ClassesControl : UserControl
    {
        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Rectangle _currentRectangle;

        private Model.Classes.Film[] _films;
        private Model.Classes.Film _currentFilm;

        public ClassesControl()
        {
            InitializeComponent();

            _rectangles = new Model.Classes.Rectangle[5];
            InitializeRectangles();

            _films = new Model.Classes.Film[3];
            InitializeFilms();

            RefreshRectanglesListBoxes();
        }

        private void InitializeRectangles()
        {
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
            }

            _currentRectangle = _rectangles[0];
        }

        private void InitializeFilms()
        {
            _films[0] = new Model.Classes.Film("Дерево жизни", 138, 2011, "Драма, филосовская притча", 7.3);
            _films[1] = new Model.Classes.Film("Поездка в Америку", 117, 1988, "Комедия", 6.7);
            _films[2] = new Model.Classes.Film("Остров проклятых", 138, 2010, "Триллер, детектив", 8.1);

            for (int i = 0; i < _films.Length; i++)
            {
                FilmsListBox.Items.Add($"Film {i + 1}");
            }

            _currentFilm = _films[0];
        }

        private void RefreshRectanglesListBoxes()
        {
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            _currentRectangle = _rectangles[0];
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem != null)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];

                RectangleLenghtTextBox.Text = _currentRectangle.Length.ToString("F2");
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString("F2");
                TextBoxCenterCoordX.Text = _currentRectangle.Center.X.ToString("F2");
                TextBoxCenterCoordY.Text = _currentRectangle.Center.Y.ToString("F2");
                TextBoxRectangleId.Text = _currentRectangle.Id.ToString();
                RectangleColorTextBox.Text = _currentRectangle.Color;
            }

        }

        private void RectangleLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newLenght = double.Parse(RectangleLenghtTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newLenght, nameof(newLenght));
                _currentRectangle.Length = newLenght;
                RectangleLenghtTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                RectangleLenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                RectangleLenghtTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newWidth = double.Parse(RectangleWidthTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newWidth, nameof(newWidth));
                _currentRectangle.Width = newWidth;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                RectangleWidthTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void RectangleColor_TextChange(object sender, EventArgs e)
        {
            string newColor = RectangleColorTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newColor))
            {
                RectangleColorTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            _currentRectangle.Color = newColor;
            RectangleColorTextBox.BackColor = System.Drawing.Color.White;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
                throw new ArgumentException("Массив прямоугольников пустой или не существует");

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void RectangleFindButton_Click(object sender, MouseEventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilmsListBox.SelectedItem != null)
            {
                _currentFilm = _films[FilmsListBox.SelectedIndex];

                FilmTitleTextBox.Text = _currentFilm.Title;
                FilmDurationTextBox.Text = _currentFilm.DurationInMinutes.ToString();
                FilmReleaseYearTextBox.Text = _currentFilm.ReleaseYear.ToString();
                FilmGenreTextBox.Text = _currentFilm.Genre;
                FilmRatingTextBox.Text = _currentFilm.Rating.ToString("F1");
            }

        }

        private void FilmDurationInMinutes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newParseValue = int.Parse(FilmDurationTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newParseValue, nameof(newParseValue));
                _currentFilm.DurationInMinutes = newParseValue;
                FilmDurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                FilmDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                FilmDurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmReleaseYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newParseValue = int.Parse(FilmReleaseYearTextBox.Text.Trim());
                Model.Classes.Validator.AssertValueInRange(newParseValue, 1900, DateTime.Now.Year, nameof(newParseValue));
                _currentFilm.ReleaseYear = newParseValue;
                FilmReleaseYearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                FilmReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                FilmReleaseYearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newParseValue = double.Parse(FilmRatingTextBox.Text.Trim());
                Model.Classes.Validator.AssertValueInRange(newParseValue, 0, 10, nameof(newParseValue));
                _currentFilm.Rating = newParseValue;
                FilmRatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentOutOfRangeException)
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                FilmRatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FilmTitle_TextChange(object sender, EventArgs e)
        {
            string newTitle = FilmTitleTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newTitle))
            {
                FilmTitleTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            _currentFilm.Title = newTitle;
            FilmTitleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void FilmGenre_TextChange(object sender, EventArgs e)
        {
            string newGenre = FilmGenreTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(newGenre))
            {
                FilmGenreTextBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            _currentFilm.Genre = newGenre;
            FilmGenreTextBox.BackColor = System.Drawing.Color.White;
        }

        private int FindFilmWithMaxRating(Model.Classes.Film[] films)
        {
            if (films == null || films.Length == 0)
                throw new ArgumentException("Массив фильмов пустой или не существует");

            int maxIndex = 0;
            double maxRating = films[0].Rating;

            for (int i = 1; i < films.Length; i++)
            {
                if (films[i].Rating > maxRating)
                {
                    maxRating = films[i].Rating;
                    maxIndex = i;
                }
            }

            return maxIndex;
        }

        private void FilmFindButton_Click(object sender, MouseEventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }
    }
}
