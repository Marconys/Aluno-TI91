using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Sistema_Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Produtos = { "Lanches", "Cachorro Quente", "X-Salada", "X-Bacon", "Refrigerante" };
            int[] Codigo = new int[] { 0, 1, 2, 3,4 };
            double[] Preco = new double[] { 0.00, 10.00, 15.00, 20.00, 12.00 };
            int Quantidade = 0;
            double Total = 0;
            int i = 0;
            string Sair = "";



            Console.WriteLine("-----------------------------------\nCARDÁPIO\n-----------------------------------");

            


            do
            {

                for (i = 0; i < Codigo.Length; i++)
                {
                    Console.WriteLine("{0} {1} R$ {2}", Codigo[i], Produtos[i], Preco[i].ToString("F2", CultureInfo.InvariantCulture));
                }
                Console.WriteLine("-----------------------------------\nPEDIDO\n-----------------------------------");

                Console.WriteLine("Digite o código do seu lanche");
                i = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("Digite a quatidade");

                Quantidade = Convert.ToInt32(Console.ReadLine());

            Total = (Preco[i] * Quantidade);

                Console.WriteLine("Concluir Pedido (S/N):");
                Sair = Console.ReadLine();
                Console.Clear();

            } while (Sair != "S" && Sair != "s");
            Console.WriteLine("-----------------------------------\nPEDIDO CONCLUÍDO\n-----------------------------------");
            Console.WriteLine("Você escolheu {0} unidade(s) de {1} Total R$ {2}",Quantidade,Produtos[i],Total.ToString("F2",CultureInfo.InvariantCulture));



            
            





            Console.ReadKey();
        }
    }
}
