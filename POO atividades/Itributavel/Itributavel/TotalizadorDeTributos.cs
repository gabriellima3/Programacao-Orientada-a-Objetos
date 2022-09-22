using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }
        public void Adiciona(Itributavel t)
        {
            this.Total += t.CalculaTributos();
        }
    }
}
