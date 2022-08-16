using System;

namespace PrimoOuNao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado = 0, auxiliar;

            Console.Write("Informe um número: ");
            numero = int.Parse(Console.ReadLine());

            for (auxiliar = numero; auxiliar >= 1; auxiliar--)
            {
                Console.WriteLine(numero + " / " + auxiliar);
                if (numero % auxiliar == 0)
                {
                    resultado++;
                }
                Console.WriteLine(resultado);
            }
            if (resultado == 2)
            {
                Console.WriteLine("O número é primo!");
            }
            else
            {
                Console.WriteLine("O numero não é primo!");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
