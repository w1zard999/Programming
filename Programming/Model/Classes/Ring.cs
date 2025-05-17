using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        public Point2D Center { get; private set; }
        private double _outerRadius;
        private double _innerRadius;

        public double OuterRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertValueInRange(value, 1, InnerRadius, nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        public double InnerRadius
        {
            get { return _outerRadius; }
            set
            {
                Validator.AssertValueInRange(value, 1, OuterRadius, nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        public double Area
        {
            get
            {
                return Math.PI * (Math.Pow(OuterRadius, 2) - Math.Pow(InnerRadius, 2));
            }
        }

        public Ring() { }

        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            this.Center = center;
            this.OuterRadius = outerRadius;
            this.InnerRadius = innerRadius;
        }
    }
}
