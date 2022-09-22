using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(1, "Gabriel", 1800);
            f.Mostrar();
            Console.WriteLine();

            Horista h = new Horista(2, "Lucas", 2000, 44);
            h.Mostrar();
            Console.WriteLine();

            Mensalista m = new Mensalista(3, "Lima", 3500, 220);
            m.Mostrar();
            Console.ReadKey();
        }
    }
}
