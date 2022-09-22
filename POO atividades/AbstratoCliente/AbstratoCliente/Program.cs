using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
 
            ClienteFisico cf = new ClienteFisico(1, "Gabriel", 35, 1111);
            cf.Mostrar();

            Teste tf = new Teste();
            Console.WriteLine(tf.AnalisarIdadeClientes(cf));

            Console.WriteLine();

            ClienteJuridico cj = new ClienteJuridico(2, "Fatec", 53, "10.872.410/0001-..");
            cj.Mostrar();

            Teste tj = new Teste();
            Console.WriteLine(tj.AnalisarIdadeClientes(cj));


            Console.ReadKey();
        }
    }
}
