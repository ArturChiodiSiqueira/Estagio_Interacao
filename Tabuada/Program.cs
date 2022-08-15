using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada, inicio, parada, resultado, soma=0;

            Console.Write("Informe uma tabuada para ser calculada: ");
            tabuada = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o número de inicio da tabuada: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de parada da tabuada: ");
            parada = int.Parse(Console.ReadLine());

            if (parada < inicio)
            {
                Console.WriteLine("informe um numero de parada menor que o de inicio");
            }
            else
            {
                for (int i = inicio; i <= parada; i++)
                {
                    resultado = i * tabuada;
                    soma += resultado;
                    Console.WriteLine(i + " x " + tabuada + " = " + resultado);
                }
                Console.WriteLine("\nA soma dos resultados é: " + soma);
            }
        }
    }
}
