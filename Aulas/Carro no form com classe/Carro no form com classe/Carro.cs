using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro_no_form_com_classe
{
    public class Carro
        
    {
        public string placa;
        public string modelo;
        public double consumoKmL;
        public double qtdCombustivelL;

        public double AutonomiaKm() 
        {
            double autonomia = consumoKmL * qtdCombustivelL;
            return autonomia;

        }
    }
}
