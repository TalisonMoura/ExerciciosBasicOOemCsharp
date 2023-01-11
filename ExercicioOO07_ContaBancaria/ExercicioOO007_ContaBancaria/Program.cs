using System.Globalization;

namespace ExercicioOO007_ContaBancaria {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            ContaBancaria c;

            Console.Write("Entre com o numero da conta: ");
            String numConta = Console.ReadLine();

            Console.Write("Entre com o titular da conta: ");
            String nomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char escolha = char.Parse(Console.ReadLine());

            if (escolha.Equals('s') || escolha.Equals('S')) {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), ci);
                c = new ContaBancaria(numConta, nomeTitular, depositoInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(c);
            }
            else {
                c = new ContaBancaria(numConta, nomeTitular);
                Console.WriteLine(c);
                Console.WriteLine();
            }
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), ci);
            c.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), ci);
            c.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c);
        }
    }
}