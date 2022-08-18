using System;

namespace EstudoSobreMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int[,] mat = new int[5, 3];

            mat[0, 0] = 10;
            mat[1, 0] = 20;

            Random r = new Random();
            for (int col = 0; col < 3; col++)
            {
                for (int lin = 0; lin < 5; lin++)
                {
                    mat[lin, col] = r.Next(100);
                }
            }
            Console.WriteLine("A matriz é:");
            for (int lin = 0; lin < 5; lin++)
            {
                //Console.WriteLine("conteudo da coluna: " + lin);
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("matriz[{0},{1}]={2}\t", lin, col, mat[lin,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
