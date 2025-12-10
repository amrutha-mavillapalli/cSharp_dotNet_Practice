namespace MyPractise
{
    public class ClsAbstract
    {
        // Abstract class
        public abstract class Shape
        {
            public abstract double Area(); // Abstract method
            public void Display()
            {
                Console.WriteLine("This is a shape.");
            }
        }

        // Derived class Circle
        public class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // Derived class Rectangle
        public class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double Area()
            {
                return Width * Height;
            }
        }

        public static void AbstractClassExample()
        {
            Shape circle = new Circle(5);
            circle.Display();
            Console.WriteLine("Area of Circle: " + circle.Area());

            Shape rectangle = new Rectangle(4, 6);
            rectangle.Display();
            Console.WriteLine("Area of Rectangle: " + rectangle.Area());
        }
    }
}

