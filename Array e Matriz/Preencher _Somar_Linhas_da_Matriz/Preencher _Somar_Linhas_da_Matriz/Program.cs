using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preencher__Somar_Linhas_da_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 2];

            Random rand = new Random();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    matriz[linha, coluna] = rand.Next(9);
                    Console.Write(matriz[linha, coluna]);
                }
                Console.WriteLine(" ");
            }

            int[] soma = new int[3];
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    soma[linha] += matriz[linha, coluna];
                }
                Console.WriteLine($"A soma da {linha + 1} é: {soma[linha]}");
            }

            Console.ReadKey();
        }
    }
}
