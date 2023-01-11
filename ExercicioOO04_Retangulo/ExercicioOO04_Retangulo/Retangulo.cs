using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO04_Retangulo {
    internal class Retangulo {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }
        public double Perimetro() {
            return (Largura * 2.0) + (Altura * 2.0);
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2.0) + Math.Pow(Altura, 2.0));
        }
        public override string ToString() {
            return "Area = " + Area().ToString("f2", ci) +
                   "\nPerímetro = " + Perimetro().ToString("f2", ci) +
                   "\nDiagonal = " + Diagonal().ToString("f2", ci);
        }
    }
}
