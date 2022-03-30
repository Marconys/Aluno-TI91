using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Argumento_Out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoc, rest;

            divid = 10;
            divis = 5;
            quoc = divide(divid, divis, out rest);

            Console.WriteLine("{0} / {1}: quociente = {2} e resto = {3}",divid, divis, quoc, rest);

            Console.ReadKey();
        }

        static int divide(int dividendo, int divisor, out int resto)
        {
            int quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }
    }
}
