using System;

namespace FigureCalc
{
    class Triangle : AbstractFigure
    {
        double _sideA;
        double _sideB;
        double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!(sideA > 0 && sideB > 0 && sideC > 0))
            {
                throw new ArgumentException("Length of triangle's side can't be null or negative");
            }
            else if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideC))
            {
                throw new ArgumentException("The sum of the lengths of the two any sides of the triangle must be greater than the length of the third side");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public bool IsRectangular()
        {
            return _sideA * _sideA == _sideB * _sideB + _sideC * _sideC ||
                   _sideB * _sideB == _sideA * _sideA + _sideC * _sideC ||
                   _sideC * _sideC == _sideA * _sideA + _sideB * _sideB;
        }

        public override double GetArea()
        {
            double p = (_sideA + _sideB + _sideC) / 2.0;

            return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
        }
    }
}
