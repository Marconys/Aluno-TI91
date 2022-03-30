using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 40;

            Console.WriteLine("Insira um valor a ser somado");

            int ValorInseridoPeloUsuario = Convert.ToInt16( Console.ReadLine());

            SomarValor(ref valor, ValorInseridoPeloUsuario);

            Console.WriteLine("Resultado:" + valor);
            Console.ReadKey();
        }

        private static void SomarValor(ref int valor, int intervalo)
        {
            if (intervalo == 0)
                valor++;
            else
                valor = valor + intervalo;
        }
    }
}
