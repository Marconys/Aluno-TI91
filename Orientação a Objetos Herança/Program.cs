using Orientação_a_Objetos.Classes;
using Orientação_a_Objetos.Classes.ClassesAbstratas;
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
            Veiculo veiculo = new Veiculo("Ford", "Ka", "Verde");

            Carro carro = new Carro("Ford", "Ka","Verde", 100);            

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
