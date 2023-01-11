using System.Globalization;

namespace ExercicioOO03_ProdutoEstoque {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), ci);
            Console.Write("Quantidade: ");
            p.Quantity = int.Parse(Console.ReadLine(), ci);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);
            
            /*while (qtd > 0) {
                Console.WriteLine("Digite mais quantidade, para encerrar digite 0");
                qtd = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qtd);                         // MANIPULANDO VARIÁVEL DE CONTROLE.      
            }
            Console.WriteLine("Dados Atualizados: " + p);
            */
            Console.WriteLine("\nDigite a quantidade a ser removida do estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);
            Console.WriteLine("\nDados Atualizados: " + p);

        }
    }
}