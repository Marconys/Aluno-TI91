using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

// Classe Lanche
public class Lanche
{
    public string Nome;
    public int Codigo;
    public double Preco;

    //Metodo Construtor
    public Lanche(string nome, int codigo, double preco)
    {
        Nome = nome;
        Codigo = codigo;
        Preco = preco;
    }
}

namespace Sistema_lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Quantidade = 0;
            int Codigo1 = 0;
            double Total = 0;
            string Sair = "";

            Lanche L1 = new Lanche("X-Burger",1,15.90);
            Lanche L2 = new Lanche("X-Bacon", 2, 18.90);
            Lanche L3 = new Lanche("Batata", 3, 10.90);

            do
            {
                Console.WriteLine("-----------------------------\nCARDÁPIO\n-----------------------------\n");
            Console.WriteLine("{0} {1} {2}", L1.Codigo, L1.Nome, L1.Preco.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("{0} {1} {2}", L2.Codigo, L2.Nome, L2.Preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("{0} {1} {2}", L3.Codigo, L3.Nome, L3.Preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("-----------------------------\nPEDIDO\n-----------------------------\n");

            
                Console.Write("Escolha o lanche digitando o código do produto: ");
            Codigo1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("\nQuantas unidades?: ");
            Quantidade = Convert.ToInt32(Console.ReadLine());                        

            

            
            if(Codigo1 == 1)
            {
                Console.Clear();
                Total = (Quantidade * L1.Preco);
                Console.WriteLine("-----------------------------\nPEDIDO CONCLUIDO\n-----------------------------\n");
                Console.WriteLine("Você escolheu {0} unidade(s) de {1} Total R$ {2}",Quantidade,L1.Nome,Total.ToString("F2", CultureInfo.InvariantCulture));
                

            }
            else if(Codigo1 == 2)
            {
                Console.Clear();
                Total = (Quantidade * L2.Preco);
                Console.WriteLine("-----------------------------\nPEDIDO CONCLUIDO\n-----------------------------\n");
                Console.WriteLine("Você escolheu {0} unidade(s) de {1} Total R$ {2}", Quantidade, L2.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (Codigo1 == 3)
            {
                Console.Clear();
                Total = (Quantidade * L3.Preco);
                Console.WriteLine("-----------------------------\nPEDIDO CONCLUIDO\n-----------------------------\n");
                Console.WriteLine("Você escolheu {0} unidade(s) de {1} Total R$ {2}", Quantidade, L3.Nome, Total.ToString("F2", CultureInfo.InvariantCulture));

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Código do Produto Digitado inexistente");
            }
                Console.WriteLine("-----------------------------\n\n-----------------------------\n");
                Console.Write("Deseja Fazer outro Pedido? (s/n): ");
                Sair = Console.ReadLine();

                Console.Clear();
            } while (Sair == "S" || Sair == "s");

            Console.WriteLine("Obrigado Pela Preferência");
            Console.ReadKey();

        }
    }
}
