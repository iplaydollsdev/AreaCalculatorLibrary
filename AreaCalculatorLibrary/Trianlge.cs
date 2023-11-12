using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace AreaCalculatorLibrary
{
    /// <summary>
    /// Класс представляет треугольник, имеет три свойства: SideAB, SideBC, SideCA, представляющие длину сторон треугольника,
    /// а так же метод GetArea, который возвращает площадь треугольника
    /// </summary>
    public class Trianlge : IFigure
    {
        public double SideAB { get; private set; }
        public double SideBC { get; private set; }
        public double SideCA { get; private set; }
        /// <summary>
        /// Является ли треугольник прямоульным (true для прямоугольного, false для непрямоугольного)
        /// </summary>
        public bool IsRightAngled { get; private set; }


        /// <summary>
        /// Конструктор для создания объекта Треугольник
        /// </summary>
        /// <param name="ab"> Принимает длину стороны AB </param>
        /// <param name="bc"> Принимает длину стороны BC </param>
        /// <param name="ca"> Принимает длину стороны CA </param>
        public Trianlge(double ab, double bc, double ca)
        {
            SideAB = ab; 
            SideBC = bc; 
            SideCA = ca;
            IsRightAngled = SetRightAngled();
        }

        /// <summary>
        /// Вычисляет площадь треугольника по формуле Герона S = √(p * (p — ab) * (p — bc) * (p — ca)), 
        /// где p — это полупериметр, ab, bc, ca - это длины сторон треугольника
        /// </summary>
        /// <returns>Площадь треугольника типа Double</returns>
        public double GetArea()
        {
            // Вычисляем периметр треугольника
            double perimeter = SideAB + SideBC + SideCA;
            // Получаем полупериметр треугольника P / 2
            double semiP = perimeter / 2;
            // Вычисляем площадь треугольника по формуле Герона S = √(p * (p — ab) * (p — bc) * (p — ca))
            double resultArea = Math.Sqrt(semiP * (semiP - SideAB) * (semiP - SideBC) * (semiP - SideCA));
            // Возвращаем результат
            return resultArea;
        }

        /// <summary>
        /// Вычисляет является ли треугольник прямоугольным по формуле Пифагора a² + b² = c²
        /// где a и b — длины катетов, а c — длина гипотенузы        
        /// </summary>
        /// <returns> true для прямоугольного, false для непрямоугольного </returns>
        private bool SetRightAngled()
        {
            // Если сторона AB является самой длинной, т.е. гипотенузой
            if (SideAB >= SideBC && SideAB >= SideCA)
            {
                // Применяем формулу Пифагора и возвращаем bool
                return Math.Pow(SideBC, 2) + Math.Pow(SideCA, 2) == Math.Pow(SideAB, 2);
            }
            // Если сторона BC является самой длинной, т.е. гипотенузой
            else if (SideBC >= SideAB && SideBC >= SideCA)
            {
                // Применяем формулу Пифагора и возвращаем bool
                return Math.Pow(SideAB, 2) + Math.Pow(SideCA, 2) == Math.Pow(SideBC, 2);
            }
            // Если сторона CA является самой длинной, т.е. гипотенузой
            else
            {
                // Применяем формулу Пифагора и возвращаем bool
                return Math.Pow(SideAB, 2) + Math.Pow(SideBC, 2) == Math.Pow(SideCA, 2);
            }
        }
    }
}
