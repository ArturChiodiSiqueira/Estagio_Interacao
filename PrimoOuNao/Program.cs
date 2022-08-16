using System;

namespace PrimoOuNao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, resultado = 0, aux;

            Console.Write("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            for (aux = num; aux >= 1; aux--)
            {
                Console.WriteLine(num + " / " + aux);
                if (num % aux == 0)
                {
                    resultado++;
                }
                Console.WriteLine(resultado);
            }
            if (resultado != 2)
            {
                Console.WriteLine("O número não é primo!");
            }
            else
            {
                Console.WriteLine("O numero é primo!");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
