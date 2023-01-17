using System.Globalization;

namespace ExemploOO15_FormatacaoData {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;

            DateTime d1 = DateTime.Now;     //FUNCAO PARA VERIFICAR O DATA/HORA.
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);    //FUNCAO NO QUAL ESTÁ ARMAZANADO UM CODIGO REFERENTE A DATA/HORA DO MOMENTO.
            Console.WriteLine("----------------------------------------------");
            DateTime d2 = new DateTime(2018, 11, 25);               //INSTANCIADO A OBJETO COM A DATA ESCOLHIDA.
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03);   //INSTANCIANDO A OBJETO COM A DATA E HORA ESCOLHIDA.
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 03, 500);

            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;   //FUNCAO PARA VERIFICAR A DATA DO DIA.
            DateTime d7 = DateTime.UtcNow;  //FUNCAO PARA VERIFICAR A DATA GLOBAL(GREENWICH).

            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine("----------------------------------------------");

            DateTime d8 = DateTime.Parse("1999-08-25");     /// FUNCAO PARA CONVERTER STRING EM DATA.
            DateTime d9 = DateTime.Parse("1999-08-25 14:54:58");    /// FUNCAO PARA CONVERTER STRING EM DATA E HORARIO.

            DateTime d10 = DateTime.Parse("25/08/1999");    /// VERIFICANDO FORMATACAO DE DATA PADRAO BRASILEIRO.
            DateTime d11 = DateTime.Parse("25/08/1999 15:54:58");   /// FUNCAO PARA CONVERTER STRING EM DATA E HORARIO PADRÃO BRASILEIRO.

            DateTime d12 = DateTime.ParseExact("1999-08-25", "yyyy-MM-dd", ci);
            DateTime d13 = DateTime.ParseExact("25/08/1999 17:54:58", "dd/MM/yyyy HH:mm:ss", ci);

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine(d12);
            Console.WriteLine(d13);
            Console.WriteLine("----------------------------------------------");
            //----------------------------------- PROPRIEDADES E OPERAÇÕES COM DATETIME -----------------------------------------


            DateTime d14 = new DateTime(1999, 8, 25, 13, 45, 58);

            Console.WriteLine(d14);
            Console.WriteLine("1) Date: " + d14.Date);
            Console.WriteLine("2) Day: " + d14.Day);
            Console.WriteLine("3) DayOfWeek: " + d14.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d14.DayOfYear);
            Console.WriteLine("5) Hour: " + d14.Hour);
            Console.WriteLine("6) Kind: " + d14.Kind);
            Console.WriteLine("7) MilliSecond: " + d14.Millisecond);
            Console.WriteLine("8) Minute: " + d14.Minute);
            Console.WriteLine("9) Month: " + d14.Month);
            Console.WriteLine("10) Second: " + d14.Second);
            Console.WriteLine("11) Ticks: " + d14.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d14.TimeOfDay);
            Console.WriteLine("13) Year: " + d14.Year);
            Console.WriteLine("----------------------------------------------");

            string s1 = d14.ToLongDateString();
            string s2 = d14.ToLongTimeString();
            string s3 = d14.ToShortDateString();
            string s4 = d14.ToShortTimeString();

            string s5 = d14.ToString();
            string s6 = d14.ToString("yyy-MM-dd HH:mm:ss");
            string s7 = d14.ToString("yyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            Console.WriteLine("----------------------------------------------");
            
            DateTime d15 = d14.AddHours(2);
            DateTime d16 = d14.AddMinutes(3);

            DateTime d17 = new DateTime(1999, 8, 25);
            DateTime d18 = new DateTime(1999, 8, 28);

            TimeSpan t = d18.Subtract(d17);

            Console.WriteLine(d14);
            Console.WriteLine(d15);
            Console.WriteLine(d16);
            Console.WriteLine(t);





        }

    }
}