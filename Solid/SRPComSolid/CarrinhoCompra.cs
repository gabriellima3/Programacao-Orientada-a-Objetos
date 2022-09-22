using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPComSolid
{
    class CarrinhoCompra
    {
        private List<Itens> vetItens;

        public CarrinhoCompra()
        {
            this.vetItens = new List<Itens>();
        }
        public List<Itens> VetItens
        {
            get { return vetItens; }
        }
        public bool AdicionarItem(Itens it)
        {
            vetItens.Add(it);
            return true;
        }
        public bool ValidarCarrinho()
        {//qtde de itens > 0 retorna true/false
            return vetItens.Count > 0;
        }
    }
}
