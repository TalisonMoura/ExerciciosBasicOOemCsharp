using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploOO02_MembroEstaticos {
    internal class ConversorDeMoeda {
        public static double Iof = 6.0 / 100.0; 
        public static double CalcularTaxa(double cotacao, double quantia) {
            double total = cotacao * quantia;
            return total * Iof + total;
        }
    }
}
