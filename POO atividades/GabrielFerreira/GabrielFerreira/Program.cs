using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrielFerreira
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente("Gabriel Ferreira", "424.767.985-84", "C19818.jpeg", "99606-6622", "gabriel.ferreira68@fatec.sp.gov.br", 1);
            c.Mostrar();

            Console.WriteLine();

            List<Produto> p = new List<Produto>();
            Produto notebook = new Produto(1, "Notebook", 4500.00);
            notebook.AdicionarProdutosEstoque(10);
            p.Add(notebook);
            notebook.Mostrar();
            Console.WriteLine();

            Produto headset = new Produto(2, "Headset", 650.00);
            headset.AdicionarProdutosEstoque(20);
            p.Add(headset);
            headset.Mostrar();

            Console.WriteLine();
            List<ProdutoAComprar> Compras = new List<ProdutoAComprar>();
            ProdutoAComprar produtosDaCompra = new ProdutoAComprar(notebook, 1);
            Compras.Add(produtosDaCompra);
            produtosDaCompra.Mostrar();
            Console.WriteLine();

            /*Venda venda = new Venda(1,c,`20141231 235959`;);
            venda.AdicionarProduto(notebook, 2, 4500);
            venda.Mostrar();*/

            Console.ReadKey();
        }
    }
}
