using System.Reflection;
using System.Runtime.CompilerServices;
using Programming.Model;
using Programming.Model.Classes;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Rectangle _currentRectangle;

        private Model.Classes.Film[] _films;
        private Model.Classes.Film _currentFilm;

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);

            _rectangles = new Model.Classes.Rectangle[5];
            _films = new Model.Classes.Film[3];

            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                double centerCoordX = length / 2;
                double centerCoordY = width / 2;
                int randomColorIndex = random.Next(Enum.GetValues(typeof(Model.Color)).Length);
                Model.Color randomColor = (Model.Color)randomColorIndex;
                _rectangles[i] = new Model.Classes.Rectangle(length, width, randomColor.ToString(), new Point2D(centerCoordX, centerCoordY));
            }

            _films[0] = new Model.Classes.Film("������ �����", 138, 2011, "�����, ����������� ������", 7.3);
            _films[1] = new Model.Classes.Film("������� � �������", 117, 1988, "�������", 6.7);
            _films[2] = new Model.Classes.Film("������ ���������", 138, 2010, "�������, ��������", 8.1);

            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            for (int i = 0; i < _films.Length; i++)
            {
                FilmsListBox.Items.Add($"Film {i + 1}");
            }

            _currentRectangle = _rectangles[0];
            _currentFilm = _films[0];
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0; // ������������� ������ ������� �� ���������
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem != null)
            {
                string selectedText = (string)EnumsListBox.SelectedItem;

                switch (selectedText)
                {
                    case "Color":
                        AddToValueList(typeof(Model.Color));
                        break;
                    case "Genre":
                        AddToValueList(typeof(Model.Genre));
                        break;
                    case "Season":
                        AddToValueList(typeof(Model.Season));
                        break;
                    case "SmartphoneManufacturer":
                        AddToValueList(typeof(Model.SmartphoneManufacturer));
                        break;
                    case "StudentEducationType":
                        AddToValueList(typeof(Model.StudentEducationType));
                        break;
                    case "Weekday":
                        AddToValueList(typeof(Model.Weekday));
                        break;
                }
            }
        }

        void AddToValueList(Type enumType)
        {
            ValuesListBox.Items.Clear(); // ������� ������ ����� ����������� ����� ���������
            Array array = Enum.GetValues(enumType); // �������� �������� enum
            foreach (var element in array)
            {
                ValuesListBox.Items.Add(element); // ��������� ������ ������� � ������
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null)
            {
                var text = ValuesListBox.SelectedIndex + 1;
                ValueTextBox.Text = text.ToString();
            }
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            string inputText = TextParseBox.Text.Trim();

            if (int.TryParse(inputText, out int number))
            {
                DayOfTheWeekInfo.Text = "��� ������ ��� ������";
            }
            else if (Enum.TryParse(inputText, out Model.Weekday weekday))
            {
                DayOfTheWeekInfo.Text = $"��� ���� ������ ({weekday} = {(int)weekday + 1})";
            }
            else
            {
                DayOfTheWeekInfo.Text = "��� ������ ��� ������";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = (string)SeasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case "Summer":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("���! ������!");
                    break;
                case "Autum":
                    this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); // ��������� ����
                    break;
                case "Winter":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("����! �������!");
                    break;
                case "Spring":
                    this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); // ������ ����
                    break;
                default:
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("�������� ����� ����.");
                    break;
            }
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
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString("F0");
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
                throw new ArgumentException("������ ��������������� ������ ��� �� ����������");

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
                throw new ArgumentException("������ ������� ������ ��� �� ����������");

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