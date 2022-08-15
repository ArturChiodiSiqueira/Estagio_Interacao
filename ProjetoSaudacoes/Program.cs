using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ProjetoSaudacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FAÇA UM ALGORITMO QUE LEIA O NOME DE UM ALUNO E O HORARIO INFORMANDO.
            //BASEADO NO HORARIO, MOSTRE(BOM DIA + NOME, BOA TARDE + NOME, BOA NOITE + NOME)
            //- BOM DIA COMEÇA 00:00 ATE 11:59
            //- BOA TARDE COMEÇA 12:00 ATE 17:59            // O DIA TEM QUE TER 24H
            //- BOA NOITE COMEÇA 18:00 ATE 23:59
            string nome;
            int hora, minuto = 0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a hora: ");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o minuto: ");
            minuto = int.Parse(Console.ReadLine());

            for (hora = 0; hora <= 0 || hora > 23;)
            {
                Console.WriteLine("Informe a hora: ");
                hora = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("Informe o minuto: ");
                    minuto = int.Parse(Console.ReadLine());
                } while (minuto > 59 || minuto < 0);

                if (hora < 24 && hora < 24)
                {
                    if (hora >= 0 && hora >=0 && minuto > 60 && minuto >= 0)
                    {
                        Console.WriteLine("Bom dia, " + nome);
                    }
                    else if (hora >= 12 && hora < 18)
                    {
                        Console.WriteLine("Boa tarde, " + nome);
                    }
                    else
                    {
                        Console.WriteLine("Boa noite, " + nome);
                    }
                }
                else
                {
                    
                }
            }
        }
    }
}