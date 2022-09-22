using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSemSolid
{
    class ContaPoupanca : Conta
    {
        public override void Sacar
            (double valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
        }
    }
}
