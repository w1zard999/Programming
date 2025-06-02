using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Point2D
    {
        /// <summary>
        /// Координата X точки.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Координата Y точки.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Создаёт точку с заданными координатами.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        public Point2D(double x, double y)
        {
            Validator.AssertValueInRange(x, 0, 1000, nameof(X)); // проверка диапазона X
            Validator.AssertValueInRange(y, 0, 1000, nameof(Y)); // проверка диапазона Y

            this.X = x;
            this.Y = y;
        }
    }
}
