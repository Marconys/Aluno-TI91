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
}
class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Constutor da classe Derivada 1");
    }
}
class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Constutor da classe Derivada 2");
    }
}

namespace Ordem_de_execução_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();

            // A execução sempre será da classe base para a derivada!

            Console.ReadKey();
        }
    }
}

