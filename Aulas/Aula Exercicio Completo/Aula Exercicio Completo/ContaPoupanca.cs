using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Exercicio_Completo
{
    class ContaPoupanca : ContaBancaria
    {
        public  DateTime diaderendimento { get; set; }

        public void calcularNovoSaldo(double rendimento)
        {
            saldo = saldo + (saldo * rendimento / 100);
        }
        public override void Sacar(double n )
        {
            
            if(n < saldo)
            {
                saldo = saldo - n;
            }
            else
            {

            }
        }
        public override void Transferencia(double valor, ContaBancaria c)
        {
            if (saldo > valor)
            {
                saldo -= valor;
                c.saldo += valor;
            }


        }
    }
}
