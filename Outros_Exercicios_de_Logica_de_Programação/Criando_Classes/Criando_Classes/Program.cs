using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Criando uma classe Jogador
public class Jogador
{
   public int energia = 100;
   public bool vivo = true;
}

namespace Criando_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando e instanciando um Objeto a partir da nossa classe jogador
            Jogador J1 = new Jogador();

            J1.energia = 50; // Alterando o valor da propriedade energia 
            // Ler a propriedade do Jogador
            Console.WriteLine("Energia do jogador 1: {0}",J1.energia);

            Console.ReadKey();
        }
    }
}
