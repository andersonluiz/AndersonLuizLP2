﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12___Completo
{
    class Gerente
    {
        public string CPF;
        public string Matricula;
        public string Nome;
        public DateTime DataDeNascimento;
        public double Salario { get; set; }
        public string AreaGenciada { get; set; }
        public double Adicional { get; set; }
        public double SalarioTotal()
        {
            return Salario + Adicional;
        }

        public double ValeAlimentacao()
        {
            double vale = SalarioTotal() * 0.065;

            if (vale > 750)
            {
                return 750;
            }

            else
            {
                return vale;
            }
        }
    }
}
