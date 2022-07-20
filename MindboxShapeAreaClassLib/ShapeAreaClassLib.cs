namespace MindboxShapeAreaClassLib
{
    public class Calc
    {
        public double AreaCalc(Triangle t)
        {
            t.Area = Math.Sqrt(t.halfperimeter * (t.halfperimeter - t.side_a) * (t.halfperimeter - t.side_b) * (t.halfperimeter - t.side_c));
            return t.Area;
        }
        public double AreaCalc(Circle c)
        {
            c.Area = Math.PI * Math.Pow(c.radius, 2);
            return c.Area;
        }
    }
    public class Shape
    {
        public double Area { get; set; }

    }
    public class Triangle : Shape
    {
        public double side_a;
        public double side_b;
        public double side_c;
        public double halfperimeter;
        public Triangle(int a, int b, int c)
        {
            this.side_a = a;
            this.side_b = b;
            this.side_c = c;
            this.halfperimeter = (this.side_a + this.side_b + this.side_c) / 2;
            if (side_a<=0 | side_b <= 0 | side_c <= 0)
            {
                throw new ArgumentException("Length of any side of triangle must be more than 0");
            }
        }
        public bool IsRectangular()
        {
            if (Math.Pow(side_a, 2) == Math.Pow(side_b, 2) + Math.Pow(side_c, 2) |
                Math.Pow(side_b, 2) == Math.Pow(side_a, 2) + Math.Pow(side_c, 2) |
                Math.Pow(side_c, 2) == Math.Pow(side_a, 2) + Math.Pow(side_b, 2) )
            {
                return true;
            }
            return false;
        }
    }
    public class Circle : Shape
    {
        public double radius;
        public Circle(double r)
        {
            this.radius = r;
            if (r<=0)
            {
                throw new ArgumentException("Radius of circle must be more than 0");
            }
        }
    }
}