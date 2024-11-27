using System;

interface IShape {
    double Area();
}

class Circle : IShape {
    private double Radius;

    public Circle(double radius) {
        Radius = radius;
    }

    public double Area() {
        return Math.PI * Radius * Radius;
    }
}

class Program {
    static void Main() {
        IShape circle = new Circle(5);
        Console.WriteLine("Area: " + circle.Area());
    }
}
