using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TABUADA BÁSICA
            int tabuada, inicio, parada, resultado, soma = 0;

            Console.Write("Informe uma tabuada para ser calculada: ");
            tabuada = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("\nInforme um número de parada maior que o de inicio!!!");
                Console.Write("Informe o número de inicio da tabuada: ");
                inicio = int.Parse(Console.ReadLine());

                Console.Write("Informe o número de parada da tabuada: ");
                parada = int.Parse(Console.ReadLine());
            } while (parada < inicio);

            if (parada > inicio)
            {
                Console.Write("\nInforme o número de inicio da tabuada: ");
                inicio = int.Parse(Console.ReadLine());

                Console.Write("Informe o número de parada da tabuada: ");
                parada = int.Parse(Console.ReadLine());

                for (int i = inicio; i <= parada; i++)
                {
                    resultado = i * tabuada;
                    soma += resultado;
                    Console.WriteLine(i + " x " + tabuada + " = " + resultado);
                }
                Console.WriteLine("\nA soma dos resultados é: " + soma);

                Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
                Console.ReadKey();
            }
        }
    }
}
