using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class ProdutoAComprar : IMostrar
    {
        private int qtdeComprar;
        private Produto produtoDaCompra;

        public ProdutoAComprar(Produto produtoDaCompra, int qtdeComprar)
        {
            ProdutoDaCompra = produtoDaCompra;
            QtdeComprar = qtdeComprar;
        }
        public void Mostrar()
        {
            Console.WriteLine("Produto: " + ProdutoDaCompra.Nome + "\nQuantidade da compra:" + QtdeComprar);
        }

        public int QtdeComprar
        {
            get { return qtdeComprar; }
            set { qtdeComprar = value; }
        }
        public Produto ProdutoDaCompra
        {
            get { return produtoDaCompra; }
            set { produtoDaCompra = value; }
        }

    }
}
