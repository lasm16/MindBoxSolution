using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Circle : IFigure
    {
        public Circle(double r)
        {
            Radius = r;
        }
        public double Radius { get; }

        public double CalculateArea()
        {
            if (Radius <= 0)
            {
                throw new ArgumentException("Введите корректное значение радиуса круга");
            }
            else
            {
                Console.WriteLine("Вычисляем площаль круга...");
                var area = Math.PI * Math.Pow(Radius, 2);
                return Math.Round(area, 2);
            }
        }
    }
}
