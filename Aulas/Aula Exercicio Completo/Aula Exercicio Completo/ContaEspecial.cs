using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Exercicio_Completo
{
    class ContaEspecial : ContaBancaria
    {
        public double limite { get; set; }

        public override void Sacar(double n)
        {
            if(n < limite)
            {
                saldo = saldo - n;
            }
        }
        public override  void Transferencia(double valor, ContaBancaria c)
        {
            if (saldo + limite > valor)
            {
                saldo -= valor;
                c.saldo += valor;
            }


        }
    }
}
