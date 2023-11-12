using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculatorLibrary
{
    /// <summary>
    /// Предоставляет метод для вычисления площади фигур
    /// </summary>
    public interface IFigure
    {
        public double GetArea();
    }
}
