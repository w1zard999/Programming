using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Rectangle
    {
        private double _length;
        private double _width;
        private string _color;
        private static int _allRectanglesCount;
        private int _id;

        public Point2D Center { get; private set; }

        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public string Color
        {
            get { return _color; }
            set
            {
                Validator.AssertStringContainsOnlyLetters(value, nameof(Color));
                _color = value;
            }
        }

        public int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        public int Id
        {
            get { return _id; }
        }

        public Rectangle() { }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            this.Length = length;
            this.Width = width;
            this.Color = color;
            this.Center = center;
            _id = _allRectanglesCount++;
        }
    }
}
