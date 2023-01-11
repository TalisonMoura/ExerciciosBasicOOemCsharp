using System.Globalization;

namespace ExercicioOO05_Funcionario {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Funcionario f= new Funcionario();
            
            Console.WriteLine("Entre com os Dados do Funcionário:");
            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.GrossSalary = double.Parse(Console.ReadLine(), ci);
            Console.Write("Imposto: ");
            f.IncomeTax = double.Parse(Console.ReadLine(), ci);

            Console.WriteLine("\nFuncionário: " + f.Name + ", R$ " + f.NetSalary().ToString("f2", ci));
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double percent = double.Parse(Console.ReadLine(), ci);
            f.SalaryUp(percent);
            Console.WriteLine();
            Console.WriteLine(f);
        }
    }
}