using MindBox.Geometry.Interfaces;

namespace MindBox.Geometry.Shapes;

    public class Triangle : Shape, ITriangle
    {

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!TriangleService.IsValidSides(sideA, sideB, sideC))
            {
                throw new ArgumentException("Invalid triangle sides");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public override double GetArea()
        {
            var s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
