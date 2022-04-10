using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ano_Bissexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um ano com 4 digitos ex 1950");
            int Ano = Int32.Parse(Console.ReadLine());

            // Estrutura condicional

            if ((Ano % 400 == 0) || (Ano % 4 == 0) && (Ano % 100 != 0))
            {
                Console.WriteLine("O ano {0} é bissexto!", Ano);
            }
            else
            {
                Console.WriteLine("O ano {0} não é bissexto!", Ano);
            }
            Console.ReadKey();
        }
    }
}
