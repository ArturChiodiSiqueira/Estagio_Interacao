using System;

namespace SomaVetoresTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vetor1 = new char[5];
            char[] vetor2 = new char[5];
            char[] vetor3 = new char[10];
            int contV = 0, contC = 0;

            int aux = 0;

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2[i] = char.Parse(Console.ReadLine().ToUpper());
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write(vetor1[i] + " ");
            }
            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write(vetor2[i] + " ");
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor3[aux] = vetor1[i];
                aux++;
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor3[aux] = vetor2[i];
                aux++;
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.Write(vetor3[i] + " ");
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                if (vetor1[i] == 'A' || vetor1[i] == 'E' || vetor1[i] == 'I' || vetor1[i] == 'O' || vetor1[i] == 'U')
                {
                    contV++;
                    vetor1[i] = char.ToLower(vetor1[i]);
                }
                else
                    contC++;
            }

            for (int i = 0; i < vetor1.Length; i++)
            {
                Console.Write(vetor1[i] + " ");
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                if (vetor2[i] == 'A' || vetor2[i] == 'E' || vetor2[i] == 'I' || vetor2[i] == 'O' || vetor2[i] == 'U')
                {
                    contV++;
                    vetor2[i] = char.ToLower(vetor2[i]);
                }
                else
                    contC++;
            }

            for (int i = 0; i < vetor2.Length; i++)
            {
                Console.Write(vetor2[i] + " ");
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                if (vetor3[i] == 'A' || vetor3[i] == 'E' || vetor3[i] == 'I' || vetor3[i] == 'O' || vetor3[i] == 'U')
                {
                    contV++;
                    vetor3[i] = char.ToLower(vetor3[i]);
                }
                else
                    contC++;
            }

            for (int i = 0; i < vetor3.Length; i++)
            {
                Console.Write(vetor3[i] + " ");
            }
        }
    }
}
