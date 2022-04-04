using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_Somar_Colunas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"Matriz[3,3]\nDigite o índice [{linha},{coluna}]:");
                    matriz[linha,coluna] = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                }
                
            }

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write(matriz[linha,coluna]);
                }
                Console.WriteLine();
            }

            // Somar as linhas

            Console.WriteLine("----------------------\n\nSoma das Linhas\n\n-----------------------");

            int[] somal = new int[3];

            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    somal[linha] += matriz[linha, coluna];
                }
                Console.WriteLine($" A soma da Linha {linha + 1} é: {somal[linha]}");
            }

            // Somar colunas

            Console.WriteLine("----------------------\n\nSoma das Colunas\n\n-----------------------");

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
                Console.WriteLine($" A soma da coluna {coluna + 1} é: {somac[coluna]}");
            }

            Console.ReadKey();
        }
    }
}
        
    

