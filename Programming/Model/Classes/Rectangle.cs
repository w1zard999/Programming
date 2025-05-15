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

        public double Length
        {
            get { return _length; }
            set
            {
                if (value < 0) throw new ArgumentException("Длина должна быть положительной");
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value < 0) throw new ArgumentException("Ширина должна быть положительной");
                _width = value;
            }
        }

        public string Color { get; set; }

        public Rectangle() { }

        public Rectangle(double length, double width, string color)
        {
            this.Length = length;
            this.Width = width;      
            this.Color = color;
        }
    }
}
