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

        public MainForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(MainForm_Load);

            _rectangles = new Model.Classes.Rectangle[5];
            Random random = new Random();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = random.NextDouble() * 100;
                double width = random.NextDouble() * 100;
                int randomColorIndex = random.Next(Enum.GetValues(typeof(Model.Color)).Length);
                Model.Color randomColor = (Model.Color)randomColorIndex;
                _rectangles[i] = new Model.Classes.Rectangle(length, width, randomColor.ToString());
            }

            // Добавление элементов в ListBox
            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }

            // Установка текущего прямоугольника
            _currentRectangle = _rectangles[0];
        }

        private void MainForm_Load(object? sender, EventArgs e)
        {
            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0; // Устанавливаем первый элемент по умолчанию
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

                RectangleLenghtTextBox.Text = _currentRectangle.Length.ToString("F0");
                RectangleWidthTextBox.Text = _currentRectangle.Width.ToString("F0");
                RectangleColorTextBox.Text = _currentRectangle.Color;
            }

        }

        private void RectangleLenghtTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var newLenght = double.Parse(RectangleLenghtTextBox.Text.Trim());
                if (newLenght < 0 || newLenght == 0)
                    throw new ArgumentOutOfRangeException("Значение должно быть больше или не равно нулю");
                _currentRectangle.Length = newLenght;
                RectangleLenghtTextBox.BackColor = System.Drawing.Color.White; // Возвращаем нормальный белый фон
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
                if (newWidth < 0 || newWidth == 0)
                    throw new ArgumentOutOfRangeException("Значение должно быть больше или не равно нулю");
                _currentRectangle.Width = newWidth;
                RectangleWidthTextBox.BackColor = System.Drawing.Color.White; // Возвращаем нормальный белый фон
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
    }
}