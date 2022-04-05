using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_De_Apostas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Sair;

            do
            {
                Console.Write("Digite a Quandidades de Cartões: ");
            int QtdCartoes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a Quandidades de Numeros: ");
            int QtdNumeros = Convert.ToInt32(Console.ReadLine());



            int Numeros = QtdNumeros;
            int Cartoes = QtdCartoes;


            int[,] matriz = new int[Cartoes, Numeros];

                //Player escolhe seus numeros apostados

           /* int apostados = (QtdCartoes * QtdNumeros);
             int QtdApostados = 1;
             Console.Clear();
             for ( Cartoes = 0;  Cartoes < QtdCartoes;  Cartoes++)
             {
                 for ( Numeros = 0; Numeros < QtdNumeros; Numeros++)
                 {
                     Console.WriteLine("Digite o {0}º/{1} numeros apostados ",QtdApostados, apostados);
                     matriz[Cartoes,Numeros] = Convert.ToInt32(Console.ReadLine());
                     QtdApostados++;
                     Console.Clear();
                 }
             }
             Console.WriteLine($"---------------------------------------------\nNumeros Apostados\n---------------------------------------------");
             for (Cartoes = 0; Cartoes < QtdCartoes; Cartoes++)
             {
                 for (Numeros = 0; Numeros < QtdNumeros; Numeros++)
                 {
                     Console.Write(matriz[Cartoes, Numeros] + " ");
                 }
                 Console.WriteLine();
             } */




            

                // Preenchimento da Matriz
                Random rand = new Random();

                for (Cartoes = 0; Cartoes < QtdCartoes; Cartoes++)
                {
                    for (Numeros = 0; Numeros < QtdNumeros; Numeros++)
                    {
                        matriz[Cartoes, Numeros] = rand.Next(1, 60);


                    }
                }

                // Ordenação         

                for (int l = 0; l < Cartoes; l++)
                {// percorrer pelas linhas da matriz
                    for (int r = 0; r < (Numeros - 1); r++)
                    {
                        for (int c = r + 1; c < Numeros; c++)
                        {
                            int t;
                            if (matriz[l, r] >= matriz[l, c])
                            {
                                t = matriz[l, r];
                                matriz[l, r] = matriz[l, c];
                                matriz[l, c] = t;
                            }
                        }
                    }
                }

                Console.WriteLine($"---------------------------------------------\nNUMEROS SORTEADOS\n---------------------------------------------");
                //Exibir Matriz Preenchida / Numéros sorteados
                for (Cartoes = 0; Cartoes < QtdCartoes; Cartoes++)
                {
                    for (Numeros = 0; Numeros < QtdNumeros; Numeros++)
                    {
                        Console.Write(matriz[Cartoes, Numeros] + " ");


                    }
                    Console.WriteLine();
                }



                Console.WriteLine();
                Console.Write("Deseja fazer uma nova aposta? (s/n): ");
                Sair = Console.ReadLine();
                Console.Clear();

            } while (Sair == "s" || Sair == "S");

            Console.WriteLine("Jogo Finalizado");

            Console.ReadKey();
        }
    }
}
