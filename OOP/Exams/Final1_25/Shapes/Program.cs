namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CalculateArea();
        public abstract void DisplayInfo();
    }
    public class Rectangle : Shape
    {
        private double _width;
        private double _height;

        public Rectangle( double width, double height)
        {
            _width = width;
            _height = height;
        }
        public override double CalculateArea()
        {
            return _width * _height;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"""
                The Width of Rectangle: {_width} cm
                The Height of Rectangle: {_height} cm
                The Area of Rectangle: {CalculateArea():F2} cm^2
                """);
        }
    }
    public class Circle : Shape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double CalculateArea()
        {
            return  Math.PI * _radius * _radius;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"""
                The Radius of Circle: {_radius} cm
                The Area of Circle: {CalculateArea():F2} cm^2 
                """);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                new Rectangle(9.5, 4.5),
                new Circle(6.5),
                new Circle(12),
                new Rectangle(21, 12),
                new Circle(99),
            };
            foreach(Shape shape in  shapes)
            {
                shape.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
