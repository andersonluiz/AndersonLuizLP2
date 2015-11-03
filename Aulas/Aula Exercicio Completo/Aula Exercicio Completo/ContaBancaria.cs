using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Exercicio_Completo
{
    class ContaBancaria
    {
        public string cliente { get; set; }
        public string num_conta { get; set; }
        public double saldo { get; set; }

        public virtual void Sacar(double n)
        {
        }

        public void Depositar(double n )
        {
            saldo += n;
        }
        public virtual void Transferencia(double valor, ContaBancaria c)
        {

        }
        
        
    }
}
