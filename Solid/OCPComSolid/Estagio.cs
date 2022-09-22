using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPComSolid
{
    class Estagio : Funcionario,
        IRemuneravel
    {
        public double Remuneravel()
        {
            return 800;
        }
    }
}
