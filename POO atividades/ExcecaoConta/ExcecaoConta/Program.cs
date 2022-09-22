using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecaoConta
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta(2000);
            c.Depositar(250);
            c.MostrarAtributos();

            Conta c1 = new Conta(2000);
            c1.Depositar(-250);
            c1.MostrarAtributos();
            Console.ReadKey();


        }
        
    }
}
