using System;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada, inicio, parada, resultado;

            Console.Write("Informe uma tabuada para ser calculada: ");
            tabuada = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o número de inicio da tabuada: ");
            inicio = int.Parse(Console.ReadLine());

            Console.Write("Informe o número de parada da tabuada: ");
            parada = int.Parse(Console.ReadLine());

            for (int i = inicio; i <= parada; i++)
            {
                resultado = i * tabuada;
                Console.WriteLine("\n" + i + " x " + tabuada + " = " + resultado);
            }
        }
    }
}
