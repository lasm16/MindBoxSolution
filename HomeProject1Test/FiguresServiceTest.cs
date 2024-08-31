using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeProject1Test
{
    public class FiguresServiceTest
    {
        IService? service;
        private double areaExpected;

        [Test]
        public void CalculateArea_Circle_ReturnsExpectedArea()
        {
            var sides = new[] { 3.0 };
            service = new FigureService();
            var areaActual = service.GetFiguresArea(sides);
            areaExpected = 28.27;
            Assert.That(areaActual, Is.EqualTo(areaExpected));
        }

        [Test]
        public void CalculateArea_Triangle_ReturnsExpectedArea()
        {
            var sides = new[] { 2.0, 5.0, 4.0, 2.0, 7.9 };
            service = new FigureService();
            var areaActual = service.GetFiguresArea(sides);
            areaExpected = 3.8;
            Assert.That(areaActual, Is.EqualTo(areaExpected));
        }

        [Test]
        public void CalculateArea_EmptyArray_ReturnsArgumentException()
        {
            var sides = Array.Empty<double>();
            service = new FigureService();
            var expected = Assert.Throws<ArgumentException>(() => service.GetFiguresArea(sides));
            Assert.That(expected.Message, Is.EqualTo("Передам пустой массив!"));
        }

        [Test]
        public void CalculateArea_Triangle_ReturnsArgumentException()
        {
            var sides = new[] { 2.0, 5.0 };
            service = new FigureService();
            var expected = Assert.Throws<ArgumentException>(() => service.GetFiguresArea(sides));
            Assert.That(expected.Message, Is.EqualTo("Передам некорректный массив!"));
        }
    }
}
