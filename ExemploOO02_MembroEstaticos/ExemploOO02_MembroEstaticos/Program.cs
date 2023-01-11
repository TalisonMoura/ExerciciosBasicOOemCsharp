using System.Globalization;

namespace ExemploOO02_MembroEstaticos {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do Dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), ci);

            double result = ConversorDeMoeda.CalcularTaxa(cotacao, quantia);

            Console.WriteLine("Valor a ser pago em reais = " + result.ToString("f2", ci));

        }
    }
}