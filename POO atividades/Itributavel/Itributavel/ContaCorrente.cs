using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    class ContaCorrente : Itributavel
    {
        public double Saldo{ get; set; }

        public double CalculaTributos()
        {
            return Saldo * 0.05;
        }
    }
}
