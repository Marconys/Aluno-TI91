using System;



namespace Estruturas_cond_simples
{
    
        public class SystemException : Exception
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o primeiro valor: ");
            string valor1 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insira o segundo valor: ");
            string valor2 = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Insira um operador (+ - * /): ");
            string operador = Console.ReadLine();
            Console.WriteLine();

            try { 

            decimal resultado = 0;

            if (operador == "+")

                resultado = Convert.ToInt16(valor1) + Convert.ToInt16(valor2);

            if (operador == "-")

                resultado = Convert.ToInt16(valor1) - Convert.ToInt16(valor2);

            if (operador == "*")

                resultado = Convert.ToInt16(valor1) * Convert.ToInt16(valor2);

            if (operador == "/")

                /* sempre que encontrar um erro de exceção no código, devo inserir uma classe para o 
                 * namespace de exceções do sistema Ex: "public class SystemException : Exception" 
                 * e criar um bloco "Try" sobre o bloco que apresenta o erro, em seguida e por ultimo, antes da impressão 
                 * criar um bloco "catch()" nesse caso "catch(DivideByZeroException); */

                
                
                    resultado = Convert.ToInt16(valor1) / Convert.ToInt16(valor2);

                    Console.WriteLine("Resultado é: " + resultado);
                } 
                 
                catch(DivideByZeroException)
                {
                    Console.WriteLine("Valor não definido:");
                }
            




            Console.ReadKey();
        }
    }
}
