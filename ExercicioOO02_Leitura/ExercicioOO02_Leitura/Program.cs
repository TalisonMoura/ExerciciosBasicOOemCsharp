using System.Globalization;

namespace ExercicioOO02_Leitura {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.Name = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salary = double.Parse(Console.ReadLine(), ci);
            
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            f2.Name = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salary = double.Parse(Console.ReadLine(), ci);   

            double media = (f1.Salary + f2.Salary) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", ci));

        }
    }
}