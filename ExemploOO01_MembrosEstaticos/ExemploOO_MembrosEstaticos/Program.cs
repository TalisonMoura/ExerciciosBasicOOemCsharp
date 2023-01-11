using ExemploOO01_MembrosEstaticos;
using System.Globalization;

namespace ExemploOO001_MembrosEstaticos {
    internal class Program {

        
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;
           
            Console.WriteLine("Entre o valor do raio");
            double raio = double.Parse(Console.ReadLine(), ci);

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);
           
            Console.WriteLine("Circunfêrencia: "+ circ.ToString("f2", ci));
            Console.WriteLine("Volume: " + volume.ToString("f2", ci));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("f2", ci));
        }
        
    }
}