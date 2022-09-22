using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPComSolid
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido p = new Pedido();

            Itens it1 = new Itens("Impressora", 1000);
            Itens it2 = new Itens("Monitor", 2000);

            //p obtem a instância de carrinho
            //para depois adicionar
            p.CarrinhoCompra.AdicionarItem(it1);
            p.CarrinhoCompra.AdicionarItem(it2);

            Console.WriteLine("\nItens do carrinho");
            var pp = p.CarrinhoCompra.VetItens;
            double total = 0;
            foreach (Itens it in pp)
            {
                it.MostraItens();
                total += it.Valor;
            }
            Console.WriteLine("\nValor total: " + total);
            Console.WriteLine("\nCarrinho está válido? " +
                p.CarrinhoCompra.ValidarCarrinho());
            Console.WriteLine("\nStatus do pedido: " + p.Status);
            Console.WriteLine("\nConfirmar pedido: " + p.Confirmar());
            Console.WriteLine("\nE-mail");
            if (p.Status == "confirmado")
                EmailService.DispararEmail();
            Console.ReadKey();
        }
    }
}