using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa P = new Pessoa();
            string Q;

            Console.Write("Digite 1 para inserir, 2 para consultar e 3 para sair: ");
            int evaluate = int.Parse(Console.ReadLine());

            while (evaluate != 3)
            {

                if (evaluate == 2)
                {
                    Q = "Select * From pessoa";
                    P.Consultar(Q);
                }

                else if (evaluate == 1)
                {
                    Console.Write("Nome: ");
                    P.Nome = Console.ReadLine();

                    Console.Write("Idade: ");
                    P.Sobrenome = Console.ReadLine();

                    Console.Write("Peso: ");
                    P.Peso = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Altura: ");
                    P.Altura = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Telefone: ");
                    P.Telefone = Console.ReadLine();


                    Q = String.Format("INSERT INTO pessoa (nome, sobrenome, peso, altura, telefone) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", P.Nome, P.Sobrenome, P.Peso, P.Altura, P.Telefone);
                    P.Inserir(Q);
                }

                else
                {
                    Console.WriteLine("Opção Inválida.");
                }

                Console.Write("Digite 1 para inserir, 2 para consultar e 3 para sair: ");
                evaluate = int.Parse(Console.ReadLine());

            }

            Console.ReadKey();

        }
    }
}