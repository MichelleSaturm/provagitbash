using System;

namespace ProvaGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero da 0 a 9");
            char n;

            n = Console.ReadKey().KeyChar;

            Console.WriteLine("\nInserisci una lettera dalla A alla Z");
            char alfa;

            
            alfa = Console.ReadKey().KeyChar;

            Console.WriteLine($"\nCiao! Hai scelto la lettera {alfa} e il numero {n}!");
            

            
        }
    }
}
