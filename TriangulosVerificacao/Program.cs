using System;

namespace TriangulosVerificacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lado1, lado2, lado3;

            Console.Write("informe o primeiro lado: ");
            lado1 = double.Parse(Console.ReadLine());

            Console.Write("informe o segundo lado: ");
            lado2 = double.Parse(Console.ReadLine());

            Console.Write("informe o terceiro lado: ");
            lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("\nTriângulo Equilatero.");
            }
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
            {
                Console.WriteLine("\nTriângulo Isosceles.");
            }
            else
            {
                Console.WriteLine("\nTriângulo Escaleno");
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
