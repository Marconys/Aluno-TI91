using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz_SomarElementos_Tamanho_Média
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 2];
            int tamanho =0, soma =0;

            // Preenchendo e calculando o tamanho da matriz
            Random random = new Random();
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    matriz[linha,coluna] = random.Next(10);
                    Console.Write(matriz[linha,coluna]);
                    tamanho += 1;
                }
                Console.WriteLine("");
                
            }

            // Somando todos os elementos da matriz
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    soma += matriz[linha, coluna];
                }
            }
            Console.WriteLine($"A soma de todos os elementos da matriz é: {soma} \nA matriz possui tamanho {tamanho} \nA média é {soma / tamanho}");
            Console.ReadKey();
        }
    }
}
