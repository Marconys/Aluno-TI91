using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tratamento_de_erros
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "marcony", "carlos", "elias", "zé", "cauã" };

            try
            {
                Console.WriteLine();
                Console.Write("Buscar um nome: ");

                string Buscarnome = Console.ReadLine();

                int posicao = Array.IndexOf(nomes, Buscarnome.ToLower());

                Console.WriteLine($"Achei o nome: {nomes[posicao]} na posição {posicao}");

                int valor = 0;
                int res = 10 / valor;
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("Operação não pode ser executada!");

            }
            catch (Exception)
            {

                Console.WriteLine("O nome não esta na lista!");
                
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
