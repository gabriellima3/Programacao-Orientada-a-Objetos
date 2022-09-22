using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNotas = new List<int>();

            listaNotas.Add(10);
            listaNotas.Add(8);

            for(Int32 i = 0; i < listaNotas.Count; ++i)
            {
                Console.WriteLine(listaNotas[i]);
            }
            Console.ReadKey();
        }
    }
}
