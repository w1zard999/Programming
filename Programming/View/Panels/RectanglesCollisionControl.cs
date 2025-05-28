using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private Model.Classes.Rectangle[] _rectangles;
        private Model.Classes.Rectangle _currentRectangle;
        private List<Panel> _rectanglePanels;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
            _rectanglePanels = new List<Panel>();
            InitializeRectangles();
        }

        private void InitializeRectangles()
        {
            _rectangles = new Model.Classes.Rectangle[5];
            for (int i = 0; i < _rectangles.Length; i++)
            {
                _rectangles[i] = RectangleFactory.Randomize();
            }

            for (int i = 0; i < _rectangles.Length; i++)
            {
                var rect = _rectangles[i];
                Panel rectanglePanel = new Panel();
                rectanglePanel.Width = (int)rect.Width;
                rectanglePanel.Height = (int)rect.Length;
                rectanglePanel.Location = new Point((int)rect.Center.X - rectanglePanel.Width / 2, (int)rect.Center.Y - rectanglePanel.Height / 2);
                rectanglePanel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
                CanvasPanel.Controls.Add(rectanglePanel);
                _rectanglePanels.Add(rectanglePanel);
            }

            RefreshRectanglesListBox();
            FindCollisions();
        }

        private void UpdateRectangleInfo(Model.Classes.Rectangle rectangle)
        {
            if (rectangle == null) return;

            LengthRectangleTextBox.Text = rectangle.Length.ToString("F2");
            WidthRectangleTextBox.Text = rectangle.Width.ToString("F2");
            XCoordRectangleTextBox.Text = rectangle.Center.X.ToString("F2");
            YCoordRectangleTextBox.Text = rectangle.Center.Y.ToString("F2");
            IdRectangleTextBox.Text = rectangle.Id.ToString();

            LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
            WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
            XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
            YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void ClearRectangleInfo()
        {
            LengthRectangleTextBox.Text = string.Empty;
            WidthRectangleTextBox.Text = string.Empty;
            XCoordRectangleTextBox.Text = string.Empty;
            YCoordRectangleTextBox.Text = string.Empty;
            IdRectangleTextBox.Text = string.Empty;

            LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
            WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
            XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
            YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
        }

        private void RefreshRectanglesListBox()
        {
            RectanglesListBox.Items.Clear();
            for (int i = 0; i < _rectangles.Length; i++)
            {
                RectanglesListBox.Items.Add($"{i + 1}: (X= {_rectangles[i].Center.X:F2}; Y= {_rectangles[i].Center.Y:F2}; W= {_rectangles[i].Width:F0}; L= {_rectangles[i].Length:F0})");
            }
            if (_rectangles.Length > 0)
            {
                RectanglesListBox.SelectedIndex = 0;
            }

            _currentRectangle = _rectangles[0];
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1 || RectanglesListBox.SelectedIndex >= _rectangles.Length)
            {
                ClearRectangleInfo();
                return;
            }

            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            UpdateRectangleInfo(_currentRectangle);
        }

        private void RectanglesListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (RectanglesListBox.IndexFromPoint(e.Location) == -1)
            {
                ClearRectangleInfo();
                RectanglesListBox.SelectedIndex = -1;
            }
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (RectanglesListBox.SelectedIndex == -1)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(LengthRectangleTextBox.Text))
                        {
                            var newCoordY = double.Parse(YCoordRectangleTextBox.Text);
                            Validator.AssertOnPositiveValue(newCoordY, nameof(newCoordY));
                            LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                        }
                    }
                    catch
                    {
                        LengthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                else
                {
                    var newLenght = double.Parse(LengthRectangleTextBox.Text.Trim());
                    Model.Classes.Validator.AssertOnPositiveValue(newLenght, nameof(newLenght));
                    _currentRectangle.Length = newLenght;
                    LengthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    if (RectanglesListBox.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[RectanglesListBox.SelectedIndex].Height = (int)newLenght;
                    }
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{RectanglesListBox.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                    FindCollisions();
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

                if (RectanglesListBox.SelectedIndex == -1)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(WidthRectangleTextBox.Text))
                        {
                            var newWidth = double.Parse(WidthRectangleTextBox.Text);
                            Validator.AssertOnPositiveValue(newWidth, nameof(newWidth));
                            WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
                        }
                    }
                    catch
                    {
                        WidthRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                else
                {
                    var newWidth = double.Parse(WidthRectangleTextBox.Text.Trim());
                    Model.Classes.Validator.AssertOnPositiveValue(newWidth, nameof(newWidth));
                    _currentRectangle.Width = newWidth;
                    WidthRectangleTextBox.BackColor = System.Drawing.Color.White;
                    if (RectanglesListBox.SelectedIndex < _rectanglePanels.Count)
                    {
                        _rectanglePanels[RectanglesListBox.SelectedIndex].Width = (int)newWidth;
                    }
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{RectanglesListBox.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                    FindCollisions();
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
                if (RectanglesListBox.SelectedIndex == -1)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(XCoordRectangleTextBox.Text))
                        {
                            var newCoordX = double.Parse(XCoordRectangleTextBox.Text);
                            Validator.AssertOnPositiveValue(newCoordX, nameof(newCoordX));
                            XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                        }
                    }
                    catch
                    {
                        XCoordRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                else
                {
                    var newCoordX = double.Parse(XCoordRectangleTextBox.Text.Trim());
                    Model.Classes.Validator.AssertOnPositiveValue(newCoordX, nameof(newCoordX));
                    _currentRectangle.Center.X = newCoordX;
                    XCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                    if (RectanglesListBox.SelectedIndex < _rectanglePanels.Count)
                    {
                        var panel = _rectanglePanels[RectanglesListBox.SelectedIndex];
                        panel.Location = new Point(
                            (int)newCoordX - panel.Width / 2,
                            panel.Location.Y);
                    }
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{RectanglesListBox.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                    FindCollisions();
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
                if (RectanglesListBox.SelectedIndex == -1)
                {
                    try
                    {
                        if (!string.IsNullOrWhiteSpace(YCoordRectangleTextBox.Text))
                        {
                            var newCoordY = double.Parse(YCoordRectangleTextBox.Text);
                            Validator.AssertOnPositiveValue(newCoordY, nameof(newCoordY));
                            YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                        }
                    }
                    catch
                    {
                        YCoordRectangleTextBox.BackColor = System.Drawing.Color.LightPink;
                    }
                }
                else
                {
                    var newCoordY = double.Parse(YCoordRectangleTextBox.Text.Trim());
                    Model.Classes.Validator.AssertOnPositiveValue(newCoordY, nameof(newCoordY));
                    _currentRectangle.Center.Y = newCoordY;
                    YCoordRectangleTextBox.BackColor = System.Drawing.Color.White;
                    if (RectanglesListBox.SelectedIndex < _rectanglePanels.Count)
                    {
                        var panel = _rectanglePanels[RectanglesListBox.SelectedIndex];
                        panel.Location = new Point(
                            panel.Location.X,
                            (int)newCoordY - panel.Height / 2);
                    }
                    RectanglesListBox.Items[RectanglesListBox.SelectedIndex] = $"{RectanglesListBox.SelectedIndex + 1}: (X= {_currentRectangle.Center.X:F2}; Y= {_currentRectangle.Center.Y:F2}; W= {_currentRectangle.Width:F0}; L= {_currentRectangle.Length:F0})";
                    FindCollisions();
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
                for (int i = 0; i < _rectangles.Length; i++)
                {
                    newRectangles[i] = _rectangles[i];
                }

                Model.Classes.Rectangle newRectangle;

                if (ValidateRectangleInput())
                {
                    Random random = new Random();
                    double length = double.Parse(LengthRectangleTextBox.Text.Trim());
                    double width = double.Parse(WidthRectangleTextBox.Text.Trim());
                    double centerCoordX = double.Parse(XCoordRectangleTextBox.Text.Trim());
                    double centerCoordY = double.Parse(YCoordRectangleTextBox.Text.Trim());
                    int randomColorIndex = random.Next(Enum.GetValues(typeof(Model.Color)).Length);
                    Model.Color randomColor = (Model.Color)randomColorIndex;
                    newRectangle = new Model.Classes.Rectangle(length, width, randomColor.ToString(), new Point2D(centerCoordX, centerCoordY));
                }
                else
                {
                    newRectangle = RectangleFactory.Randomize();
                }

                newRectangles[_rectangles.Length] = newRectangle;
                _rectangles = newRectangles;

                AddRectanglePanel(newRectangle);
                RefreshRectanglesListBox();
                FindCollisions();
                RectanglesListBox.SelectedIndex = _rectangles.Length - 1;
                RectanglesListBox.SelectedIndex = _rectangles.Length - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при создании: {ex.Message}");
            }
        }

        private bool ValidateRectangleInput()
        {
            return !string.IsNullOrWhiteSpace(XCoordRectangleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(YCoordRectangleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(WidthRectangleTextBox.Text) &&
                   !string.IsNullOrWhiteSpace(LengthRectangleTextBox.Text) &&
                   RectanglesListBox.SelectedIndex == -1;
        }

        private void AddRectanglePanel(Model.Classes.Rectangle rectangle)
        {
            var panel = new Panel
            {
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Length,
                Location = new Point((int)rectangle.Center.X - (int)rectangle.Width / 2, (int)rectangle.Center.Y - (int)rectangle.Length / 2),
                BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127)
            };

            CanvasPanel.Controls.Add(panel);
            _rectanglePanels.Add(panel);
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedIndex = RectanglesListBox.SelectedIndex;
                if (selectedIndex < 0 || selectedIndex >= _rectangles.Length)
                    throw new ArgumentOutOfRangeException("Не выбран прямоугольник для удаления");

                if (selectedIndex < _rectanglePanels.Count)
                {
                    CanvasPanel.Controls.Remove(_rectanglePanels[selectedIndex]);
                    _rectanglePanels.RemoveAt(selectedIndex);
                }

                Model.Classes.Rectangle[] newRectangles = new Model.Classes.Rectangle[_rectangles.Length - 1];
                for (int i = 0, j = 0; i < _rectangles.Length; i++)
                {
                    if (i != selectedIndex)
                    {
                        newRectangles[j++] = _rectangles[i];
                    }
                }

                _rectangles = newRectangles;
                RefreshRectanglesListBox();
                ClearRectangleInfo();
                FindCollisions();
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

        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
            }

            for (int i = 0; i < _rectangles.Length; i++)
            {
                for (int j = i + 1; j < _rectangles.Length; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        if (i < _rectanglePanels.Count)
                            _rectanglePanels[i].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                        if (j < _rectanglePanels.Count)
                            _rectanglePanels[j].BackColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
