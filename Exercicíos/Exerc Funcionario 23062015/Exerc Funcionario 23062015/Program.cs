﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Funcionario_23062015
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Funcionario func = new Funcionario();

            for (int i = 0; i <= num; i++)
            {

                func.Nome = Convert.ToString(Console.ReadLine());
                func.Cpf = Console.ReadLine();
                func.DataNascimento = DateTime.Parse(Console.ReadLine());
                func.salario = double.Parse(Console.ReadLine());
                func.DataAdmissao = DateTime.Parse(Console.ReadLine());

                double NovoSal = func.salario + func.Aumento();
                Console.WriteLine("Nome: " + func.Nome);
                Console.WriteLine("CPF: " + func.Cpf);
                Console.WriteLine("Data de Nascimento: " + func.DataNascimento);
                Console.WriteLine("Data de Admissão: " + func.DataAdmissao);
                Console.WriteLine("Salário: " + func.salario);
                Console.WriteLine("Novo Salário: " + NovoSal);
            }
        }
    }
}
