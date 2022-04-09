using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Veiculo // Classe base
{
    public string tipo;
    private int rodas;
    private bool ligado;

    public Veiculo(int rodas)
    {
        this.rodas = rodas; // Será inicializado na classe derivada
        tipo = "Terrestre"; // inicializado na classe base
    }

    public void Ligar()
    {
        ligado = true;

    }
    public void Desligar()
    {
        ligado = false;

    }

    public string getligado() // metodo para visualizar o estado do carro uma vez que o atributo ligado foi criado como private
    {
        return (ligado ? "On" : "Off"); // operador ternário 
    }

    public int getrodas()
    {
        return rodas;
    }
    public void setrodas(int r)
    {
        if(r < 0) 
        {
            rodas = 4;
        }
        else if(r > 20)
        {
            rodas += 2;
        }
        else
        {
            rodas = r;
        }
            

    }

}


class Carro : Veiculo
{
    // Classe derivada

    public string nome;
    public string cor;
    public int VeloMax;
    

    public Carro(string nome, string cor) : base(4) // Inicializando o argumento do construtor base
    {
        Desligar(); // inicialisando o objeto "Carro desligado"
        this.nome = nome;
        this.cor = cor;
        VeloMax = 120;
    }
}
class CarroCombate : Carro
{
    public int monicao;
    public string torreta;

    public CarroCombate(string nome, string cor, string torreta) : base(nome, cor) // Criando construtor e inicializando os atributos
                                                                                   // através do construtor base
    {
        this.torreta = torreta;
        monicao = 100;
        Ligar();
    }
}


namespace Herança_De_classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro C1 = new Carro("Fuscão", "Preto");
            CarroCombate CC1 = new CarroCombate("Urutu", "Seva","MG42");

            CC1.setrodas(8);

            Console.WriteLine("O {0} {1} é um veículo {2} e possui {3} rodas e esta {4}", C1.nome, C1.cor, C1.tipo, C1.getrodas(), C1.getligado());
            Console.WriteLine("O {0} {1} é um veículo {2} e possui {3} rodas e esta {4}", CC1.nome, CC1.cor, CC1.tipo, CC1.getrodas(), CC1.getligado());
            Console.WriteLine("A Torreta {0}e possui {1} balas", CC1.torreta, CC1.monicao);

            Console.ReadKey();
        }
    }
}
