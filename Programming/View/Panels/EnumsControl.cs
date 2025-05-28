using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
                ValuesListBox.SelectedIndex = 0;
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.SelectedIndex = 0;
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
            ValuesListBox.Items.Clear();
            Array array = Enum.GetValues(enumType);
            foreach (var element in array)
            {
                ValuesListBox.Items.Add(element);
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
                    this.BackColor = System.Drawing.Color.FromArgb(226, 156, 69);
                    break;
                case "Winter":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case "Spring":
                    this.BackColor = System.Drawing.Color.FromArgb(85, 156, 69);
                    break;
                default:
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Выберите время года.");
                    break;
            }
        }
    }
}
