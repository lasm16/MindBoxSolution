using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FigureService : IService
    {
        private IFigure figure;

        public double GetFiguresArea(double[] sides)
        {
            Console.WriteLine("Получили массив из элементов...");
            foreach (var item in sides)
            {
                Console.WriteLine(item);
            }
            SelectFigure(sides);
            var area = figure.CalculateArea();
            Console.WriteLine("Площадь фигуры равна = " + area);
            return area;
        }

        private void SelectFigure(double[] sides)
        {
            var lenght = sides.Length;
            switch (lenght)
            {
                case 0: throw new ArgumentException("Передам пустой массив!");
                case 1:
                    figure = new Circle(sides[0]);
                    Console.WriteLine("Фигура - круг"); break;
                case 2: throw new ArgumentException("Передам некорректный массив!");
                default:
                    figure = new Triangle(sides[0], sides[1], sides[2]);
                    Console.WriteLine("Фигура - треугольник"); break;
            }
        }
    }
}
