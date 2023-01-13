namespace ExemploOO12_Lista {
    internal class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");      /// FUNCAO PARA ADICIONAR DADOS NA LISTA.
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco");    /// FUNCAO PARA ADICIONAR DADOS NA LISTA, EM UM INDICE ESPECIFICO.

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List Count: " + list.Count);  /// FUNCAO PARA MOSTRAR QUANTOS ITENS EXISTE NA LISTA.

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position: 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last Position: 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }
            list.Remove("Alex");
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            list.RemoveAt(3);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
        }
        /*
        static bool Test(string s) {   FUNCAO COMO TESTE PARA VERIFICAR COMSULTA DE NOME;
            return s[0] == 'A';        ENTRETANTO, SERA USADO UMA EXPRESSAO LAMBDA PARA FAZER ESSA CONSULTA. 
        }
        */
    }
}