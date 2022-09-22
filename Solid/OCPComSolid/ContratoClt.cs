using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPComSolid
{
    class ContratoClt : Funcionario,
        IRemuneravel
    {
        public double Remuneravel()
        {
            return 2000;
        }
    }
}
