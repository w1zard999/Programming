using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        public double X {  get; set; }
        public double Y { get; set; }

        public Point2D(double x, double y)
        {
            Validator.AssertValueInRange(x, 0, 256, nameof(X));
            Validator.AssertValueInRange(y, 0, 256, nameof(Y));

            this.X = x;
            this.Y = y;
        }
    }
}
