using System.Globalization;
using System.Xml;

namespace ExemploOO16_TimeSpan {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo ci = CultureInfo.InvariantCulture;
            
            TimeSpan t = new TimeSpan();                /// FUNÇÃO PARA CONSULTAR E INSERIR HORAS.
            TimeSpan t1 = new TimeSpan(0, 1, 30);       /// ATRIBUINDO VALOR AO OBJETO MINUTOS E SEGUNDOS.
            TimeSpan t2 = new TimeSpan(900000000L);     /// ATRIBUINDO VALOR AO OBJETO A PARTIR DOS NANOSEGUNDOS. 
            TimeSpan t3 = new TimeSpan(18, 16, 20);     /// ATRIBUINDO VALOR AO OBJETO HORA,MINUTOS, SEGUNDOS.
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);   /// ATRIBUINDO VALOR AO OBJETO DIA, HORA, MINUTOS E SEGUNDOS.
            TimeSpan t5 = new TimeSpan(1,3,12,23,333);  /// ATRIBUINDO VALOR AO OBJETO DIA, HORA, MINUTOS, SEGUNDOS E MILLISEGUNDOS.

            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks); /// FUNCAO PARA CONSULTAR OS NANOSEGUNDOS.
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine("----------------------------------");

            TimeSpan t6 = TimeSpan.FromDays(1.3);           /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE DIAS QUEBRADOS(FORMA DECIMAL).
            TimeSpan t7 = TimeSpan.FromHours(1.5);          /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE HORAS QUEBRADAS(FORMA DECIMAL).
            TimeSpan t8 = TimeSpan.FromMinutes(1.5);        /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE MINUTOS QUEBRADOS(FORMA DECIMAL).
            TimeSpan t9 = TimeSpan.FromSeconds(1.5);        /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE SEGUNDOS QUEBRADOS(FORMA DECIMAL).
            TimeSpan t10 = TimeSpan.FromMilliseconds(1.5);  /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE MILLISEGUNDOS QUEBRADOS(FORMA DECIMAL).
            TimeSpan t11 = TimeSpan.FromTicks(900000000L);  /// FUNÇÃO PARA CONSULTAR AS HORAS A PARTIR DE NANOSEGUNDOS.

            Console.WriteLine(t6);
            Console.WriteLine(t7);
            Console.WriteLine(t8);
            Console.WriteLine(t9);
            Console.WriteLine(t10);
            Console.WriteLine(t11);
            Console.WriteLine("----------------------------------");
            
            //-------------------------------------- PROPIEDADES E OPERAÇÕES COM TIMESPAN -----------------------------------------------------

            TimeSpan t12 = TimeSpan.MaxValue;       /// FUNÇÃO PARA VERIFICAR O MAXIMO DE TEMPO
            TimeSpan t13 = TimeSpan.MinValue;       /// FUNÇÃO PARA VERIFICAR O MINIMO DE TEMPO
            TimeSpan t14 = TimeSpan.Zero;   

            Console.WriteLine(t12);
            Console.WriteLine(t13);
            Console.WriteLine(t14);
            Console.WriteLine("----------------------------------");
            
            TimeSpan t15 = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t15);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Days: " + t15.Days);
            Console.WriteLine("Hours: " + t15.Hours);
            Console.WriteLine("Minutes: " + t15.Minutes);
            Console.WriteLine("Seconds: " + t15.Seconds);
            Console.WriteLine("MilliSeconds: " + t15.Milliseconds);
            Console.WriteLine("Ticks: " + t15.Ticks);
            Console.WriteLine("----------------------------------");
            Console.WriteLine("TotalDays: " + t15.TotalDays);
            Console.WriteLine("TotalHours: " + t15.TotalHours);
            Console.WriteLine("TotalMinutes: " + t15.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t15.TotalSeconds);
            Console.WriteLine("TotalMilliSeconds: " + t15.TotalMilliseconds);
            
            Console.WriteLine("----------------------------------");

            TimeSpan t16 = new TimeSpan(1, 30, 10);
            TimeSpan t17 = new TimeSpan(0, 10, 5);

            TimeSpan sum = t16.Add(t17);        /// FUNÇÃO PARA SOMAR AS HORAS.
            TimeSpan dif = t16.Subtract(t17);   /// FUNÇÃO PARA SUBTRAIR AS HORAS.
            TimeSpan mult = t17.Multiply(2.0);  /// FUNÇÃO PARA MULTIPLICAR AS HORAS.
            TimeSpan div = t17.Divide(2.0);     /// FUNÇÃO PARA DIVIDIR AS HORAS.

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);

        }
    }
}