using System;

namespace PrimoOuNao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero % 1 != numero && numero % numero != 0)
            {
                Console.WriteLine("O número não é primo!");
            }
            else
            {
                Console.WriteLine("O numero é primo");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
