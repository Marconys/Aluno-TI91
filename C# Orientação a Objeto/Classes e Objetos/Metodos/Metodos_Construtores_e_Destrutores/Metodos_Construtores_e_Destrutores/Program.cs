using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jogador
{
    public int energia;
    public bool vivo;
    public string nome;

    // Metodo Construtor
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    ~Jogador()
    {
        Console.WriteLine("Jogador {0} foi destruido!",nome);
    }
}

namespace Metodos_Construtores_e_Destrutores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            Console.WriteLine("Digite o Nome do Jogador 1");
            nome1 = Console.ReadLine();
            Jogador J1 = new Jogador(nome1);
            Jogador J2 = new Jogador("José");

            Console.WriteLine("Nome do Jogador 1: {0}\nNome do Jogador 2:{1}",J1.nome,J2.nome);

            Console.ReadKey();
        }
        
    }
}
