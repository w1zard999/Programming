using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class EnumsControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="EnumsControl"/>.
        /// </summary>
        public EnumsControl()
        {
            InitializeComponent();

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обработчик события изменения выбранного индекса списка enums.
        /// Заполняет список значений выбранным типом перечисления.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события.</param>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EnumsListBox.SelectedItem == null) return;

            string selectedText = (string)EnumsListBox.SelectedItem;

            switch (selectedText)
            {
                case "Color":
                    AddToValueList(typeof(Model.Enums.Color));
                    break;
                case "Genre":
                    AddToValueList(typeof(Model.Enums.Genre));
                    break;
                case "Season":
                    AddToValueList(typeof(Model.Enums.Season));
                    break;
                case "SmartphoneManufacturer":
                    AddToValueList(typeof(Model.Enums.SmartphoneManufacturer));
                    break;
                case "StudentEducationType":
                    AddToValueList(typeof(Model.Enums.StudentEducationType));
                    break;
                case "Weekday":
                    AddToValueList(typeof(Model.Enums.Weekday));
                    break;
            }
        }

        /// <summary>
        /// Заполняет список значениями указанного типа перечисления.
        /// </summary>
        /// <param name="enumType">Тип перечисления.</param>
        private void AddToValueList(Type enumType)
        {
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(Enum.GetNames(enumType));
        }

        /// <summary>
        /// Обработчик события выбора нового значения в списке values.
        /// Устанавливает номер выбранного значения в соответствующее текстовое поле.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события.</param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem != null)
            {
                var text = ValuesListBox.SelectedIndex + 1;
                ValueTextBox.Text = text.ToString();
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки анализа введённого текста.
        /// Анализирует ввод пользователя относительно типов перечислений и выводит сообщение.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события.</param>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            string inputText = TextParseBox.Text.Trim();

            if (int.TryParse(inputText, out int number))
            {
                DayOfTheWeekInfo.Text = "Нет такого дня недели";
            }
            else if (Enum.TryParse(inputText, out Weekday weekday))
            {
                DayOfTheWeekInfo.Text = $"Это день недели ({weekday} = {(int)weekday + 1})";
            }
            else
            {
                DayOfTheWeekInfo.Text = "Нет такого дня недели";
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки сезона.
        /// Меняет фон формы в зависимости от выбранного времени года.
        /// </summary>
        /// <param name="sender">Источник события.</param>
        /// <param name="e">Параметры события.</param>
        private void SeasonButton_Click(object sender, EventArgs e)
        {
            string selectedSeason = (string)SeasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case "Summer":
                    this.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case "Autumn": // Исправлено Autum → Autumn
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
