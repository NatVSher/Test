using System;

namespace ShapeLibrary
{
    public class Triangle : Shape
    {       
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }
        
        public Triangle(double a, double b, double c)
        {
            a = TryGetSide(a);
            b = TryGetSide(b);
            c = TryGetSide(c);
            if (IsTriangle(a, b, c))
            {
                SideA = a;
                SideB = b;
                SideC = c;
            }
        }

        public override double Square()
        {
            var P = (SideA + SideB + SideC) / 2;
            var S = Math.Sqrt(P * (P - SideA) * (P - SideB) * (P - SideC));
            return S;
        }
        private double TryGetSide(double side)
        {
            if (side > 0)
                return side;
            else
                throw new Exception("Длина стороны не может быть отрицательной или равной 0.");
        }
        private bool IsTriangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
                return true;
            else
                throw new Exception("Данные длины сторон не образуют треугольник");
        }
    }
}
