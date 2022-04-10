using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Base
{
    public Base()
    {
        Console.WriteLine("Constutor da classe base");
    }
    virtual public void info() // Método Virtual permite ser sobrescrito a partir da classe derivada
    {
        Console.WriteLine("Base");
    }
}
class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Constutor da classe Derivada 1");
    }
    override public void info() // override sobrescreve o metodo da classe base
    {
        Console.WriteLine("Derivada1");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Constutor da classe Derivada 2");
    }
    override public void info()
    {
        Console.WriteLine("Derivada2");
    }
}

namespace Ordem_de_execução_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Base Ref; // permite ter controle sobre cada um dos métodos a partir da classe basse
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();

            derivada2.info(); // uma das opções de controle sem a utilização do Ref
                        
            Ref = derivada1;
            Ref.info();           

           

            Console.ReadKey();
        }
    }
}


