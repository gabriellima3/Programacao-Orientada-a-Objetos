using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class Produto : Estoque, IMostrar
    {
        private int codigo;
        private string nome;
        private double preco;
        private int qtdeEstoque;
        private List<ProdutoDaVenda> vetProdutos;

        public Produto(int codigo, string nome, double preco) 
        {
            Codigo = codigo;
            Nome = nome;
            Preco = preco;
            QtdeEstoque = qtdeEstoque;
        }

        public new void Mostrar()
        {
            Console.WriteLine("Codigo: " + Codigo + "\nNome: " + Nome + "\nPreco: " + Preco + 
              "\nQuantidade de produtos no estoque: " + QtdeEstoque);
            
        }
                                  
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }


        public List<ProdutoDaVenda> VetProdutos
        {
            get { return vetProdutos; }
            set { vetProdutos = value; }
        }

    }
}
    