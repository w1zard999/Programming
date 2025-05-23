using System.Reflection;
using System.Runtime.CompilerServices;
using Programming.Model;
using Programming.Model.Classes;
using static System.Windows.Forms.DataFormats;

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
                double centerCoordX = random.Next(0, 256);
                double centerCoordY = random.Next(0, 256);
                int randomColorIndex = random.Next(Enum.GetValues(typeof(Model.Color)).Length);
                Model.Color randomColor = (Model.Color)randomColorIndex;
                _rectangles[i] = new Model.Classes.Rectangle(length, width, randomColor.ToString(), new Point2D(centerCoordX, centerCoordY));
            }

            _films[0] = new Model.Classes.Film("Дерево жизни", 138, 2011, "Драма, филосовская притча", 7.3);
            _films[1] = new Model.Classes.Film("Поездка в Америку", 117, 1988, "Комедия", 6.7);
            _films[2] = new Model.Classes.Film("Остров проклятых", 138, 2010, "Триллер, детектив", 8.1);

            for (int i = 0; i < _films.Length; i++)
            {
                FilmsListBox.Items.Add($"Film {i + 1}");
            }

            _currentFilm = _films[0];

            RefreshRectanglesListBoxes();
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0; // Устанавливаем первый элемент по умолчанию
            }
        }

        private void RefreshRectanglesListBoxes()
        {
            RectanglesListBox1.Items.Clear();
            RectanglesListBox.Items.Clear();

            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox1.Items.Add($"{i + 1}: (X= {_rectangles[i].Center.X:F2}; Y= {_rectangles[i].Center.Y:F2}; W= {_rectangles[i].Width:F0}; L= {_rectangles[i].Length:F0})");
            }

            _currentRectangle = _rectangles[0];
        }

        private void ClearRectangleListBox()
        {
            LengthRectangleTextBox.Text = "";
            WidthRectangleTextBox.Text = "";
            XCoordRectangleTextBox.Text = "";
            YCoordRectangleTextBox.Text = "";
            RectangleWidthTextBox.Text = "";
            IdRectangleTextBox.Text = "";
            LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
            WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
            YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
            XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
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
            ValuesListBox.Items.Clear(); // Очищаем список перед добавлением новых элементов
            Array array = Enum.GetValues(enumType); // Получаем значения enum
            foreach (var element in array)
            {
                ValuesListBox.Items.Add(element); // Добавляем каждый элемент в список
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
                DayOfTheWeekInfo.Text = "Нет такого дня недели";
            }
            else if (Enum.TryParse(inputText, out Model.Weekday weekday))
            {
                DayOfTheWeekInfo.Text = $"Это день недели ({weekday} = {(int)weekday + 1})";
            }
            else
            {
                DayOfTheWeekInfo.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = (string)SeasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case "Summer":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autum":
                    this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69); // Оранжевый цвет
                    break;
                case "Winter":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69); // Зелёный цвет
                    break;
                default:
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Выберите время года.");
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

        private void RectanglesListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox1.SelectedIndex != -1 && RectanglesListBox1.SelectedIndex < _rectangles.Length)
                {
                _currentRectangle = _rectangles[RectanglesListBox1.SelectedIndex];

                LengthRectangleTextBox.Text = _currentRectangle.Length.ToString("F2");
                WidthRectangleTextBox.Text = _currentRectangle.Width.ToString("F2");
                XCoordRectangleTextBox.Text = _currentRectangle.Center.X.ToString("F2");
                YCoordRectangleTextBox.Text = _currentRectangle.Center.Y.ToString("F2");
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectanglesListBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (RectanglesListBox1.IndexFromPoint(e.Location) == -1)
            {
                ClearRectangleListBox();
                RectanglesListBox1.SelectedIndex = -1;
            }
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newLenght = double.Parse(LengthRectangleTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newLenght, nameof(newLenght));
                _currentRectangle.Length = newLenght;
                LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                if (RectanglesListBox1.SelectedIndex >= 0)
                {
                    RectanglesListBox1.Items[RectanglesListBox1.SelectedIndex] = $"{RectanglesListBox1.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                LengthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                LengthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newWidth = double.Parse(WidthRectangleTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newWidth, nameof(newWidth));
                _currentRectangle.Width = newWidth;
                WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
                if (RectanglesListBox1.SelectedIndex >= 0)
                {
                    RectanglesListBox1.Items[RectanglesListBox1.SelectedIndex] = $"{RectanglesListBox1.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (Exception)
            {
                WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void XCoordRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newCoordX = double.Parse(XCoordRectangleTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newCoordX, nameof(newCoordX));
                _currentRectangle.Center.X = newCoordX;
                XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                if (RectanglesListBox1.SelectedIndex >= 0)
                {
                    RectanglesListBox1.Items[RectanglesListBox1.SelectedIndex] = $"{RectanglesListBox1.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                }
            }
            catch (Exception)
            {
                XCoordRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YCoordRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newCoordY = double.Parse(YCoordRectangleTextBox.Text.Trim());
                Model.Classes.Validator.AssertOnPositiveValue(newCoordY, nameof(newCoordY));
                _currentRectangle.Center.Y = newCoordY;
                YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                if (RectanglesListBox1.SelectedIndex >= 0)
                {
                    RectanglesListBox1.Items[RectanglesListBox1.SelectedIndex] = $"{RectanglesListBox1.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                }
            }
            catch (Exception)
            {
                YCoordRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                Model.Classes.Rectangle[] newRectangles = new Model.Classes.Rectangle[_rectangles.Length + 1];
                for (int i = 0; i != _rectangles.Length; i++)
                {
                    newRectangles[i] = _rectangles[i];
                }

                _rectangles = newRectangles;
                var newId = _rectangles.Length + 1;
                RectanglesListBox1.Items.Add($"{newId + 1}: (X= {_rectangles[newId].Center.X:F2}; Y= {_rectangles[newId].Center.Y:F2}; W= {_rectangles[newId].Width:F0}; L= {_rectangles[newId].Length:F0})");
                RefreshRectanglesListBoxes();
                ClearRectangleListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании: {ex.Message}");
            }
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = RectanglesListBox1.SelectedIndex;
                if (selectedIndex < 0 || selectedIndex >= _rectangles.Length)
                    throw new ArgumentOutOfRangeException("Не выбран прямоугольник для удаления");

                Model.Classes.Rectangle[] newRectangles = new Model.Classes.Rectangle[_rectangles.Length - 1];
                for (int i = 0, j = 0; i < _rectangles.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newRectangles[j++] = _rectangles[i];
                    }
                }

                _rectangles = newRectangles;
                RefreshRectanglesListBoxes();
                ClearRectangleListBox();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при удалении: {ex.Message}");
            }
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.TabIndex == 1 || TabControl1.TabIndex == 2)
            {
                RefreshRectanglesListBoxes();
            }
        }
    }
}