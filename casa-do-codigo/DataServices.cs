using casa_do_codigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace casa_do_codigo
{
    public class DataServices
    {
        private readonly Context _context;

        public DataServices(Context context)
        {
            _context = context;
        }

        public void InicializacaoDB()
        {
            this._context.Database.EnsureCreated();

            if(this._context.Produtos.Count() == 0)
            {
                IList<Produto> produtos = new[]{

                  new Produto (1,"Sleep not found", 59.90m),
                  new Produto (2,  "May the code be with you", 59.90m),
                  new Produto (3,  "Rollback", 59.90m),
                  new Produto (4,  "REST", 69.90m),
                  new Produto (5,  "Design Patterns com Java", 69.90m),
                  new Produto (6,  "Vire o jogo com Spring Framework", 69.90m),
                  new Produto (7,  "Test-Driven Development", 69.90m),
                  new Produto (8,  "iOS: Programe para iPhone e iPad", 69.90m),
                  new Produto (9,  "Desenvolvimento de Jogos para Android", 69.90m)
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
