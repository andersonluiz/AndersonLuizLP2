using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciosalarioscomclasses23_06_2015
{
    class Funcionario
    {
        public string nome;
        public DateTime dataNascimento;
        public int dataAdmissão;
        public string cpf;
        public double salario;
        public double novosalario;
        public double aumento;

        public double AumentoDeSalario()
        {
            if (dataAdmissão >= 2014)
            {
                aumento = 423.45;
            }
            else if (dataAdmissão >= 2010 && dataAdmissão <= 2013)
            {
                aumento = salario * 9.84 / 100;
            }
            else if (dataAdmissão >= 2000 && dataAdmissão <= 2010)
            {
                aumento = salario * 16.4 / 100;
            }
            else 
            {
                aumento = salario * 22.6 / 100;
            }
            return aumento;
        }
    }
}
