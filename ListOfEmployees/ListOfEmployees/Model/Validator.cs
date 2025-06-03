using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ListOfEmployees.Model
{
    public static class Validator
    {
        /// <summary>
        /// Проверяет, находится ли вещественное значение в заданном диапазоне.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Минимальное допустимое значение.</param>
        /// <param name="max">Максимальное допустимое значение.</param>
        /// <param name="propertyName">Имя свойства, которое проверяется.</param>
        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} должна быть в диапазоне от {min} до {max}.");     
        }

        /// <summary>
        /// Проверяет, содержит ли строка только латинские буквы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="maxSybmolsInString">Максимальное количество символов в строке.</param>
        /// <param name="propertyName">Имя свойства, которое проверяется.</param>
        public static void AssertStringContainsMaxLetters(string value, int maxSybmolsInString, string propertyName)
        {
            if (value.Length > maxSybmolsInString)
                throw new ArgumentException($"{propertyName} может содержать только {maxSybmolsInString} символов в строке");
        }

        /// <summary>
        /// Проверяет, что дата не позднее текущей даты.
        /// </summary>
        /// <param name="inputDate">Проверяемая дата.</param>
        /// <param name="propertyName">Имя свойства, которое проверяется.</param>
        public static void AssertDateNotLaterThanToday(DateTime inputDate, string propertyName)
        {
            DateTime minValidDate = new DateTime(1900, 1, 1);

            if (inputDate < minValidDate)
                throw new ArgumentException($"{propertyName} не может быть раньше {minValidDate:dd.MM.yyyy}.");

            if (inputDate > DateTime.Today)
                throw new ArgumentException($"{propertyName} не может быть позже текущей даты: {DateTime.Today:dd.MM.yyyy}.");
        }

        /// <summary>
        /// Проверяет, содержит ли строка только русские буквы.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства, которое проверяется.</param>
        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[А-Яа-я\s\-]+$"))
                throw new ArgumentException($"{propertyName} может содержать только русские буквы");
        }
    }
}
