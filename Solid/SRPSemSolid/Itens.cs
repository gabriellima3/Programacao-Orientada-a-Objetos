using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSemSolid
{
    class Itens
    {
        private string descricao;
        private double valor;
        public void MostraItens()
        {
            Console.WriteLine("Descrição: "
                + Descricao + "\tValor: " + Valor);
        }
        public Itens(string descricao,
                     double valor)
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
    }
}
