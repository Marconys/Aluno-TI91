using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Beecrowd_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, raio;

            raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = (3.14159 * raio * raio);

            Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
