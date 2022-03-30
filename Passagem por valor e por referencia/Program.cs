using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passagem_por_valor_e_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            dobrar( ref num);
            Console.WriteLine(num);

            Console.ReadKey();
        }
        // Passagem por referência // Ela usa o endereço de memória da variável que foi passada como argumento // vai alterar o valor dessa memória
        static void dobrar(ref int valor)
        {
            valor *= 2;           
        }
        // Passagem por valor // Não usa o endereço de memória, ele vai criar outra posição na memoria e copiar o valor da variavél para a posição
        // passado como argumento
        static void dobrar1(int valor)
        {
            valor *= 2;
        }
    }
}
