using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary
{
    /// <summary>
    /// Класс представляет прямоугольник, имеет два свойства: SideA, SideB, представляющие длину сторон прямоугольника,
    /// а так же метод GetArea, который возвращает его площадь
    /// </summary>
    public class Rectangle : IFigure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }

        /// <summary>
        /// Конструктор для создания объекта Прямоугольник
        /// </summary>
        /// <param name="a"> Принимает длину стороны A </param>
        /// <param name="b"> Принимает длину стороны B </param>
        public Rectangle(double a, double b)
        {
            SideA = a;
            SideB = b;
        }

        /// <summary>
        /// Вычисляет площадь прямоугольника по формуле S = A * B, 
        /// где A и B - это длины сторон прямоугольника
        /// </summary>
        /// <returns>Площадь прямоугольника типа Double</returns>
        public double GetArea()
        {
            // Возвращаем площадь по формуле S = A * B
            return SideA * SideB;
        }
    }
}
