using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceITributavel
{
    class Program
    {
        static void Main(string[] args)
        {
            TotalizadorDeTributos tdt = new TotalizadorDeTributos();
            ContaCorrente cc = new ContaCorrente();
            cc.Saldo = 5000;
            Itributavel it = cc;
            tdt.Adiciona(it);
            Console.WriteLine(it.CalculaTributos());

            SeguroDeVida sv = new SeguroDeVida();
            it = sv;
            Console.WriteLine(it.CalculaTributos());
            tdt.Adiciona(it);            
            Console.WriteLine(tdt.Total);
            Console.ReadKey();

        }
    }
}
