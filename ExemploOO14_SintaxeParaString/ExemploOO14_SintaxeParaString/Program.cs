namespace ExemploOO14_FuncoesParaString {
    internal class Program {
        static void Main(string[] args) {


            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();     /// FUNÇÃO PARA COLOCAR TODOS OS VALORES DO ATRIBUTO EM MAIUSCULO.
            string s2 = original.ToLower();     /// FUNÇÃO PARA COLOCAR TODOS OS VALORES DO ATRIBUTO EM MINUSCULO 
            string s3 = original.Trim();        /// FUNCAO PARA DELETAR OS ESPACOS CONTIDO DENTRO DA VARIÁVEL.
            
            int n1 = original.IndexOf("bc");    /// FUNÇÃO PRA LOCALIZAR O PRIMEIRO EVENTO DO ATRIBUTO.
            int n2 = original.LastIndexOf("bc");    /// FUNÇÃO PARA LOCALIZAR O ULTIMO EVENTO DO ATRIBUTO.

            string s4 = original.Substring(3);      /// FUNÇÃO PARA RECORTAR UMA STRING APARTIR DE UM INDICE.
            string s5 = original.Substring(3, 5);   ///   ///   ///  ////     //  ////   //////  /  /  ///   E UM TAMANHO.

            string s6 = original.Replace('a', 'x');     /// FUNÇÃO PARA SUBSTITUIR UM CARACTERE OU UMA STRING.
            string s7 = original.Replace("abc", "xy");  ///   ///   //   ///////    /  //////    /  //  ///

            bool b1 = string.IsNullOrEmpty(original);   /// FUNÇÃO PARA VERIFICAR SE A VARIÁVEL ESTÁ VAZIA.
            bool b2 = string.IsNullOrWhiteSpace(original);  ///  //   //    /////    /  /  ////    ///  //// E EXISTE ALGUM EXPAÇO. 

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOF('bc') " + n1);
            Console.WriteLine("LastIndexOF('bc') " + n2);
            Console.WriteLine("SubString(3): " + s4 + "-");
            Console.WriteLine("(3, 5): -" + s5 + "-");
            Console.WriteLine("('a', 'x'): -"+ s6 + "-");
            Console.WriteLine("('abc','xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
            
        }
    }
}