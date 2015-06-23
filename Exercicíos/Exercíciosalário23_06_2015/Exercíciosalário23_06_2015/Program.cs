using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salário23_06_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            int funcionarios;
            Console.WriteLine("Digite o número de funcionarios");
            funcionarios = int.Parse(Console.ReadLine());

            string[] nomesfuncionarios = new string[funcionarios];

            int[] cpfs = new int[funcionarios];

            string[] datanascimentos = new string[funcionarios];
            double salario;
            double[] salarios = new double[funcionarios];
            int dataadmissão;
            int[] datasadmissão = new int[funcionarios];
            double novosalario;
            double[] novossalarios = new double[funcionarios];
            for (int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine("Digite o nome do funcionário");
                nomesfuncionarios[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o cpf do funcionário");
                cpfs[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o datanasc do funcionário");
                datanascimentos[i] = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Digite o salário do funcionário:");
                salarios[i] = double.Parse(Console.ReadLine());
                salario = salarios[i];
                Console.WriteLine("Digite sua data de admissão:");
                dataadmissão = int.Parse(Console.ReadLine());
                datasadmissão[i] = dataadmissão;
                if (dataadmissão >= 2014)
                {
                    novosalario = salario + 423.45;
                    novossalarios[i] = novosalario;
                }
                else if (dataadmissão >= 2010 && dataadmissão <= 2013)
                {
                    novosalario = salario + salario * 9.84 / 100;
                    novossalarios[i] = novosalario;
                }
                else if (dataadmissão >= 2000 && dataadmissão <= 2010)
                {
                    novosalario = salario + salario * 16.4 / 100;
                    novossalarios[i] = novosalario;
                }
                else if (dataadmissão <= 1999)
                {
                    novosalario = salario + salario * 22.6 / 100;
                    novossalarios[i] = novosalario;
                }
                else
                {

                }


            }
            for (int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine("CPF: {0}", cpfs[i]);
                Console.WriteLine("NOME: {0}", nomesfuncionarios[i]);
                Console.WriteLine("NASC: {0}", datanascimentos[i]);
                Console.WriteLine("ADMISSÃO: {0}", datasadmissão[i]);
                Console.WriteLine("SALÁRIO ATUAL: {0}", salarios[i]);
                Console.WriteLine("NOVOSALÁRIO: {0}", novossalarios[i]);
            }
        }
    }
}
