using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Funcionario_23062015
{
    class Funcionario
    {
        public string Nome;
        public string Cpf;
        public DateTime DataNascimento;
        public DateTime DataAdmissao;
        public double salario;

        public double Aumento()
        {
            double aumento = 0;
            if (DataAdmissao.Year <= 2014)
            {
                aumento += 423.45;
            }

            else if (DataAdmissao.Year >= 2010 && DataAdmissao.Year < 2013)
            {
                aumento = (salario * 9.84) / 100;
            }

            else if (DataAdmissao.Year >= 2000 && DataAdmissao.Year < 2009)
            {
                aumento = (salario * 16.4) / 100;
            }

            else if (DataAdmissao.Year <= 1999)
            {
                aumento = (salario * 22.6) / 100;
            }

            return aumento;
        }

    }
}