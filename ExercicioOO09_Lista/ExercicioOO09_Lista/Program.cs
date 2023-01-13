using System.Globalization;
using System.Collections.Generic;
namespace ExercicioOO09_Lista {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            List<Employee> list = new List<Employee>();
            //Employee e;  DECLARANDO OBJETO PARA PASSAR COMO PARÂMETRO AUXILIAR.

            Console.Write("How many emplyees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string Name = Console.ReadLine();
                Console.Write("Salary: ");
                double Salary = double.Parse(Console.ReadLine(), ci);
                list.Add(new Employee(Id, Name, Salary));
                //e = new Employee(Id, Name, Salary);  |-  OUTRA FORMA DE PASSAR OS PARAMETROS PARA LISTA   
                //list.Add(e);                         |-  OUTRA FORMA DE PASSAR OS PARAMETROS PARA LISTA   
                Console.WriteLine();
            }
            Console.Write("Enter the employee Id that will have salary increase : ");
            int FindId = int.Parse(Console.ReadLine());

            Employee employee = list.Find(x => x.Id == FindId); // EXPRESSAO PARA VERIFICAR SE EXISTE O ID INSERIDO PELO USUÁRIO.

            if (employee != null) {
                Console.Write("Enter de percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employee.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This Id doesn't exist!!!");
            }
            Console.WriteLine();
            Console.WriteLine("Updated list of employee:");
            foreach (Employee dados in list) {
                Console.WriteLine(dados);
            }
        }
    }
}