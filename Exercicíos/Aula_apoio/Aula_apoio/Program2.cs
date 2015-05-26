using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_apoio
{
    class Program2
    {
        static void Main3(string[] args)
        {
            /*Faça um programa que leia um número , N , inteiro. 
             * Em seguida leia N vezes os 3 lados de um triangulo e decida , para cada um ,
             * se ele é , Escaleno , Isósceles ou Equilatero.
             * Caso seja Escaleno , determine se é retangulo.
             * 
             */
            int n;
            int lado1 = 0;
            int lado2 = 0;
            int lado3 = 0;
            Console.WriteLine("Digite um número N");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digíte o tamanho do lado 1 ");
                lado1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digíte o tamanho do lado 2 ");
                lado2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digíte o tamanho do lado 3 ");
                lado3 = int.Parse(Console.ReadLine());
                int a = lado1 * lado1;
                int b = lado2 * lado2;
                int c = lado3 * lado3;
                if (lado1 == lado2 && lado2 == lado3)
                {

                    Console.WriteLine("Seu tríangulo é um tríangulo equilátero");


                }
                else if (lado1 == lado2 && lado2 != lado3)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo isósceles");
                }
                else if (lado2 == lado3 && lado3 != lado1)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo isósceles");
                }
                else if (lado3 == lado1 && lado1 != lado3)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo isósceles");
                }
                else if (lado1 != lado2 && lado2 != lado3)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo escaleno");
                    if(a == b + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if(b == a + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if(c == b + a)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else 
                    {
                        Console.WriteLine("Seu tríangulo escaleno não é retangulo");
                    }
                    
                }
                else if (lado2 != lado3 && lado3 != lado1)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo escaleno");
                    if (a == b + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if (b == a + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if (c == b + a)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else
                    {
                        Console.WriteLine("Seu tríangulo escaleno não é retangulo");
                    }
                }
                else if (lado3 != lado1 && lado1 != lado3)
                {
                    Console.WriteLine("Seu tríangulo é um tríangulo escaleno");
                    if (a == b + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if (b == a + c)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else if (c == b + a)
                    {
                        Console.WriteLine("Seu tríangulo escaleno é retangulo");
                    }
                    else
                    {
                        Console.WriteLine("Seu tríangulo escaleno não é retangulo");
                    }
                    
                }
                else
                {

                }
                
            }
        }
    }
}
