using System;
using System.Globalization;

namespace Curso
{
  class Triangulo
  {
    public double A;
    public double B;
    public double C;

    public double Area()
    {
      double p = (A + B + C) / 2.0;
      return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

    }

    public static void CalcularTriangulo(){
      Triangulo x, y;
      x = new Triangulo();
      y = new Triangulo();

      Console.WriteLine("Entre com as medidas do triangulo X");
      x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double areaX = x.Area();

      Console.WriteLine("Entre com as medidas do triangulo Y");
      y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double areaY = y.Area();

      Console.WriteLine($"Area de X: {areaX:F4}");
      Console.WriteLine($"Area de Y: {areaY:F4}");
      if (areaX > areaY)
      {
        Console.WriteLine("Maior Area: X");
      }
      else { Console.WriteLine("Maior Area: Y"); }

    }

  }
}
