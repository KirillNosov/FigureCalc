using System;
namespace FigureCalc
{
    class Circle : AbstractFigure
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("The Radius can't be negative");
            }

            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}
