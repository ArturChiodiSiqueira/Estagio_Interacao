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

            if (numero % 2 != 0 || numero == 2)
            {
                Console.WriteLine("O número é primo!");
            }
            else
            {
                Console.WriteLine("O numero não é primo");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
