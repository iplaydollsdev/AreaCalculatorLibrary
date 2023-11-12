using AreaCalculatorLibrary;

namespace AreaCalculatorUnitTest
{
    [TestClass]
    public class AreaCalculatorUnitTest
    {
        /// <summary>
        /// Проверка расчета площади круга
        /// </summary>
        [TestMethod]
        public void TestCircleGetArea()
        {
            // Создаем круг с радиусом 5
            Circle circle = new(radius: 5);
            // Задаем ожидаемую площадь круга по формуле S = π × r2, где r — это радиус
            double expectedArea = 78.53981633974483;

            // Высчитываем площадь круга методом из библиотеки
            double calculatedArea = circle.GetArea();

            // Тест будет пройден если ожидаемая и рассчитанная площадь будут равны
            Assert.AreEqual(expectedArea, calculatedArea);
        }

        /// <summary>
        /// Проверка расчета площади треугольника
        /// </summary>
        [TestMethod]
        public void TestTriangleGetArea()
        {
            // Создаем треугольник с длинами сторон 5, 10 и 10
            Trianlge trianlge = new(5, 10, 10);
            // Задаем ожидаемую площадь треугольника, рассчитанную заранее
            double expectedArea = 24.206145913796355;

            // Высчитываем площадь круга методом из библиотеки
            double calculatedArea = trianlge.GetArea();

            // Тест будет пройден если ожидаемая и рассчитанная площадь будут равны
            Assert.AreEqual(expectedArea, calculatedArea);
        }

        /// <summary>
        /// Проверка определения прямоугольного треугольника
        /// </summary>
        [TestMethod]
        public void TestCheckIsTriagleRightAngled()
        {
            // Создаем прямоугольный треугольник
            Trianlge rightAngledtrianlge = new(5, 12, 13);
            // Создаем непрямоугольный труегольник
            Trianlge noneRightAnlgedTrianle = new(2, 3, 4);

            //Тест будет пройден если для прямоугольного треугольника IsRightAngled будет true, а для непрямоугольного false
            Assert.AreEqual(rightAngledtrianlge.IsRightAngled, true);
            Assert.AreEqual(noneRightAnlgedTrianle.IsRightAngled, false);
        }

        /// <summary>
        /// Проверка вычисления площади без знания типа фигуры 
        /// (статический метод CalculateArea принимает в качестве параметра интерфейс IFigure, что позволяет вычислить площадь любой фигуры)
        /// </summary>
        [TestMethod]
        public void TestStaticCalculator()
        {
            // Создаем круг с радиусом 10
            Circle circle = new(radius: 10);
            // Задаем ожидаемую площадь круга, рассчитанную заранее
            double expectedCircleArea = 314.1592653589793;
            // Создаем треугольник с длинами сторон 3, 4 и 5
            Trianlge trianlge = new(3, 4, 5);
            // Задаем ожидаемую площадь треугольника, рассчитанную заранее
            double expectedTriangleArea = 6;

            // Высчитываем площадь фигур статическим методом CalculateArea, передавая в качестве аргумента любую фигуру
            // Тест будет пройден если ожидаемые и рассчитанные площади будут равны как для круга, так и для треугольника
            Assert.AreEqual(expectedCircleArea, AreaCalculator.CalculateArea(circle));
            Assert.AreEqual(expectedTriangleArea, AreaCalculator.CalculateArea(trianlge));
        }
    }
}