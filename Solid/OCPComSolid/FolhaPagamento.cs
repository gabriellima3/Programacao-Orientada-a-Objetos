using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPComSolid
{
    class FolhaPagamento
    {
        private double saldoFolha;

        public double SaldoFolha
        {
            get { return saldoFolha; }
            set { saldoFolha = value; }
        }
        public double CalcularFolha
            (IRemuneravel f)
        {
            SaldoFolha = f.Remuneravel();
            return saldoFolha;
        }
    }
}
