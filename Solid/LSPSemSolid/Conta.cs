using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSemSolid
{
    class Conta
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public virtual void Sacar
            (double valor)
        {
            Saldo -= valor;
        }
    }
}
