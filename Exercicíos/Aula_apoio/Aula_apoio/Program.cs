using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_apoio
{
    class Program
    {
        static void Main2(string[] args)
        {
            /*Leia um número N , Q e R , inteiros.
             * Imprima todos os multiplos de N no intervalo [P;Q],ou seja , entre P e Q inclusive.
             */
            int n;
            int q;
            int p;
            
            Console.WriteLine("Digite um numero N :");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o P do intervalo [P;Q] ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número Q do intervalo [P;Q]");
            q = int.Parse(Console.ReadLine());
            if(q > p)
            for (int i  = p; i  <= q; i ++)
            {
                if(i % n == 0)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = p; i <= q; i--)
                {
                    if (i % n == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
