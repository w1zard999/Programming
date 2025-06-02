using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private double _width;

        /// <summary>
        /// Цвет прямоугольника.
        /// </summary>
        private string _color;

        /// <summary>
        /// Общий счётчик созданных прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Идентификационный номер экземпляра прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Геометрический центр прямоугольника.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника.
        /// </summary>
        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника.
        /// </summary>
        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color
        {
            get { return _color; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Color));
                _color = value;
            }
        }

        /// <summary>
        /// Возвращает общее число созданных прямоугольников.
        /// </summary>
        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        /// <summary>
        /// Возвращает уникальный идентификационный номер прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }

        /// <summary>
        /// Стандартный конструктор по умолчанию.
        /// </summary>
        public Rectangle() { }

        /// <summary>
        /// Конструктор с заданием основных характеристик прямоугольника.
        /// </summary>
        /// <param name="length">Длина прямоугольника.</param>
        /// <param name="width">Ширина прямоугольника.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Геометрический центр прямоугольника.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            this.Length = length;
            this.Width = width;
            this.Color = color;
            this.Center = center;
            _id = _allRectanglesCount++; // Автоматическое увеличение уникального номера
        }
    }
}
