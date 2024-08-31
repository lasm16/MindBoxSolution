using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle : IFigure
    {
        public Triangle(double a, double b, double c)
        {
            SideA = a; 
            SideB = b; 
            SideC = c;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        
        public double CalculateArea()
        {
            Console.WriteLine("Вычисляем площаль треугольника...");
            CheckSides(SideA, SideB, SideC);
            CheckTriangle(SideA, SideB, SideC);
            var p = (SideA + SideB + SideC) / 2;
            var area = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            return Math.Round(area, 2);
        }

        private void CheckSides(double a, double b, double c)
        {
            if ((a + b < c) || (a + c < b) || (b + c < a))
                throw new ArgumentException("Одна сторона треугольника больше суммы двух других сторон. Такой треугольник не может существовать.");
        }

        private void CheckTriangle(double a, double b, double c)
        {
            var a2 = PowValue(a);
            var b2 = PowValue(b);
            var c2 = PowValue(c);
            if (a2 + b2 == c2)
            {
                Console.WriteLine("Треугольник прямоугольный!");
            }
            else
            {
                Console.WriteLine("Треугольник НЕ прямоугольный");
            }
        }

        private double PowValue(double value) => Math.Pow(value, 2);
    }
}
