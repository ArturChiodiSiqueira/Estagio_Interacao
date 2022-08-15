using System;

namespace ReajustesSalariais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioAtual, salarioFinal;

            do
            {
                Console.Clear();
                Console.Write("Informe seu salario atual: ");
                salarioAtual = double.Parse(Console.ReadLine());
            } while (salarioAtual < 1000);

            if (salarioAtual < 2000)
            {
                salarioFinal = (salarioAtual * 0.1) + salarioAtual;
                Console.WriteLine("O salario final é: " + salarioFinal);
            }
            if (salarioAtual >= 2000 && salarioAtual < 3000)
            {
                salarioFinal = (salarioAtual * 0.05) + salarioAtual;
                Console.WriteLine("O salario final é: " + salarioFinal);
            }
            if (salarioAtual >= 3000)
            {
                salarioFinal = salarioAtual;
                Console.WriteLine("Sem aumento para você! :(");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
