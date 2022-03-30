using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;





namespace Testando1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (Nota1 * 2 + Nota2 * 3 + Nota3 * 5) / 10;

            Console.WriteLine($"MEDIA = {Media.ToString("F1", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
