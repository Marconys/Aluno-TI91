using Orientação_a_Objetos.Classes.ClassesAbstratas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_Objetos.Classes
{ // 
    internal class Carro : Veiculo
    {
       

        public bool EstadoAlugado { get; set; }

        public double preco { get; private set; }

        public Carro(string Marca, string Modelo, string Cor, double preco) : base (Marca, Modelo, Cor)
        {
            
            this.preco= preco;
        }

        
        public void Alugar()
        {
            EstadoAlugado = true;
            Console.WriteLine($"O carro {Marca}, esta alugado!");
        }

        public string EstadoAluguel()
        {
            return EstadoAlugado == true ? "Sim" : "Não"; ;
        }

        public void RetornarCarro()
        {
                EstadoAlugado = false;
            Console.WriteLine($"O carro {Marca}, foi devolvido ");
        }

        public void MudarPrecoAluguel(double NovoPreco)
        {
            // Precisa aprovar alteração de preço
            this.preco = NovoPreco;
        }
        public void ProximaManutenção()
        {
            //if sou admin
            Console.WriteLine($"O carro tem manutenção para {DataDaProximaManutencao}");
        }
    }
}
