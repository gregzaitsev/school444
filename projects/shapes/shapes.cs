using System;

abstract class IShape {
  public static int getParCount() {return 0;}
  public abstract double getArea();
}

class Rect : IShape {
  public double a, b;
  public Rect(double[] p) {
    a = p[0];
    b = p[1];
  }
  public new static int getParCount() { return 2; }
  public override double getArea() {
    return a*b;
  }
}

class Square : Rect {
  public Square(double[] p) : base(new double[] {p[0], p[0]}) {
  }
  public new static int getParCount() { return 1; }
  public override double getArea() {
    return base.getArea();
  }
}

class Triangle : IShape {
  private double a, b, c;
  public Triangle(double[] p) {
    a = p[0];
    b = p[1];
    c = p[2];
  }
  public new static int getParCount() { return 3; }
  public override double getArea() {
    double per = (a+b+c);
    double hper = per/2;
    return Math.Sqrt(hper * (per - a) * (per - b) * (per - c));
  }
}

class Circle : IShape {
  private double a;
  public Circle(double[] p) {
    a = p[0];
  }
  public new static int getParCount() { return 1; }
  public override double getArea() {
    return a*a*3.141;
  }
}

class Hexagon : IShape {
  private Triangle t;
  public Hexagon(double[] p) {
    t = new Triangle(new double[] {p[0], p[0], p[0]});
  }
  public new static int getParCount() { return 1; }
  public override double getArea() {
    return 6 * t.getArea();
  }
}

class MainClass {
  public static double[] GetParametersFromUser(int sides) {
    double[] p = new double[sides];
    for (int i=0; i<sides; i++) {
      Console.WriteLine($"Введите параметр номер {i+1}");
      p[i] = Convert.ToDouble(Console.ReadLine());
    }
    return p;
  }

  public static void Main (string[] args) {
    Console.WriteLine("Какую фигуру посчитать?");
    Console.WriteLine(" (1) - Прямоугольник");
    Console.WriteLine(" (2) - Квадрат");
    Console.WriteLine(" (3) - Круг");
    Console.WriteLine(" (4) - Треугольник");
    Console.WriteLine(" (5) - Шестиугольник");

    int sides = 0;
    IShape shape = null;
    switch (Convert.ToInt32(Console.ReadLine())) {
      case 1:
        sides = Rect.getParCount();
        shape = new Rect(GetParametersFromUser(sides));
      break;
      case 2:
        sides = Square.getParCount();
        shape = new Square(GetParametersFromUser(sides));
      break;
      case 3:
        sides = Circle.getParCount();
        shape = new Circle(GetParametersFromUser(sides));
      break;
      case 4:
        sides = Triangle.getParCount();
        shape = new Triangle(GetParametersFromUser(sides));
      break;
      case 5:
        sides = Hexagon.getParCount();
        shape = new Hexagon(GetParametersFromUser(sides));
      break;
    }

    if (shape != null)
      Console.WriteLine($"Площадь фигуры: {shape.getArea()}");
    
  }
}