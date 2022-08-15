using System;

namespace MaiorAndMenorNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, numero3;

            do
            {
                Console.Write("informe o número 1: ");
                numero1 = double.Parse(Console.ReadLine());
                Console.Write("informe o número 2: ");
                numero2 = double.Parse(Console.ReadLine());
                Console.Write("informe o número 3: ");
                numero3 = double.Parse(Console.ReadLine());

            } while ((numero1 <= 0 || numero1 == numero2 || numero1 == numero3) || (numero2 <= 0 || numero2 == numero1 || numero2 == numero3) || (numero3 <= 0 || numero3 == numero1 || numero3 == numero2));
            //maior
            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("numero 1 maior e tem valor de: " + numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("numero 2 maior e tem valor de: " + numero2);
            }
            else if (numero3 > numero1 && numero3 > numero2)
            {
                Console.WriteLine("numero 3 maior e tem valor de: " + numero3);
            }
            //menor
            if (numero1 < numero2 && numero1 < numero3)
            {
                Console.WriteLine("numero 1 menor e tem valor de: " + numero1);
            }
            else if (numero2 < numero1 && numero2 < numero3)
            {
                Console.WriteLine("numero 2 menor e tem valor de: " + numero2);
            }
            else if (numero3 < numero1 && numero3 < numero2)
            {
                Console.WriteLine("numero 3 menor e tem valor de: " + numero3);
            }

            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
