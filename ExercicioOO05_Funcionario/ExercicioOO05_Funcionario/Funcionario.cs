using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO05_Funcionario {
    internal class Funcionario {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public String Name;
        public double GrossSalary;
        public double IncomeTax;
        public double NetSalary() {
            return GrossSalary - IncomeTax;
        }
        public void SalaryUp(double percent) {
            GrossSalary = (GrossSalary * percent / 100.0) + NetSalary();
        }
        public override string ToString() {
            return "Dados Atualizados: " +
                   Name +
                   ", R$ " +
                   GrossSalary.ToString("f2", ci);
        }
    }
}
