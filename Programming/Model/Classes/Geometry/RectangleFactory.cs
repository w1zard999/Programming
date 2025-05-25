using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        private static Random _random = new Random();

        public static Rectangle Randomize()
        {
            double length = _random.NextDouble() * 100;
            double width = _random.NextDouble() * 100;
            double centerX = _random.Next(0, 550);
            double centerY = _random.Next(0, 400);
            int colorIndex = _random.Next(Enum.GetValues(typeof(Color)).Length);
            Color color = (Color)colorIndex;

            return new Rectangle(length, width, color.ToString(), new Point2D(centerX, centerY));
        }
    }
}
