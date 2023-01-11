using System.Globalization;

namespace ExercicioOO04_Retangulo {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), ci);
            r.Altura = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine(r);
        }
    }
}