using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFigures
{
    public abstract class MyFig
    {
        public abstract double GetArea();
    }


    // Класс Circle
    public class Circle : MyFig
    {
        // Свойство Radius, представляющее радиус круга.
        public double Radius { get; set; }

        // Конструктор класса Circle, который принимает радиус в качестве параметра.
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Переопределение метода GetArea() для вычисления площади круга.
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }


    // Класс Triangle
    public class Triangle : MyFig
    {
        // Свойства SideA, SideB и SideC, представляющие стороны треугольника.
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Конструктор класса Triangle, который принимает три стороны в качестве параметров.
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        // Переопределение метода GetArea() для вычисления площади треугольника.
        public override double GetArea()
        {
            var p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        // Метод IsRightTriangle() для проверки, является ли треугольник прямоугольным.
        public bool IsRightTriangle()
        {
            var sides = new[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - Math.Pow(sides[0], 2) - Math.Pow(sides[1], 2)) < 0.000001;
        }
    }
}
