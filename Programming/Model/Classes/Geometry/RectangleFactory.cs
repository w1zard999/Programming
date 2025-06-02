using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;

namespace Programming.Model.Classes.Geometry
{
    public static class RectangleFactory
    {
        /// <summary>
        /// Генерирует случайные значения для создания прямоугольника.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создаёт случайный прямоугольник с произвольными размерами и положением.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Rectangle"/> с случайно сгенерированными характеристиками.</returns>
        public static Rectangle Randomize()
        {
            double length = _random.NextDouble() * 100;
            double width = _random.NextDouble() * 100;
            double centerX = _random.Next(0, 550);
            double centerY = _random.Next(0, 400);
            int colorIndex = _random.Next(Enum.GetValues(typeof(Enums.Color)).Length);
            Enums.Color color = (Enums.Color)colorIndex;

            return new Rectangle(length, width, color.ToString(), new Point2D(centerX, centerY));
        }
    }
}
