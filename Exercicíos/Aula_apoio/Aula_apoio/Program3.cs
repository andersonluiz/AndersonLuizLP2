using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_apoio
{
    class Program3
    {
        static void Main(string[] args)
        {
            /*Faça  um programaque leia um numero N e N números inteiros . Determine se esses números formam uma sequencia par , ímpar ou neutra
             * Sequencia par : A soma das posições pares ( P ) é maior que a das posições ímpares (I) : P > I
             * Sequencia ímpar : A soma das posições pares ( P ) é menor que a das posições ímpares (I) : I> P
             * Sequencia neutra : A soma das posições pares ( P ) é igual a das posições ímpares (I) : I = p
             */
            int n;
            int somapar = 0;
            int somaimpar = 0;
            
            Console.WriteLine("Digite a quantidade de números N");
            n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            for(int i = 0; i < n; i ++)
            {
                Console.WriteLine("Digite um número inteiro");
                int q = int.Parse(Console.ReadLine());
                numeros[i] = q;
            }
            for (int i = 0; i < n; i++)
            {
                
                if(i % 2 == 0)
                {

                    somapar += numeros[i];
                }
                else
                {
                    somaimpar += numeros[i];
                }
            }
            if(somaimpar > somapar)
            {
                Console.WriteLine("Sequencia ímpar");
            }
            else if ( somapar > somaimpar)
            {
                Console.WriteLine("Sequencia par");
            }
            else
            {
                Console.WriteLine("Sequencia neutra");
            }
        }
    }
}
