using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public class Ring
    {
        /// <summary>
        /// Центр кольца.
        /// </summary>
        public Point2D Center { get; private set; }

        /// <summary>
        /// Внутренний радиус кольца.
        /// </summary>
        private double _innerRadius;

        /// <summary>
        /// Внешний радиус кольца.
        /// </summary>
        private double _outerRadius;

        /// <summary>
        /// Возвращает и задаёт внешний радиус кольца.
        /// </summary>
        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertValueInRange(value, 1, InnerRadius, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        /// <summary>
        /// Возвращает внутренний радиус кольца.
        /// </summary>
        public double InnerRadius
        {
            get { return _innerRadius; }
            set
            {
                Validator.AssertValueInRange(value, 1, OuterRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        /// <summary>
        /// Площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Ring() { }

        /// <summary>
        /// Конструктор кольца с параметрами.
        /// </summary>
        /// <param name="center">Центр кольца.</param>
        /// <param name="outerRadius">Внешний радиус.</param>
        /// <param name="innerRadius">Внутренний радиус.</param>
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            OuterRadius = outerRadius;
            InnerRadius = innerRadius;
        }
    }
}
