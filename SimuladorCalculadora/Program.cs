using System;

namespace SimuladorCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CALCULADORA DE OPERAÇÕES BÁSICAS.
            float numero1, numero2, resultado = 0;
            int opcao;

            Console.Write("Informe o 1° valor: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o 2° valor: ");
            numero2 = float.Parse(Console.ReadLine());

            Console.Write("Informe a operação desejada:\n\t{1} Soma\n\t{2} Subtração\n\t{3} Multiplicação\n\t{4} Divisão\nOpção: ");
            opcao = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Informe uma opção valida!\n");
                Console.Write("Informe a operação desejada:\n\t{1} Soma\n\t{2} Subtração\n\t{3} Multiplicação\n\t{4} Divisão\nOpção: ");
                opcao = int.Parse(Console.ReadLine());
            } while (opcao < 1 || opcao > 4);

            switch (opcao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;

                case 2:
                    resultado = numero1 - numero2;
                    break;

                case 3:
                    resultado = numero1 * numero2;
                    break;

                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por zero!");
                    }
                    else
                        resultado = numero1 / numero2;
                    break;
            }
            Console.WriteLine("O resultado da operação é: " + resultado);

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}