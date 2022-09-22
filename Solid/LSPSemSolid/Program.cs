using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPSemSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            c.Saldo = 100;
            c.Sacar(250);
            Console.WriteLine("A conta tem o saldo de R$ "
                                               + c.Saldo);
            //A conta tem o saldo de R$ -150
            ContaPoupanca p = new ContaPoupanca();
            p.Saldo = 100;
            p.Sacar(250);
            Console.WriteLine("A conta tem o saldo de R$ "
                                               + p.Saldo);
            //A conta tem o saldo de R& 100
            Conta a = new ContaPoupanca();
            a.Saldo = 100;
            a.Sacar(250);
            Console.WriteLine("A conta tem o saldo de R$ " + a.Saldo);
            //A conta tem o saldo de R& 100
            Console.ReadKey();

        }
    }
}
