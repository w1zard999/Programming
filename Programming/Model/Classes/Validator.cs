using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Свойство '{propertyName}' должно быть положительным числом.");
            }
        }

        public static void AssertOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Свойство '{propertyName}' должно быть положительным числом.");
            }
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Свойство '{propertyName}' должно быть в диапазоне от {min} до {max}.");
            }
        }

        public static void AssertValueInRange(double value, double min, double max, string propertyName)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Свойство '{propertyName}' должно быть в диапазоне от {min} до {max}.");
            }
        }

        public static void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (!Regex.IsMatch(value, @"^[A-Za-z]+$"))
                throw new ArgumentException($"{propertyName} может содержать только английские буквы");
        }
    }
}
