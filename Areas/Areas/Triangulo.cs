using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas {
    internal class Triangulo {

        public double A;
        public double B;
        public double C;
        public double CalcularArea() {
            double p = (A + B + C) / 2;
            double raizarea = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raizarea;
        }
    }
}
