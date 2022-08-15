using System;

namespace SimuladorCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, resultado;
            int opcao;

            Console.Write("Informe o 1° valor: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o 2° valor: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação desejada:\n\t{1} Soma\n\t{2} Subtração\n\t{3} Multiplicação\n\t{4} Divisão\nOpção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                resultado = numero1 + numero2;
            }

            Console.WriteLine("O resultado da operação é: " + resultado);
        }
    }
}
