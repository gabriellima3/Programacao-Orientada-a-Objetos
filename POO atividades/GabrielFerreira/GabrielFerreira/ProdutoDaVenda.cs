using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class ProdutoDaVenda
    {
        private int quantidade;
        private double valorUnitario;
        private Produto produtoDaVenda;

        public ProdutoDaVenda(double subTotal, double valorUnitario, int quantidade, Produto produtoDaVenda)
        {
            ValorUnitario = valorUnitario;
            Quantidade = quantidade;
            ProdutoDasVenda = produtoDaVenda;
        }

        public ProdutoDaVenda(Produto produto, int quantidade, double preco)
        {
            this.quantidade = quantidade;
        }

        public double TotalVenda()
        {
            return Quantidade * ValorUnitario;
      
        }
        public void Mostrar()
        {
       
            Console.WriteLine("Quantidade: " + Quantidade + "\nValorUnitario: " + ValorUnitario + "\nSubTotal: " + TotalVenda());
        }


        public double ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public Produto ProdutoDasVenda
        {
            get { return produtoDaVenda; }
            set { produtoDaVenda = value; }
        }
    }
}
