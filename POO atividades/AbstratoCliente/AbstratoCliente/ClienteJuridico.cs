using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    class ClienteJuridico : Cliente
    {
        private string cnpj;
        public string Cnpj
        {
            set { this.cnpj = value; }
            get { return this.cnpj; }
        }

        public ClienteJuridico(int codigo, string nome, int idade, string cnpj) : base(codigo, nome,idade)
        {
            Cnpj = cnpj;
        }

        public override bool VerificaIdade()
        {
            if (Idade >= 1)
                return true;
            return false;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("CNPJ: " + Cnpj);
        }
    }
}
