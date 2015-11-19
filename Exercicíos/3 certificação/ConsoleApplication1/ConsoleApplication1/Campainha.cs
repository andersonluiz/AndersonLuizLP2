using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Campainha
    {
        public abstract void Musica();
        public void Soar()
        {
            Musica();
        }
    }
}
