using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPComSolid
{
    class Pedido
    {
        private string status;
        private double valorPedido;
        private CarrinhoCompra carrinhoCompra;

        public Pedido()
        {
            Status = "aberto";
            CarrinhoCompra = new CarrinhoCompra();
        }
        public bool Confirmar()
        {
            if (CarrinhoCompra.ValidarCarrinho())
            {
                Status = "Confirmado";
                return true;
            }
            return false;
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public CarrinhoCompra CarrinhoCompra
        {
            get { return carrinhoCompra; }
            set { carrinhoCompra = value; }
        }
        public double ValorPedido
        {
            get { return valorPedido; }
            set { valorPedido = value; }
        }
    }
}
