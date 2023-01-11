using System.Globalization;

namespace Fixacao {
    internal class LeituraString {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            string fullname;
            int bedroom;
            double price;

            Console.WriteLine("Entre com seu nome completo: ");
            fullname = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            bedroom = int.Parse(Console.ReadLine());
            Console.WriteLine("Emtre com o preço de um produto: ");
            price = double.Parse(Console.ReadLine(), ci);
            Console.WriteLine("Entre com seu último nome, idade e altura: ");
            string[] dateline = Console.ReadLine().Split(' ');
            String lastname = dateline[0];
            int age = int.Parse(dateline[1]);   
            double height = double.Parse(dateline[2].ToString(), ci);

            Console.WriteLine(fullname);           
            Console.WriteLine(bedroom);
            Console.WriteLine(price.ToString("f2", ci));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("f2", ci));






        }
    }
}