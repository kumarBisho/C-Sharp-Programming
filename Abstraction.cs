using System;

namespace Abstraction
{
    public abstract class Shape
    {
        public abstract string Name { get; }
        public abstract double Area();
        public abstract double Perimeter();
        public string shape = "Unknown";

        public virtual void Display()
        {
            Console.WriteLine("This is a shape of " + Name);
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
    }

    public class Square : Shape
    {
        private double size;
        public override string Name => "Square";
        public Square(double size = 0, string shape = "Square")
        {
            this.size = size;
            this.shape = shape;
        }

        public override double Area()
        {
            return size * size;
        }

        public override double Perimeter()
        {
            return 4 * size;
        }
    }

    public class Circle : Shape
    {
        private double radius;
        public override string Name => "Circle";
        public Circle(double radius = 0, string shape = "Circle")
        {
            this.radius = radius;
            this.shape = shape;
        }
        public override double Area()
        {
            return Math.PI * radius * radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}