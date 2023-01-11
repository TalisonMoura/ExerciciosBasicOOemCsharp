using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioOO007_ContaBancaria {
    internal class ContaBancaria {
        CultureInfo ci = CultureInfo.InvariantCulture;

        public string NumConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }
        public ContaBancaria(string numConta, string nomeTitular) {
            NumConta = numConta;
            NomeTitular = nomeTitular;
        }
        public ContaBancaria(string numConta, string nomeTitular, double depositoInicial) : // Alterando o nome do parametro de Saldo for depositoInicial.
            this(numConta, nomeTitular) {
            Deposito(depositoInicial);    /// Atribuindo a entrada do deposito diretamente para o método
                                                            
        }
        public string Nome {
            get { return NomeTitular; }
            set {
                if (value != null && value.Length > 1) {
                    NomeTitular = value;
                }
            }
        }
        public void Deposito(double valor) {
            Saldo += valor;
        }
        public void Sacar(double valor) {
            Saldo -= valor + 5.0;
        }
        public override string ToString() {
            return ($"Conta: {NumConta}, Titular: {NomeTitular}, Saldo: R$ {Saldo.ToString("f2", ci)}");
        }
    }
}