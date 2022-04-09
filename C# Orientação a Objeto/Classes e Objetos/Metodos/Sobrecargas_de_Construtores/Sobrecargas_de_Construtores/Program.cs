using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jogador
{
    //Atributos
    private string nome;
    private int energia;
    private bool vivo;

    //Propriedades
    public string Nome { get { return nome; } set { nome = value; } }
    public int Energia { get { return energia; } set { energia = value; } }
    public bool Vivo { get { return vivo; } set { vivo = value; } }
    // Métodos construtores
    public Jogador()
    {
        nome = "Jogador";
        energia = 100;
        vivo = true;
    }
    public Jogador(string n)
    {
        nome = n;
        energia = 100;
        vivo = true;
    }
    public Jogador(string n, int e)
    {
        nome = n;
        energia = e;
        vivo = true;
    }
    public Jogador(string n, int e, bool v)
    {
        nome = n;
        energia = e;
        vivo = v;
    }
    //Método da Classe
    public void info()
    {
        Console.WriteLine("Nome do Jogador: {0}",nome);
        Console.WriteLine("Energia do Jogador: {0}",energia);
        Console.WriteLine("Estado do Jogador: {0}\n",vivo);

    }
}

namespace Sobrecargas_de_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador J1 = new Jogador();
            Jogador J2 = new Jogador("Marconys");
            Jogador J3 = new Jogador("José", 100);
            Jogador J4 = new Jogador("Elias",30,true);
            Jogador J5 = new Jogador("Vinicius",0,false);

            J1.info();
            J2.info();
            J3.info();
            J4.info();
            J5.info();

            Console.ReadKey();
        }
    }
}
