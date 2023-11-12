using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary
{
    /// <summary>
    /// Класс представляет круг, имеет свойство Radius и метод GetArea, который возвращает площадь круга
    /// </summary>
    public class Circle : IFigure
    {
        public double Radius { get; private set; }

        /// <summary>
        /// Конструктор для создания объекта Круг
        /// </summary>
        /// <param name="radius"> Принимает радиус </param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга по формуле S = π × r2, где r — это радиус, π — это константа, которая выражает отношение длины окружности к диаметру
        /// </summary>
        /// <returns>Площадь круга типа Double</returns>
        public double GetArea()
        {
            // Возвращаем площадь, вычисляя ее по формуле S = π × r2
            return Math.PI * Radius * Radius;
        }
    }
}
