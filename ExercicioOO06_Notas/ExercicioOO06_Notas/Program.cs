using System.Globalization;

namespace ExercicioOO06_Notas {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;  
            
            Aluno a = new Aluno();
            
            Console.Write("Nome do Aluno: ");
            a.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            a.n1 = double.Parse(Console.ReadLine(), ci);
            a.n2 = double.Parse(Console.ReadLine(), ci);
            a.n3 = double.Parse(Console.ReadLine(), ci);
            
            Console.WriteLine("NOTA FINAL = " + a.CalcularNota().ToString("f2", ci));
            Console.WriteLine(a);
        }
    }
}