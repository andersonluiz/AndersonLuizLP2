using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Exercicio_Completo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 1 para Conta Poupança e 2 para Conta especial");
            int x = int.Parse(Console.ReadLine());
            
            if(x == 1)
            {
                ContaPoupanca cliente1 = new ContaPoupanca();
                cliente1.cliente = Console.ReadLine();
                cliente1.num_conta = Console.ReadLine();
                cliente1.saldo = int.Parse(Console.ReadLine());
                cliente1.Sacar(Double.Parse(Console.ReadLine()));
                cliente1.Depositar(Double.Parse(Console.ReadLine()));
                Console.WriteLine(cliente1.cliente);
                Console.WriteLine(cliente1.num_conta);
                Console.WriteLine(cliente1.saldo);

                ContaEspecial cliente2 = new ContaEspecial();

                cliente2.cliente = Console.ReadLine();
                cliente2.num_conta = Console.ReadLine();
                cliente2.saldo = int.Parse(Console.ReadLine());
                cliente2.Sacar(Double.Parse(Console.ReadLine()));
                cliente2.Depositar(Double.Parse(Console.ReadLine()));
                Console.WriteLine(cliente2.cliente);
                Console.WriteLine(cliente2.num_conta);
                Console.WriteLine(cliente2.saldo);
                
            }
            if(x == 2)
            {
                ContaEspecial cliente1 = new ContaEspecial();
                
                cliente1.cliente = Console.ReadLine();
                cliente1.num_conta = Console.ReadLine();
                cliente1.limite = Double.Parse(Console.ReadLine());
                cliente1.saldo = int.Parse(Console.ReadLine());
                cliente1.Sacar(Double.Parse(Console.ReadLine()));
                cliente1.Depositar(Double.Parse(Console.ReadLine()));
                Console.WriteLine(cliente1.cliente);
                Console.WriteLine(cliente1.num_conta);
                Console.WriteLine(cliente1.saldo);
                Console.WriteLine(cliente1.limite);
                
               
                ContaEspecial cliente2 = new ContaEspecial();

                cliente2.cliente = Console.ReadLine();
                cliente2.num_conta = Console.ReadLine();
                cliente2.limite = Double.Parse(Console.ReadLine());
                cliente2.saldo = int.Parse(Console.ReadLine());
                cliente2.Sacar(Double.Parse(Console.ReadLine()));
                cliente2.Depositar(Double.Parse(Console.ReadLine()));

                cliente1.Transferencia(double.Parse(Console.ReadLine()), cliente2);
                
                Console.WriteLine(cliente2.cliente);
                Console.WriteLine(cliente2.num_conta);
                Console.WriteLine(cliente2.saldo);
                Console.WriteLine(cliente2.limite);

            }
        }
    }
}
