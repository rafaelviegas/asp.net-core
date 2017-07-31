using casa_do_codigo.Models;
using System.Collections.Generic;

namespace casa_do_codigo
{
    public interface IDataServices
    {
        void InicializacaoDB();
        List<Produto> GetProdutos();
        List<ItemPedido> GetItensPedido();


    }
}