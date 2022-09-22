using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class Venda : IMostrar
    {
        private int numero;
        private DateTime date;
        private double valorTotal;
        private List<ProdutoDaVenda> vetItens;
        private Cliente cliente;


        public Venda(int numero, Cliente cliente, DateTime date)
        {
            Numero = numero;
            Date = date;
            Cliente = cliente;
        }
        public void AdicionarProduto(Produto produto, int quantidade, double preco)
        {
            ProdutoDaVenda produtosDaVenda = new ProdutoDaVenda(produto, quantidade, preco);
            VetItens.Add(produtosDaVenda);
        }

        public void Mostrar()
        {
            Console.WriteLine("Numero: " + Numero + "/nData: " + Date);
            Cliente.Mostrar();
        }

        public double ValorTotal
        {
            get { return valorTotal; }
            set { valorTotal = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public List<ProdutoDaVenda> VetItens
        {
            get { return vetItens; }
            set { vetItens = value; }
        }


    }
}
