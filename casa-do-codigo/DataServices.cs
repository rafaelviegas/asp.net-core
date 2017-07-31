using casa_do_codigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace casa_do_codigo
{
    public class DataServices : IDataServices
    {
        private readonly Context _context;

        public DataServices(Context context)
        {
            _context = context;
        }

        public List<ItemPedido> GetItensPedido()
        {
            return _context.ItemPedido.ToList();
        }

        public List<Produto> GetProdutos()
        {
            return _context.Produtos.ToList();
        }

        public void InicializacaoDB()
        {
            this._context.Database.EnsureCreated();

            if(this._context.Produtos.Count() == 0)
            {
                IList<Produto> produtos = new[]{

                  new Produto ("Sleep not found", 59.90m),
                  new Produto ("May the code be with you", 59.90m),
                  new Produto ("Rollback", 59.90m),
                  new Produto ("REST", 69.90m),
                  new Produto ("Design Patterns com Java", 69.90m),
                  new Produto ("Vire o jogo com Spring Framework", 69.90m),
                  new Produto ("Test-Driven Development", 69.90m),
                  new Produto ("iOS: Programe para iPhone e iPad", 69.90m),
                  new Produto ("Desenvolvimento de Jogos para Android", 69.90m)
                };

                foreach (var produto in produtos)
                {
                    this._context.Produtos.Add(produto);

                    this._context.ItemPedido.Add(new ItemPedido(produto, 1));
                }

                this._context.SaveChanges();
            }
        }
    }
}
