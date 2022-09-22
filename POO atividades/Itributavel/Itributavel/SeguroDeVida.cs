using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    class SeguroDeVida : Itributavel
    {
        public double CalculaTributos()
        {
            return 75.00;
        }
    }
}
