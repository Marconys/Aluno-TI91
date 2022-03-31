using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Preenchimento_Somar_Linhas_e_colunas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            Random rand = new Random();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    matriz[linha, coluna] = rand.Next(15);
                    Console.Write(matriz[linha, coluna]);
                }
                Console.WriteLine(" ");
            }

            //Somar as linhas da matriz
            int [] somal = new int[3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    somal[linha] += matriz[linha, coluna];
                }
                Console.WriteLine($"A soma da linha {linha + 1} é: {somal[linha]}");
            }
            Console.WriteLine("-------------------------------------------------------");
            // somar colunas da matriz

            int[] somac = new int[3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    somac[coluna] += matriz[linha, coluna];
                }
            }
            for (int coluna = 0; coluna < 3; coluna++)
            {
                Console.WriteLine($"A soma da coluna {coluna + 1} é: {somac[coluna]}");
            }
            Console.ReadKey();
        }
    }
}
