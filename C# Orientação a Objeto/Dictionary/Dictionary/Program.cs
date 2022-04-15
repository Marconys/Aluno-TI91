using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            // Método para adicionar elemto no Dictionary
            veiculos.Add(1, "Carro");
            veiculos.Add(10, "Navio");
            veiculos.Add(20, "Avião");
            veiculos.Add(30, "Moto");
            veiculos.Add(50, "Patinete");



            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);



            // Verifcar chave na coleção usando o método ContainsKey
            int Chave = 20;

            if (veiculos.ContainsKey(Chave))
            {
                Console.WriteLine("A chave {0} esta na coleção",Chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não esta na coleção", Chave);
            }



            // Verifcar valor na coleção usando o método ContainsValue
            string valor = "Motocicleta";

            // Usando indexador para substituir valores

            veiculos[50] = "Motocicleta";

            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor {0} esta na coleção", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não esta na coleção", valor);
            }
            // Maneira simples de Imprimeir todos os elementos do Dictionary

            foreach (KeyValuePair<int, string> v in veiculos)
            {
                Console.Write(v.Value + ":");
                Console.WriteLine(" " + v.Key);
            }

            Console.WriteLine();


            // Maneira complexa de Imprimeir todos os elementos do Dictionary

            Dictionary<int, string>.ValueCollection valores = veiculos.Values;

            foreach (string v in valores)
            {
                Console.WriteLine(v);
            }

            Console.ReadKey();

        }
    }
}
