using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            Console.WriteLine("Escreva um texto :");
            frase = Convert.ToString(Console.ReadLine());
            char a;
            for (int i = frase.Length - 1; i >= 0; i--)
            {
                a = frase[i];
                Console.Write(a);
            }
            Console.WriteLine();
            
        }
    }
}
