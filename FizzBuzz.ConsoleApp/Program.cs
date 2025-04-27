using System;
using FizzBuzz;

namespace FizzBuzz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein:");
            if (int.TryParse(Console.ReadLine(), out int zahl))
            {
                string ergebnis = FizzBuzzZaehler.FizzBuzz(zahl);
                Console.WriteLine($"Ergebnis: {ergebnis}");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
            }
        }
    }
}
