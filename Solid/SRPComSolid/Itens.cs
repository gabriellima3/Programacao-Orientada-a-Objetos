using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPComSolid
{
    class Itens
    {
        private string descricao;
        private double valor;

        public Itens(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public void MostraItens()
        {
            Console.WriteLine("Descrição: " + Descricao
                + "\tValor: " + Valor);
        }
        public bool ItemValido()
        {
            if (Descricao == "")
                return false;
            if (Valor == 0)
                return false;
            return true;
        }
    }
}
