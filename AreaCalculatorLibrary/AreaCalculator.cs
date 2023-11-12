using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary
{
    /// <summary>
    /// Калькулятор для вычесления площади фигур
    /// </summary>
    public static class AreaCalculator
    {
        /// <summary>
        /// Вычисляет площадь фигуры
        /// </summary>
        /// <param name="figure"> Принимает класс фигуры, реализуюзий интерфейс IFigure </param>
        /// <returns> Возвращает площадь фигуры типа Double </returns>
        public static double CalculateArea(IFigure figure)
        {
            // Вызываем метод GetArea у объекта фигуры
            return figure.GetArea();
        }
    }
}
