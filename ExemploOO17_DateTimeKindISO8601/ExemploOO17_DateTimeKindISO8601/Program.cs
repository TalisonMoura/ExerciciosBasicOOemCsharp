namespace ExemploOO17_DateTimeKindISO8601 {
    internal class Program {
        static void Main(string[] args) {


            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);

            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);

            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("D1: " + d1);
            Console.WriteLine("D1 Kind: " + d1.Kind);
            Console.WriteLine("D1 to Local: " + d1.ToLocalTime());
            Console.WriteLine("D1 to Utc: " + d1.ToUniversalTime());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("D2: " + d2);
            Console.WriteLine("D2 Kind: " + d2.Kind);
            Console.WriteLine("D2 to Local: " + d2.ToLocalTime());
            Console.WriteLine("D2 to Utc: " + d2.ToUniversalTime());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("D3: " + d3);
            Console.WriteLine("D3 Kind: " + d3.Kind);
            Console.WriteLine("D3 to Local: " + d3.ToLocalTime());
            Console.WriteLine("D3 to Utc: " + d3.ToUniversalTime());
            Console.WriteLine("-----------------------------------");

            DateTime d4 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d5 = DateTime.Parse("2000-08-15T13:05:58Z");
            
            Console.WriteLine("D4: " + d4);
            Console.WriteLine("D4 Kind: " + d4.Kind);
            Console.WriteLine("D4 to Local: " + d4.ToLocalTime());
            Console.WriteLine("D4 to Utc: " + d4.ToUniversalTime());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("D5: " + d5);
            Console.WriteLine("D5 Kind: " + d5.Kind);
            Console.WriteLine("D5 to Local: " + d5.ToLocalTime());
            Console.WriteLine("D5 to Utc: " + d5.ToUniversalTime());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(d5.ToString("yyyy-MM-ddTHH:mm:ssZ"));     // CUIDADO! É NECESSARIO VERIFICAR SE A INICIALIZAÇÃO DO OBJETO SE ENCONTRA NO PADRÃO UTC. COMO NO EXEMPLO ABAIXO.
            Console.WriteLine(d5.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"));
        }
    }
}