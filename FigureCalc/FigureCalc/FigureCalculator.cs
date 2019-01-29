namespace FigureCalc
{
    public static class FigureCalculator
    {
        public static double GetCircleArea(double radius)
        {
            return GetFigureArea(new Circle(radius));
        }

        public static double GetTriangleArea(double sideA, double sideB, double sideC)
        {
            return GetFigureArea(new Triangle(sideA, sideB, sideC));
        }

        public static bool IsTriangleRectangular(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC).IsRectangular();
        }

        public static double GetFigureArea(AbstractFigure figure)
        {
            return figure.GetArea();
        }
    }
}
