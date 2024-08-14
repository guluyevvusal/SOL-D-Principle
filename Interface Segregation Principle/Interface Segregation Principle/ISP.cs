namespace Interface_Segregation_Principle
{
    public interface IShape
    {
        double Area();
    }

    public interface IResizableShape : IShape
    {
        void Resize(int width, int height);
    }

    public class Rectangle : IResizableShape
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public double Area()
        {
            return _width * _height;
        }

        public void Resize(int width, int height)
        {
            _width = width;
            _height = height;
        }
    }

    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class ShapeAreaCalculator
    {
        public static double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }
}
