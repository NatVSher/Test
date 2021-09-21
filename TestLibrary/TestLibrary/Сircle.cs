using System;

namespace ShapeLibrary
{
    public class Сircle : Shape
    {
        public double Radius { get; }
        public Сircle(double radius)
        {
            if (radius > 0)
                Radius = radius;
            else
                throw new Exception("Длина радиуса не может быть отрицательной или равной 0.");            
        }        
        public override double Square()
        {
            return 2 * Math.PI * Radius;
        }       
    }
}
