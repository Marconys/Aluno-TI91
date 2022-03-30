using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_de_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            int[] vetor3 = new int[5];
            int[,] matriz = new int[2,5];
            int[,] matriz1 = new int[2,5] { { 11,22,00,44,55},{ 66,77,88,99,00 } };

            // preenchendo o vetor1

            Random random = new Random();
            for (int i = 0; i < vetor1.Length; i++)
            {
                vetor1[i] = random.Next(50);
            }
                Console.WriteLine("Elementos do vetor1");
            foreach (int item in vetor1)
            {
                Console.WriteLine(item);  
            
            }

            // public static int BinarySearch (array,valor); caso o valor procurado não esteja no array, vc terá retorno menor que zero "0"
            Console.WriteLine("BinarySearch");
            int procurado = 33;
            int pos = Array.BinarySearch(vetor1, procurado);
            Console.WriteLine("O valor {0} está na posição {1}",procurado,pos);
            Console.WriteLine("----------------------------------------------------");

            // public static void Copy(Ar_origem,Ar_destino,qtde_elementos);
            Console.WriteLine("Copy");
            Array.Copy(vetor1, vetor2, vetor1.Length);

            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            // public static void CopyTo(Ar_destino,a_partir_desta_pos);
            Console.WriteLine("CopyTo");
            vetor1.CopyTo(vetor3, 0);

            foreach (int n in vetor3)
            {
                Console.WriteLine(n);

            }
            Console.WriteLine("----------------------------------------------");

            //Public int GetLongLength(dimensão); retornar a quantidade de elementos do vetor
            Console.WriteLine("GetLongLength");
            long qtdeElementosVetor = vetor1.GetLongLength(0);
            Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
            Console.WriteLine("----------------------------------------------");


            //Public int GetLowerBound(dimensão);
            Console.WriteLine("GetLowerBound");
            int menorIndiceVetor = vetor1.GetLowerBound(0);
            int menorIndiceMatriz_D1 = matriz1.GetUpperBound(1);
            Console.WriteLine("O menor indice do vetor1 {0} ",menorIndiceVetor);
            Console.WriteLine("O menor indice da matriz1 {0} ",menorIndiceMatriz_D1);
            Console.WriteLine("----------------------------------------------");

            //Public int GetUpperBound(dimensão);

            Console.WriteLine("GetUpperBound");
            int maiorIndiceVetor = vetor1.GetUpperBound(0);
            int maiorIndiceMatriz_D1 = matriz1.GetUpperBound(1);
            Console.WriteLine("O menor indice do vetor1 {0} ", maiorIndiceVetor);
            Console.WriteLine("O menor indice da matriz1 {0} ", maiorIndiceMatriz_D1);
            Console.WriteLine("----------------------------------------------");

            // public object GetValue(long índice); vai me retornar um valor apartir de um índice
            Console.WriteLine("GetValue");
            int valor0 = Convert.ToInt32(vetor1.GetValue(3));
            int valor1 = Convert.ToInt32(matriz1.GetValue(1,3));
            Console.WriteLine("Valor da posição 3 do vetor1 {0}", valor0);
            Console.WriteLine("Valor da posição 3 do vetor1 {0}", valor1);
            Console.WriteLine("----------------------------------------------");

            // public static int IndexOf(Array,valor); ele vai me retornar o indice do valor que eu indicar no segundo parametro
            Console.WriteLine("IndexOf");
            int indice1 = Array.IndexOf(vetor1, 3);
            Console.WriteLine("ìndice do primeiro valor 3:{0}", indice1);
            Console.WriteLine("----------------------------------------------");

            // public static int LastIndexOf(Array,valor); ele vai me retornar o indice do valor que eu indicar no segundo parametro
            Console.WriteLine("LastIndexOf");
            int indice2 = Array.LastIndexOf(vetor1,3);
            Console.WriteLine("ìndice do último valor 33:{0}", indice2);
            Console.WriteLine("----------------------------------------------");

            // public static void Reverse(Array); ele inverte a ordem dos elementos do vetor
            Array.Reverse(vetor1);
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");
            // Public void SetValue(object valor, long pos); ele permite setar, definir um valor em uma posição do nosso vetor
            vetor2.SetValue(99, 0); // adicionando o valor 99 na posição "0"
            for (int i = 0; i < vetor2.Length; i++)
            {
                vetor2.SetValue(0,i); // setando zero "0" para todas as posições do vetor
            }
            Console.WriteLine("Vetor 2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------");

            // public static oid Sort(Array); ordenar em ordem crescente todos od elementos do nosso vetor / caso queira em ordem decrescente
            //você deve usar o reverse após o Sort
            Array.Sort(vetor1);
            Array.Sort(vetor2);
            Array.Sort(vetor3);
            Console.WriteLine("vetor1");
            foreach (int n in vetor1)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\nvetor2");
            foreach (int n in vetor2)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("\nvetor3");
            foreach (int n in vetor3)
            {
                Console.WriteLine(n);
            }
            Console.ReadKey();
        }
    }
}
