using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO06_Notas {
    internal class Aluno {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public String Name;
        public double n1, n2, n3;

        public double CalcularNota() {
            return n1 + n2 + n3;
        }
        public double CalcularNotaRestante() {
            return 60 - CalcularNota();
        }
        public override string ToString() {
            if (CalcularNota() < 60) {
                return "REPROVADO!\n" +
                       "FALTARAM " +
                       CalcularNotaRestante().ToString("f2", ci) +
                       " PONTOS";
            }
            else {
                return "APROVADO!";
            }
        }




    }
}
