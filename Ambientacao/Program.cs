using System;

namespace Ambientacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a sua idade em anos: ");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nBom dia, " + nome + "!\nSua idade é " + idade + " anos.");

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
