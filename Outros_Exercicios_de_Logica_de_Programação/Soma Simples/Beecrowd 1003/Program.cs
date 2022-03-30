using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beecrowd_1003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma;

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            soma = a + b;

            Console.WriteLine($"SOMA = {soma}");

            Console.ReadKey();
        }
    }
}
