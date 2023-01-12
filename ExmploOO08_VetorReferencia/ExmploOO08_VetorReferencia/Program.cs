using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace ExmploOO08_VetorReferencia {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++) {
                String Name = Console.ReadLine();
                double Price = double.Parse(Console.ReadLine(), ci);
                vet[i] = new Product(Name, Price);
                ///OUTRA FORMA DE DECLARAR ATRIBUTOS, SEM O USO DE CONSTRUTOR NA CLASSE PRODUCT.
                ///vet[i] = new Product { Name = name, Price = price }; 
            }
            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += vet[i].Price;
            }
            double average = sum / n;
            Console.WriteLine("Average Price = " + average.ToString("f2", ci));

        }
    }
}