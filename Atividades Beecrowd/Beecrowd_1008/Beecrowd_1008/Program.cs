using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NumeroFuncionario = Convert.ToInt32(Console.ReadLine());
            int QtdDeHoras = Convert.ToInt32(Console.ReadLine());
            double ValorDaHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Salario = (ValorDaHora * QtdDeHoras);

            Console.WriteLine($"NUMBER = {NumeroFuncionario}\nSALARY = U$ {Salario.ToString("F2", CultureInfo.InvariantCulture)}");

           Console.ReadKey();

        }
    }
}
