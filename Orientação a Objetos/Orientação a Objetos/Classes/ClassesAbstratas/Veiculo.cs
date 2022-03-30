using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_Objetos.Classes.ClassesAbstratas
{
    public class Veiculo
    {
        //Propriendades / Atributos ** "Private signica que o valor só poderá ser alterado dentro da classe no momento da criação do objeto / emcapsulamento 
        public string Marca { get; private set; }

        public string Modelo { get; private set; }

        public string Cor { get; set; }

        // usar o Protected quando quiser que a priedade fique privada porém seja acessivél na classe filha
        protected DateTime DataDaProximaManutencao { get; set; }

        // Método construtor
        public Veiculo(string marca, string modelo, string cor)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Cor = cor;
        }
    }
}
