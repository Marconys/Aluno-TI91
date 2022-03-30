using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome_Correto_Nome_Incorreto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NomeUsuario = "Marconys";            
            string NomeInserido;

            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite do nome do usuário: ");
                NomeInserido = Console.ReadLine();
                tentativas++;

            } while (NomeInserido != NomeUsuario && tentativas <3);



            if (NomeInserido == NomeUsuario)
            {
                Console.WriteLine("Nome Correto!");
            }
            else
            {
                Console.WriteLine($"Nome Incorreto, você excedeu o numero de {tentativas} tentivas");
            }

            Console.ReadKey();
        }
    }
}
