using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class Estoque : IMostrar
    {
        private int qtdeEstoqueMinimo;
        private int qtdeEstoque;
        private List<Produto> vetProdutosEstoque;

        public Estoque(int qtdeEstoque = 0, int qtdeEstoqueMinimo = 5)
        {
            QtdeEstoqueMinimo = qtdeEstoqueMinimo;
            QtdeEstoque = qtdeEstoque;
        }
        public void Mostrar()
        {
            Console.WriteLine("Quantidade disponível no estoque: " + QtdeEstoque);
        }
          
        public void AdicionarProdutosEstoque(int quantidadeDeProdutos)
        {
            QtdeEstoque += quantidadeDeProdutos;
        }

        public void AnalisarProdutosEstoque(int quantidadeDeProdutos)
        {
            if(QtdeEstoque >= quantidadeDeProdutos)              
                Console.WriteLine("Quantidade de produtos insuficiente.");          
            if (QtdeEstoque < QtdeEstoqueMinimo)
                Console.WriteLine("Baixa quantidade de produtos.");
        }

        public int QtdeEstoqueMinimo
        {
            get { return qtdeEstoqueMinimo; }
            set { qtdeEstoqueMinimo = value; }
        }

        public int QtdeEstoque
        {
            get { return qtdeEstoque; }
            set { qtdeEstoque = value; }
        }

     
    }
}
