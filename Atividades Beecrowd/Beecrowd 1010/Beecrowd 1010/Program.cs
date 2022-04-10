using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;



namespace Beecrowd_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
         string[] Compra = Console.ReadLine().Split(' ');
            int CodProd = Int32.Parse(Compra[0]);
            int QtdProd = Int32.Parse(Compra[1]);
            double ValorProd = double.Parse(Compra[2], CultureInfo.InvariantCulture);

            string[] Compra1 = Console.ReadLine().Split(' ');
            int CodProd1 = Int32.Parse(Compra1[0]);
            int QtdProd1 = Int32.Parse(Compra1[1]);
            double ValorProd1 = double.Parse(Compra1[2], CultureInfo.InvariantCulture);

            double Total = (QtdProd * ValorProd) + (QtdProd1 * ValorProd1);

            Console.WriteLine("VALOR A PAGAR: R$ {0}",Total.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadKey();
        }
    }
}
