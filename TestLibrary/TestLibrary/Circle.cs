using System;

namespace ShapeLibrary
{
    public class Circle : Shape
    {
        public double Radius { get; }
        public Circle(double radius)
        {
            if (radius > 0)
                Radius = radius;
            else
                throw new Exception("Длина радиуса не может быть отрицательной или равной 0.");            
        }        
        public override double Square()
        {
            return Math.PI * Radius * Radius;
        }       
    }
}
