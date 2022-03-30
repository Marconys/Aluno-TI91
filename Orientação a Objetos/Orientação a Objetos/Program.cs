using Orientação_a_Objetos.Classes;
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
            Carro carro = new Carro("Ford", "Ka", 100) 
            {
               /* Marca = "VW",
                Cor = "Azul",
                Modelo = "1969",
                preco = 100,*/
        };

            Console.WriteLine("Insira o preço do aluguel");
            var preco = Convert.ToDouble( Console.ReadLine());
            carro.MudarPrecoAluguel(preco);

            Console.WriteLine($"Meu primeiro carro da frota é: {carro.Marca} modelo {carro.Modelo} Valor de aluguel {carro.preco}");

            /*fusca.Alugar();
           // string Alugado = fusca.EstadoAlugado == true ? "Sim" : "Não";
            Console.WriteLine($"Meu primeiro carro da frota esta alugado {fusca.EstadoAluguel()}"); */
            Console.ReadKey();
        }
        
    }
}
