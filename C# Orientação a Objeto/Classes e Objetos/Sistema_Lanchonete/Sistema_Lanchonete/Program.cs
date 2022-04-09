using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

public class Lanche
{
    public string Nome;
    public double Preço;
    public int Codigo;

    public Lanche(string nome, double preco, int codigo )
    {
        Nome = nome;
        Preço = preco;
        Codigo = codigo;
    }
}

namespace Sistema_Lanchonete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lanche Lanche1 = new Lanche("Cachorro Quente",10.00, 1);
            Lanche Lanche2 = new Lanche("X-Bacon", 15.00, 2);
            Lanche Lanche3 = new Lanche("X-Salada", 25.00, 3);
            Lanche Lanche4 = new Lanche("Refigerante", 12.00, 4);

            Console.WriteLine("Código Produto Valor\n{0} {1} {2}",Lanche1.Codigo,Lanche1.Nome,Lanche1.Preço.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("{0} {1} {2}", Lanche2.Codigo, Lanche2.Nome, Lanche2.Preço.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadKey();


        }
    }
}
