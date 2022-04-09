using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Jogador
{
    public string nome; // Public permite acessar e alterar o atributo fora da classe
    private int energia; // Não permite acessar o atributo fora da classe,
                         // sendo necessário para isto a criação de métodotos de classe, nesse caso criamos o getenergia(); e o setenergia();
    

    public Jogador(string nome)
    {
        this.nome = nome;
        energia = 100;
    }
    public int getenergia()
    {
        
        return energia;
    }

    public void setenergia(int e)
    {
        if(e < 0)
        {
            if (energia - e < 0)
            { 
                energia = 0;
            }
            else
            {
                energia += e;
            }
        } else if( e > 0)
        {
            if(energia + e > 100)
            {
                energia = 100;
            }
            else
            {
                energia += e;
            }
        }
        
         
    }
   
}

namespace Public_Private
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador J1 = new Jogador("Marconys");

            J1.setenergia(120);
            J1.setenergia(-30);

            Console.WriteLine("O Jogador {0} esta com  {1}% de enerigia",J1.nome,J1.getenergia());

            Console.ReadKey();
        }
    }
}
