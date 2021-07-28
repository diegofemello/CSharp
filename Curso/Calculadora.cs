using System;
using System.Globalization;

namespace Curso
{
  class Calculadora
  {
    public static double Pi = 3.14;
    public static double Circunferencia(double r)
    {
      return 2.0 * Pi * r;
    }

    public static double Volume(double r)
    {
      return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
    }

    public static void CalculoRaio()
    {
      Console.Write("Entre o valor do raio: ");
      double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double circ = Calculadora.Circunferencia(raio);
      double volume = Calculadora.Volume(raio);

      Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
    }
  }
}
