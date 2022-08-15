using System;

namespace ConversaoDeGraus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grauC, grauF;

            Console.Write("Informe a temperatura em °C: ");
            grauC = double.Parse(Console.ReadLine());

            grauF = grauC * 1.8 + 32;

            Console.WriteLine("A temperatura em °F é: " + grauF);

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
