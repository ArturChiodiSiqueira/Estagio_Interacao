using System;

namespace MediaDoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, media;

            Console.Write("informe a nota 1: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.Write("informe a nota 2: ");
            nota2 = double.Parse(Console.ReadLine());
            Console.Write("informe a nota 3: ");
            nota3 = double.Parse(Console.ReadLine());
            Console.Write("informe a nota 4: ");
            nota4 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media < 5)
            {
                Console.WriteLine("VOCÊ FOI REPROVADO! E TEM MEDIA: " + media);
            }
            if (media >= 5 && media < 7)
            {
                Console.WriteLine("VOCÊ ESTÁ DE RECUPERAÇÃO! E TEM MEDIA: " + media);
            }
            if (media >= 7 && media <= 10)
            {
                Console.WriteLine("VOCÊ ESTÁ APROVADO! E TEM MEDIA: " + media);
            }
            Console.WriteLine("\n\nPressione qualquer tecla para finalizar.");
            Console.ReadKey();
        }
    }
}
