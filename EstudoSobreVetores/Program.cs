using System;

namespace EstudoSobreVetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[4];
            int i, valor;

            Console.WriteLine("Informe os valores para o vetor: ");
            for (i = 0; i < 4; i++)
            {
                Console.Write("informe o " + (i + 1) + "° valor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nos valores informados são: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("vet [" + i + "] = " + vet[i]);
            }

            Console.WriteLine("Informe um valor para multiplicar todos os valores do vetor: ");
            valor = int.Parse(Console.ReadLine());

            for (i = 0; i < 4; i++)
            {
                vet[i] = vet[i] * valor;
            }

            Console.WriteLine("\nos valores resultantes são: ");
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("vet [" + i + "] = " + vet[i]);
            }
        }
    }
}
