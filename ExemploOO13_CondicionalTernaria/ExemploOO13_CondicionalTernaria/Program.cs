using System.Globalization;
using System.Net;

namespace ExemploOO13_CondicionalTernaria {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            double price = double.Parse(Console.ReadLine(), ci);

            double discount = (price < 20.0) ? price * 0.1 : price * 0.05; /// OUTRA FORMA DE FAZER UMA ESTRUTURA CONDICIONAL. IF/ELSE
            /*
            if (price < 20.0) {
                discount = price* 0.1;
            }
            else {
                discount = price* 0.05;
            }
            */
            
            Console.WriteLine(discount);
       
        }
    }
}