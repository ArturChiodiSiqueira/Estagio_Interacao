using System;

namespace OperacaoBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultadoSom, resultadoSub, resultadoMul, resultadoDiv;

            Console.Write("informe o numero 1: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.Write("informe o numero 2: ");
            numero2 = double.Parse(Console.ReadLine());

            resultadoSom = numero1 + numero2;
            resultadoSub = numero1 - numero2;
            resultadoMul = numero1 * numero2;

            if (numero2 == 0.0)
            {
                Console.WriteLine("NÃO HAVERÁ DIVISÃO POR ZERO");
            }
            else
            {
                resultadoDiv = numero1 / numero2;
                Console.WriteLine("o resultado da divisão é " + resultadoDiv);
            }
            Console.WriteLine("\no resultado da adição é " + resultadoSom + "\no resultado da subtração é " + resultadoSub + "\no resultado da multiplicação é " + resultadoMul);

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
