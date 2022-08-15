using System;

namespace SimuladorCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1, numero2, resultado;

            Console.Write("Informe o 1° valor: ");
            numero1 = float.Parse(Console.ReadLine());

            Console.Write("Informe o 2° valor: ");
            numero2 = float.Parse(Console.ReadLine());
        }
    }
}
