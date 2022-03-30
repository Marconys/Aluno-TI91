using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuário_Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string UsuarioSistema = "alunoti91";
            string SenhaSistema = "123";
            
            string UsuarioInserido;            
            string SenhaInserida;

            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite o nome de usuário: ");
                UsuarioInserido = Console.ReadLine();
                Console.Write("Digite a Senha: ");
                SenhaInserida = Console.ReadLine();

                tentativas++;

            } while (UsuarioInserido != UsuarioSistema && SenhaInserida != SenhaSistema && tentativas < 3);

            if (UsuarioInserido == UsuarioSistema && SenhaInserida == SenhaSistema)
            {
                Console.Clear();
                Console.WriteLine("Seja bem vindo ao sistema Sr. Aluno TI91");
            }
            else
            {   Console.Clear();
                Console.WriteLine($"Usuário ou Senha incorretos, você usou {tentativas} /3 tentivas");
            }

            Console.ReadKey();

        }
    }
}
