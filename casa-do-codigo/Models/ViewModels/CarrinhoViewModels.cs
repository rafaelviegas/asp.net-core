using System.Collections.Generic;
using System.Linq;

namespace casa_do_codigo.Models.ViewModels
{
    public class CarrinhoViewModels
    {
        public List<ItemPedido> Itens { get; set; }

        public decimal Total
        {
            get { return Itens.Sum(x => x.Subtotal); }
        }

        public CarrinhoViewModels(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }
    }
}
