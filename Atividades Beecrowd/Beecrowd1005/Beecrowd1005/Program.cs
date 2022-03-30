using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double Media = (Nota1 * 3.5 + Nota2 * 7.5) / 11;

            Console.WriteLine($"MEDIA = {Media.ToString("F5", CultureInfo.InvariantCulture)}");

            Console.ReadKey();

        }
    }
}
