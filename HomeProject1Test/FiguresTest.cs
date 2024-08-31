using ClassLibrary1;

namespace HomeProject1Test
{
    public class FiguresTest
    {

        private double areaExpected;
        private IFigure? figure;

        [Test]
        public void CalculateArea_Circle_ReturnsExpectedNumber()
        {
            figure = new Circle(3);
            var areaActual = figure.CalculateArea();
            areaExpected = 28.27;
            Assert.That(areaActual, Is.EqualTo(areaExpected));
        }

        [Test]
        public void CalculateArea_CircleWithNegetiveRadius_ReturnsArgumentException()
        {
            figure = new Circle(-1);
            var expected = Assert.Throws<ArgumentException>(() => figure.CalculateArea());
            Assert.That(expected.Message, Is.EqualTo("Введите корректное значение радиуса круга"));
        }

        [Test]
        public void CalculateArea_CircleWithZeroRadius_ReturnsArgumentException()
        {
            figure = new Circle(0);
            var expected = Assert.Throws<ArgumentException>(() => figure.CalculateArea());
            Assert.That(expected.Message, Is.EqualTo("Введите корректное значение радиуса круга"));
        }

        [Test]
        public void CalculateArea_TriangleUsual_ReturnsExpectedNumber()
        {
            figure = new Triangle(2, 5, 4);
            var areaActual = figure.CalculateArea();
            areaExpected = 3.8;
            Assert.That(areaActual, Is.EqualTo(areaExpected));
        }

        [Test]
        public void CalculateArea_TriangleRightt_ReturnsExpectedNumber()
        {
            figure = new Triangle(3, 4, 5);
            var areaActual = figure.CalculateArea();
            areaExpected = 6;
            Assert.That(areaActual, Is.EqualTo(areaExpected));
        }

        [Test]
        public void CalculateArea_TriangleWithOneLongSide_ReturnsArgumentException()
        {
            figure = new Triangle(4, 2, 1);
            var expected = Assert.Throws<ArgumentException>(() => figure.CalculateArea());
            Assert.That(expected.Message, Is.EqualTo("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать."));
        }

        [Test]
        public void CalculateArea_TriangleWithNegativeLongSide_ReturnsArgumentException()
        {
            figure = new Triangle(3, 4, -5);
            var expected = Assert.Throws<ArgumentException>(() => figure.CalculateArea());
            Assert.That(expected.Message, Is.EqualTo("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать."));
        }

        [Test]
        public void CalculateArea_TriangleWithZeroLongSide_ReturnsArgumentException()
        {
            figure = new Triangle(3, 4, 0);
            var expected = Assert.Throws<ArgumentException>(() => figure.CalculateArea());
            Assert.That(expected.Message, Is.EqualTo("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать."));
        }
    }
}