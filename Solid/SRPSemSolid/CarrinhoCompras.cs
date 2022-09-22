using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSemSolid
{
    class CarrinhoCompras
    {
        private List<Itens> vetItens =
                     new List<Itens>();
        private string status;
        private double valorTotal;
        public CarrinhoCompras()
        {
            this.status = "aberto";
            this.valorTotal = 0;
        }
        public void ExibirItens()
        {
            foreach (Itens it in vetItens)
                it.MostraItens();
        }
        public bool AdicionarItem(Itens it)
        {
            vetItens.Add(it);
            valorTotal += it.Valor;
            return true;
        }
        public double ExibirValotTotal()
        {
            return valorTotal;
        }
        public string ExibirStatus()
        {
            return status;
        }
        public bool ConfirmarPedido()
        {
            //apenas confirma quando tiver
            //pedidos cadastrados
            if ( ValidarCarrinho() )
            {
                status = "confirmado";
                EnviarEmailConfirmacao();
                return true;
            }
            return false;
        }
        public void EnviarEmailConfirmacao()
        {
            Console.WriteLine("Envia e-mail de confirmação");
        }
        public bool ValidarCarrinho()
        {//qtde de itens > 0 retorna true ou false
            return vetItens.Count > 0;
        }
    }
}
