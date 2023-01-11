using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Areas {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), ci);
            x.B = double.Parse(Console.ReadLine(), ci);
            x.C = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), ci);
            y.B = double.Parse(Console.ReadLine(), ci);
            y.C = double.Parse(Console.ReadLine(), ci);

            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

            Console.WriteLine("Area de X = " + areaX.ToString("f4", ci));
            Console.WriteLine("Area de Y = " + areaY.ToString("f4", ci));

            if (areaX > areaY) {
                Console.WriteLine("Maior Área: X");
            }
            else {
                Console.WriteLine("Maior Área: Y");
            }
        }

    }
}