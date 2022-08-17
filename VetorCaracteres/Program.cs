using System;

namespace VetorCaracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] letra = new char[10];
            int contV = 0, contC = 0;

            for (int i = 0; i < 10; i++)
            {
                letra[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write(letra[i]);
            }

            for (int i = 0; i < 10; i++)
            {
                if (letra[i] == 'A' || letra[i] == 'E' || letra[i] == 'I' || letra[i] == 'O' || letra[i] == 'U')
                    contV++;
                else
                    contC++;
            }
            Console.WriteLine("\nA palavra possui " + contV + " vogais e " + contC + " consoantes.");
        }
    }
}
