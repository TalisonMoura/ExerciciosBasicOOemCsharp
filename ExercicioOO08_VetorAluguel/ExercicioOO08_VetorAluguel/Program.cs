using System.Numerics;

namespace ExercicioOO08_VetorAluguel {
    internal class Program {
        static void Main(string[] args) {

            Estudante[] vect = new Estudante[10];

            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                String Name = Console.ReadLine();
                Console.Write("Email: ");
                String Email = Console.ReadLine();
                Console.Write("Room: ");
                int Room = int.Parse(Console.ReadLine());
                vect[Room] = new Estudante(Name, Email);
                Console.WriteLine();
            }
            Console.WriteLine("Busy Rooms: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}