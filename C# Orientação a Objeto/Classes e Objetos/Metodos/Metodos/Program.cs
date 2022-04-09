using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, r;
            valor1 = Convert.ToInt32(Console.ReadLine());
             valor2 = Convert.ToInt32(Console.ReadLine());

            // Método soma(); 
            soma(valor1, valor2);
            // Método somar();
            //r = somar(valor1, valor2);
            // Console.WriteLine("A soma de {0} e {1} é: {2}", valor1, valor2, r);
            Console.WriteLine("A soma de {0} e {1} é: {2}", valor1, valor2, somar(valor1, valor2));

            Console.ReadKey();
        }
        
        // Método soma(); retorno void
        static void soma(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A soma de {0} e {1} é: {2}",n1,n2,res);
        }

        // Método somar(); retorno int
        static int somar(int n1, int n2)
        {
            Console.WriteLine("return res; -------------------------------------------");
            int res = n1 + n2;
            return res;
        }
    }
}
