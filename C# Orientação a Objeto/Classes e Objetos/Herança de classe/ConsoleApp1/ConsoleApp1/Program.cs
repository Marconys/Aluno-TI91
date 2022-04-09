using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Veiculo // Classe base
{
     public string tipo;
     public int rodas;
    private bool ligado;

    public Veiculo()
    {
        rodas = 4;
        tipo = "Terrestre";
    }

    public void Ligar()
    {
        ligado = true;
        
    }
    public void Desligar()
    {
        ligado = false;
        
    }

    public string getligado()
    {
        if (ligado)
        { 
            return "Ligado";
        } 
        else {
            return "Desliado"; 
        }
    }

}
public class Carro : Veiculo
{
    // Classe derivada

    public string nome;
    public string cor;
    

    public Carro(string nome, string cor)
    {
        Desligar();
        this.nome = nome;
        this.cor = cor;
    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro C1 = new Carro( "Fuscão","Preto");

            Console.WriteLine("O {0} {1} é um veículo {2} e possui {3} rodas e esta {4}",C1.nome,C1.cor,C1.tipo, C1.rodas,C1.getligado());

            Console.ReadKey();
        }
    }
}
