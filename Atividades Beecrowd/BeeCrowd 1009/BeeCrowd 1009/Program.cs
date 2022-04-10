using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace BeeCrowd_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NomeVendedor = Console.ReadLine();
            double Salario = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double TotalVendas = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);

            double SalarioTotal = (TotalVendas * 0.15) + Salario;

            Console.WriteLine("TOTAL = R$ {0}", SalarioTotal.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
